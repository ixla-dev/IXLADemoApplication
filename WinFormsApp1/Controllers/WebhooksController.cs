using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WinFormsApp1.Controllers
{
    public static class JsonElementExtensions
    {
        public static bool TryParseWorkflowMessage(this JsonElement json, JsonSerializerOptions serializerOptions,
            ILogger logger, out WorkflowMessage? message)
        {
            message = null;
            try
            {
                if (!Enum.TryParse<MessageType>(json.GetProperty("messageType").GetString(), out var messageType))
                {
                    return false;
                }

                var jsonString = json.ToString();
                message = messageType switch
                {
                    MessageType.WorkflowSchedulerSuspended => JsonSerializer
                        .Deserialize<WorkflowSchedulerProcessSuspendedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowSchedulerStarted => JsonSerializer.Deserialize<WorkflowSchedulerStartedMessage>(
                        jsonString, serializerOptions),
                    MessageType.WorkflowSchedulerStopped => JsonSerializer.Deserialize<WorkflowSchedulerStoppedMessage>(
                        jsonString, serializerOptions),
                    MessageType.WorkflowStarted => JsonSerializer.Deserialize<WorkflowStartedMessage>(jsonString,
                        serializerOptions),
                    MessageType.WorkflowCancelled => JsonSerializer.Deserialize<WorkflowCancelledMessage>(jsonString,
                        serializerOptions),
                    MessageType.WorkflowCompleted => JsonSerializer.Deserialize<WorkflowCompletedMessage>(jsonString,
                        serializerOptions),
                    MessageType.WorkflowFaulted => JsonSerializer.Deserialize<WorkflowFaultedMessage>(jsonString,
                        serializerOptions),
                    MessageType.EncoderLoaded => JsonSerializer.Deserialize<EncoderLoadedMessage>(jsonString,
                        serializerOptions),
                    MessageType.OcrExecuted => JsonSerializer.Deserialize<OcrExecutedMessage>(jsonString,
                        serializerOptions),
                    MessageType.HealthCheck => JsonSerializer.Deserialize<WebhookReceiverHealthCheckMessage>(jsonString,
                        serializerOptions),
                    MessageType.MagneticStripeReadBack => JsonSerializer.Deserialize<MagneticStripeReadBackMessage>(
                        jsonString, serializerOptions),
                    MessageType.OcrReadBack => JsonSerializer.Deserialize<OcrReadBackMessage>(jsonString,
                        serializerOptions),
                    MessageType.ChipReadBack => JsonSerializer.Deserialize<ChipReadBackMessage>(jsonString,
                        serializerOptions),
                    _ => null
                };
                return message != null;
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
                return false;
            }
        }
    }

    [ApiController]
    public class WebhooksController : ControllerBase
    {
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly ILogger<WebhooksController> _logger;

        public WebhooksController(
            JsonSerializerOptions jsonOptions,
            ILogger<WebhooksController> logger)
        {
            _jsonOptions = jsonOptions;
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public ActionResult Home() => Ok("Webhooks handler");

        [HttpPost]
        [Route("ixla/aida/v1/webhooks")]
        public ActionResult OnWebhookMessage(
            [FromServices] IConfiguration configuration,
            [FromServices] MessageCollection messageQueue,
            [FromBody] JsonElement receivedMessage)
        {
            var address = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress?.ToString();

            // AsWorkflowMessage is an extension method defined in Aida.Samples.Integration.Webhooks 
            if (!receivedMessage.TryParseWorkflowMessage(_jsonOptions, _logger, out var message))
                // If the payload does not contain a known message type we short-circuit the request
                // and respond with 400 bad request to the client
                return BadRequest();

            // log the received message from AIDA
            if (configuration.GetValue<bool>("LogMessagePayload"))
                _logger.LogTrace("[{IPAddress}] Received Message {@WebhookMessage}", address, JsonSerializer.Serialize(
                    receivedMessage, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Converters = { new JsonStringEnumConverter() },
                    }));

            // Add the message in an unbounded blocking collection for further processing 
            messageQueue.Enqueue(new MachineMessage(address, message));
            return Ok();
        }
    }
}
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;
using Npgsql;

namespace WinFormsApp1;

public class DeviceDB
{
    private NpgsqlConnection? _dbConnection;
    private string _ipAddress;
    private int _port = 5432;
    private string _database = "ixla_iws";
    private string _password = "root";
    private string _username = "postgres";

    private string   _dbConnectionString;

    private NpgsqlCommand _command;
    private StringBuilder _fieldList;
    private StringBuilder _valuePlaceHolders; 
    
    public DeviceDB(string ipAddress)
    {
        _ipAddress = ipAddress;
        
       _dbConnectionString = new NpgsqlConnectionStringBuilder
        {
            Host = _ipAddress,
            Port = _port,
            Database = _database,
            Password = _password,
            Username = _username
        }.ToString();
       
        _fieldList = new StringBuilder();
        _valuePlaceHolders = new StringBuilder();
    }

    public bool Connect()
    {
        bool reply = false;
        
         if (_dbConnection != null)
        {
            _dbConnection.DisposeAsync();
            _dbConnection = null;
        }

        _dbConnection = new NpgsqlConnection(_dbConnectionString);
        _dbConnection.StateChange += (_, args) =>
        {
            if (args.CurrentState != System.Data.ConnectionState.Broken) return;
            {
                _dbConnection.Close();
            }
        };
        _dbConnection.OpenAsync();
        
        return reply;
    }

    public void Disconnect()
    {
        _dbConnection?.Close();
        _dbConnection?.Dispose();
        _dbConnection = null;
    }

    public NpgsqlConnection GetDbConnection()
    {
        return _dbConnection;
    }

    public void CreateNewCommand()
    {
        _fieldList.Clear();
        _valuePlaceHolders.Clear();
    }
    
    public void AddParameter(string entity)
    {
        if( _fieldList.Length == 0 )
            _fieldList.Append($@"""{entity}""");
        else
            _fieldList.Append($@", ""{entity}""");
        
        if(_valuePlaceHolders.Length == 0 )
            _valuePlaceHolders.Append($"@{entity}");
        else
            _valuePlaceHolders.Append($", @{entity}");
    }
    
    public void BuildCommand(string tableName)
    {
        // var cmdInsert = $@"INSERT INTO {dbTable.TableName} (""correlation_id""{fieldList}) VALUES ( @correlation_id{valuePlaceHolders})";
        var insertCommand = $@"INSERT INTO {tableName} ({_fieldList}) VALUES ( {_valuePlaceHolders})";

        _command = new NpgsqlCommand(insertCommand, _dbConnection);
    }

    public void SetParameterString(string parameterName, string value)
    {
        NpgsqlParameter parameter;
        
        if(parameterName[0] == '@')
            parameter = _command.Parameters.AddWithValue(parameterName,((string)value).ToString());
        else
            parameter = _command.Parameters.AddWithValue($"@{parameterName}",((string)value).ToString());
    }

    public void SetParameterImage(string parameterName, string pathFilename)
    {
        NpgsqlParameter parameter;
        
        if( parameterName[0] == '@')
            parameter = _command.Parameters.AddWithValue(parameterName, File.ReadAllBytes(pathFilename));
        else
            parameter = _command.Parameters.AddWithValue($"@{parameterName}", File.ReadAllBytes(pathFilename));
    }

    public void ExecuteCmd()
    {
        _command.Prepare();
        _command.ExecuteNonQuery();
    }

    public void ClearDbTable(string tableName)
    {
        var delete  = $@"DELETE FROM {tableName};";
        var command = new NpgsqlCommand(delete, _dbConnection);
        command.Prepare();
        command.ExecuteNonQuery();
    }
}
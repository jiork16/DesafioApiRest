using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Data.Data
{
    public static class EfSqlHelper
    {
        public static DbTransaction GetDbTransaction(this IDbContextTransaction source)
        {
            return (source as IInfrastructure<DbTransaction>).Instance;
        }

        public async static Task<DataTable> ExecuteScalar(this DbContext context, string sql, List<DbParameter> parameters = null,
                                            CommandType commandType = CommandType.Text,
                                            int? commandTimeOutInSeconds = null)
        {
            var value = await ExecuteScalar(context.Database, sql, parameters,
                                         commandType, commandTimeOutInSeconds);
            return value;
        }

        public async static Task<DataTable> ExecuteScalar(this DatabaseFacade database,
                                           string sql, List<DbParameter> parameters = null,
                                           CommandType commandType = CommandType.Text,
                                           int? commandTimeOutInSeconds = null)
        {
            DataTable value= new DataTable("Result");
            using (var cmd = database.GetDbConnection().CreateCommand())
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandText = sql;
                cmd.CommandType = commandType;
                if (commandTimeOutInSeconds != null)
                {
                    cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                }
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                Npgsql.NpgsqlDataReader ds = (Npgsql.NpgsqlDataReader)await cmd.ExecuteReaderAsync();
                value.Load(ds);
                //Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter((Npgsql.NpgsqlCommand)cmd).;
                //value = ds.Tables[0];
            }
            return value;
        }
    }
}

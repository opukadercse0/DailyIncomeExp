using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace DailyIncomeExp.DataAccess
{
    public static class SqlDataAccess
    {
        //IDBconnection -===Represents an open connection to a data source,
        //and is implemented by .NET Framework data providers
        //that access relational databases.
        public static string GetConnectionString(string connectionName = "DailyExpInDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
        //for saving data into database
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                  return  cnn.Execute(sql, data);
            }
        }
        //for loading data
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
    }
}
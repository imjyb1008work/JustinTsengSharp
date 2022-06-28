using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
#if NET35
using System.Data.SqlClient;
#else
using Microsoft.Data.SqlClient;
#endif

namespace JustinTsengSharp.Beta.Helpers.Dapper
{
	public class DapperHelper
	{
		public static IEnumerable<T> Query<T>(string connectionString, string sql, object param = null, IDbTransaction transaction = null, bool buff = true, int? commandTimeout = null, CommandType? commandType = null)
		{
			using (var conn = new SqlConnection(connectionString))
			{
				return conn.Query<T>(sql, param, transaction, buff, commandTimeout, commandType);
			}
		}

		public static T QueryFirstOrDefault<T>(string connectionString, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			using (var conn = new SqlConnection(connectionString))
			{
#if NET35
				return conn.Query<T>(sql, param, transaction, true, commandTimeout, commandType).FirstOrDefault();
#else
				return conn.QueryFirstOrDefault<T>(sql, param, transaction, commandTimeout, commandType);
#endif
			}
		} 

		public static DataTable GetDataTable(string connectionString, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			using (var conn = new SqlConnection(connectionString))
			{
				var dr = conn.ExecuteReader(sql, param, transaction, commandTimeout, commandType);
				var dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static int Exccute(string connectionString, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			using (var conn = new SqlConnection(connectionString))
			{
				return conn.Execute(sql, param, transaction, commandTimeout, commandType);
			}
		}
	}
}

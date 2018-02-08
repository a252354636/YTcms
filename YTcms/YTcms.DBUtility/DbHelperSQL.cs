using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;

namespace YTcms.DBUtility
{
  public abstract class DbHelperSQL
  {
    //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.		
    public static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private static readonly string connectionName = ConfigurationManager.AppSettings["ConnectionName"];
    public static IDbConnection CreateConnection()
    {
      IDbConnection conn = null;
      switch (connectionName)
      {
        case "SQLServer":
          conn = new SqlConnection(connectionString);
          break;
        default:
          conn = new SqlConnection(connectionString);
          break;
      }
      conn.Open();
      return conn;
    }
  }
}

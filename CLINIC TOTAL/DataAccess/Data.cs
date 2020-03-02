using System;
using System.Data.Common;
using System.Configuration;
using System.Data;
using System.Collections.Generic;

namespace DataAccess
{
    public static class Data
    { 
        public static string dataProvider ="System.Data.SqlClient";
        private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);
        public static string connectionString =string.Empty;
        public static string Server = string.Empty;
        public static string Database = string.Empty;
        public static string UserID = string.Empty;
        public static string Password = string.Empty;
        public static bool IsWindowAuthenMod = false;
        public static DateTime DatetimeNull = new DateTime(1900, 1, 1);
       
        public static string ConnectionString
        {
            get {
                connectionString = String.Format("server={0};database={1};", Server, Database);
                if (IsWindowAuthenMod)
                {
                    connectionString += "Integrated Security=true;";
                }
                else
                {
                    connectionString += String.Format("uid={0};pwd={1};Connection Timeout=10000", UserID, Password);
                }
                return connectionString; }
            set { connectionString = value; }
        }

        #region parameters

        public static DbParameter CreateParameter(string ParameterName)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            return p;
        }

        public static DbParameter CreateParameter(string ParameterName, object ParameterValue)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            p.Value = ParameterValue;
            if (p.Value == null)
                p.Value = DBNull.Value;
            else if (p.Value == DBNull.Value)
                p.Value = DBNull.Value;
            else if (p.DbType == DbType.String && (((string)p.Value).Trim().Length == 0 || (string)p.Value == "0"))
                p.Value = DBNull.Value;
            else if (p.DbType == DbType.DateTime && ((DateTime)p.Value == new DateTime(1900, 1, 1)))
                p.Value = DBNull.Value;
            else
                p.Value = p.Value;
            if (p.DbType == DbType.String && p.Value!=DBNull.Value)
                p.Value = ((string)p.Value).Trim();
            return p;
        }         

        public static DbParameter CreateParameter(string ParameterName, DbType ParameterType, int ParameterSize)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            p.DbType = ParameterType;
            p.Size = ParameterSize;
            return p;
        }

        public static DbParameter CreateParameter(string ParameterName, object ParameterValue, DbType ParameterType)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            p.Value = ParameterValue;
            p.DbType = ParameterType;
            if (p.Value == null)
                p.Value = DBNull.Value;
            else if (p.DbType == DbType.String && (((string)p.Value).Trim().Length == 0 || (string)p.Value == "0"))
                p.Value = DBNull.Value;
            else if (p.DbType == DbType.DateTime && ((DateTime)p.Value == new DateTime(1900, 1, 1)))
                p.Value = DBNull.Value;
            //else if (p.DbType == DbType.Int32 && ((Int32)p.Value == 0))
            //    p.Value = DBNull.Value;
            return p;
        }    

        #endregion

        public static DataTable getTable(string table, string col1, string col2,string colwh,string where)
        {
            string sql = String.Format("select [{0}],[{1}] from [{2}]", col1, col2, table);
            sql += where.Length == 0 ? string.Empty : String.Format("where [{0}]='{1}'", colwh, where);
            return SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql, null).Tables[0];
        }

        public static DataTable getTable(string table, string colwh,string where)
        {
            string sql = String.Format("select * from [{0}]", table);
            sql += where.Length == 0 ? string.Empty : String.Format("where [{0}]='{1}'", colwh, where);
            return SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql, null).Tables[0];
        }

        public static DataSet getds(string sql)
        {
            return SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql, null);
        }

        public static DataTable getTable(string sql)
        {
            try
            {
                return SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql, null).Tables[0];
            }
            catch { return null; }
        }
        public static DataTable dataforCombo(string table, string column1, string column2)
        {
            string sql = String.Format("select [{0}],[{1}] from [{2}] order by {2}.[{1}]", column1, column2, table);
          return SqlHelper.ExecuteDataSet(connectionString, CommandType.Text, sql, null).Tables[0];
        }

        public static DataTable dataforCombo(string table, string column1, string column2, string where)
        {
            string sql = String.Format("select [{0}],[{1}] from [{2}]", column1, column2, table);
            sql += where.Length == 0 ? "" : "where " + where;
            sql += String.Format(" order by {0}.[{1}]", table, column2);
            return SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql, null).Tables[0];
        }

        public static int NewIntID(string table, string column)
        {
            int intID = -1;
            //select isnull(max(socialid)+1,1) from social
            string sql = String.Format("select isnull(max([{0}])+1,1) from [{1}]", column, table);
            try
            {
                intID = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql, null));
            }
            catch { }
            return intID;
        }

        public static int NewIntID(string table, string column, string where)
        {
            int intID = -1;
            //select isnull(max(socialid)+1,1) from social
            string sql = String.Format("select isnull(max([{0}])+1,1) from [{1}] where {2}", column, table, where);
            try
            {
                intID = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql, null));
            }
            catch { }
            return intID;
        }

        public static string NewIntIDToString(string table, string column,int minLeng)
        {
            int intID = 1;
            string strID = "";
            //select isnull(max(socialid)+1,1) from social
            string sql = String.Format("select isnull(max(cast([{0}] as int))+1,1)  from [{1}]", column, table);
            try
            {
                intID = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql, null));
                strID = intID.ToString();
                while (strID.Length < minLeng) strID = "0" + strID;
            }
            catch {  
            }
            return strID;
        }

        public static string NewIntIDToString(string table, string column, int minLeng, string kt)
        {
            int intID = 1;
            string strID = "0";
            //select isnull(max(socialid)+1,1) from social
            //string sql = "select isnull(max(cast(SUBSTRING([" + column + "]," + (kt.Length + 1) + ",10)as int))+1,1)  from [" + table + "] where Charindex('"+kt+"',["+ column+"])<>0";
            string sql = String.Format("select isnull(max(cast(SUBSTRING([{0}],{1},10)as int))+1,1)  from [{2}] where Charindex('{3}',[{4}])<>0",column,kt.Length+1,table,kt,column);
            try
            {
                intID = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql, null));
                strID = intID.ToString();
                while (strID.Length < minLeng-kt.Length) strID = "0" + strID;
            }
            catch
            {
            }
            return kt+strID;
        }

        public static bool CheckNameEixts(string table, string col, string value)
        {
            string sql = String.Format("select count(*) from {0} where {1}=N'{2}'", table, col, value);
            int c= Convert.ToInt32(SqlHelper.ExecuteScalar(Data.ConnectionString, CommandType.Text, sql, null));
            if (c > 0) return true;
            else return false;
        }

        public static bool CheckIDEixts(string table, string col, string value)
        {
            string sql = string.Format("select count(*) from [{0}] where [{1}]=N'{2}'", table, col, value);
            //string sql = "select count(*) from [" + table + "] where [" + col + "] = N'" + value + "'";
            int c = Convert.ToInt32(SqlHelper.ExecuteScalar(Data.ConnectionString, CommandType.Text, sql, null));
            if (c > 0) return true;
            else return false;
        }

        public static bool CheckIDEixts(string table, string col, string value, string col2, string value2)
        {
            string sql = string.Format("select count(*) from [{0}] where [{1}]=N'{2}' and  [{3}]<>N'{4}'", table, col, value,col2,value2);
            //string sql = "select count(*) from [" + table + "] where [" + col + "] = N'" + value + "'";
            int c = Convert.ToInt32(SqlHelper.ExecuteScalar(Data.ConnectionString, CommandType.Text, sql, null));
            if (c > 0) return true;
            else return false;
        }

        public static bool CheckIDEixts(string table, string col, string value, string col2, string value2,bool Isby)
        {
            string sql;
            if (Isby)
                sql = string.Format("select count(*) from [{0}] where [{1}]=N'{2}' and  [{3}]=N'{4}'", table, col, value, col2, value2);
            else
                sql = string.Format("select count(*) from [{0}] where [{1}]=N'{2}' and  [{3}]<>N'{4}'", table, col, value, col2, value2);
            //string sql = "select count(*) from [" + table + "] where [" + col + "] = N'" + value + "'";
            int c = Convert.ToInt32(SqlHelper.ExecuteScalar(Data.ConnectionString, CommandType.Text, sql, null));
            if (c > 0) return true;
            else return false;
        }

        public static bool CheckNameEixts(string table, string col, string value,string exWhere)
        {
            string sql = String.Format("select count(*) from {0} where {1} =N'{2}'", table, col, value);
            if (exWhere.Length > 0)
            {
                if (exWhere.ToLower().Contains("and")) sql += " " + exWhere;
                else sql += " and " + exWhere;
            }
            int c = Convert.ToInt32(SqlHelper.ExecuteScalar(Data.ConnectionString, CommandType.Text, sql, null));
            if (c > 0) return true;
            else return false;
        }

        public static DateTime getCurrentdate()
        {
            string sql = "select GETDATE()  as [date]";
            DataTable dt = SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.Text, sql, null).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
                return (DateTime)dt.Rows[0]["date"];
            else
                return DateTime.Now;
        }

        // Update
        public static void Update(string sql)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sql, null);
        }

        public static int Insert(string sql)
        {
           return SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sql, null);
        }

        public static void Delete(string sql)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sql, null);
        }

        /// <summary>
        /// Get Dataset
        /// </summary>
        /// <param name="proc"></param>
        /// <param name="pName"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static DataSet GetDataset(string proc, List<string> pName, List<object> pValue)
        {
           List<DbParameter> parameters=new List<DbParameter>();          
           for(int i=0;i<pName.Count;i++)         
               parameters.Add(Data.CreateParameter(pName[i], pValue[i]));
            return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure, proc,parameters.ToArray());
        }

        /// <summary>
        /// Get Dataset
        /// </summary>
        /// <param name="proc"></param>
        /// <param name="pName"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static DataSet GetDataset(string Query, CommandType commandType, List<string> pName, List<object> pValue)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            if (pName != null)
                for (int i = 0; i < pName.Count; i++)
                    parameters.Add(Data.CreateParameter(pName[i], pValue[i]));
            return SqlHelper.ExecuteDataSet(Data.ConnectionString, commandType, Query, parameters.ToArray());
        }

        /// <summary>
        /// ExecuteNonQuery
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="commandType"></param>
        /// <param name="pName"></param>
        /// <param name="pValue"></param>
        public static void ExecuteNonQuery(string Query, CommandType commandType, List<string> pName, List<object> pValue)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            if (pName != null)
                for (int i = 0; i < pName.Count; i++)
                    parameters.Add(Data.CreateParameter(pName[i], pValue[i]));
            SqlHelper.ExecuteNonQuery(Data.ConnectionString, commandType, Query, parameters.ToArray());
        }

        /// <summary>
        /// ExecuteScalar
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="commandType"></param>
        /// <param name="pName"></param>
        /// <param name="pValue"></param>
        public static object ExecuteScalar(string Query, CommandType commandType, List<string> pName, List<object> pValue)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            if (pName != null)
                for (int i = 0; i < pName.Count; i++)
                    parameters.Add(Data.CreateParameter(pName[i], pValue[i]));
            return SqlHelper.ExecuteScalar(Data.ConnectionString, commandType, Query, parameters.ToArray());
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLogic
{
    public static class Data
    {
        
        public static string Server
        {
            get { return DataAccess.Data.Server; }
        }
        public static string Database
        {
            get { return DataAccess.Data.Database; }
        }
        public static string UserID
        {
            get { return DataAccess.Data.UserID; }
        }
        public static string Password
        {
            get { return DataAccess.Data.Password; }
        }
        public static bool isTrusted
        {
            get { return DataAccess.Data.IsWindowAuthenMod; }
        }
        public static int NewIntID(string table, string column)
        {
            return DataAccess.Data.NewIntID(table, column);
        }

        public static int NewIntID(string table, string column, string where)
        {
            return DataAccess.Data.NewIntID(table, column, where);
        }

        public static string NewIntIDToString(string table, string column, int minLeng)
        {
            return DataAccess.Data.NewIntIDToString(table, column, minLeng);
        }

        public static string NewIntIDToString(string table, string column, int minLeng, string kt)
        {
            return DataAccess.Data.NewIntIDToString(table, column, minLeng, kt);
        }
        public static bool CheckNameEixts(string table, string col, string val)
        {
            return DataAccess.Data.CheckNameEixts(table, col, val);
        }

        public static bool CheckNameEixts(string table, string col, string val, string exWhere)
        {
            return DataAccess.Data.CheckNameEixts(table, col, val, exWhere);
        }

        /// <summary>
        /// Khi Insert
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool CheckIDEixts(string table, string col, string val)
        {
            return DataAccess.Data.CheckIDEixts(table, col, val);
        }
        /// <summary>
        /// Check khi update
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        /// <param name="col2"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool CheckIDEixts(string table, string col, string value, string col2, string value2)
        {
            return DataAccess.Data.CheckIDEixts(table, col, value, col2, value2);
        }
        /// <summary>
        /// Kiem tra khi dk bang
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        /// <param name="col2"></param>
        /// <param name="value2"></param>
        /// <param name="Isby"></param>
        /// <returns></returns>
        public static bool CheckIDEixts(string table, string col, string value, string col2, string value2, bool Isby)
        {
            return DataAccess.Data.CheckIDEixts(table, col, value, col2, value2, Isby);
        }

        public static DataTable dataforCombo(string table, string column1, string column2)
        {
            return DataAccess.Data.dataforCombo(table, column1, column2);
        }

        public static DataTable dataforCombo(string table, string column1, string column2, string where)
        {
            return DataAccess.Data.dataforCombo(table, column1, column2, where);
        }

        public static DataTable getTable(string table, string colwh, string where)
        {
            return DataAccess.Data.getTable(table, colwh, where);
        }
        public static DataTable getTable(string table, string col1, string col2, string colwh, string where)
        {
            return DataAccess.Data.getTable(table, col1, col2, colwh, where);
        }

        public static DataTable GetDatatable(string sql)
        {
            return DataAccess.Data.getTable(sql);
        }

        public static DataSet getds(string sql)
        {
            return DataAccess.Data.getds(sql);
        }

        public static DateTime getCurrentdate()
        {
            return DataAccess.Data.getCurrentdate();
        }

        public static void Update(string sql)
        {
            DataAccess.Data.Update(sql);
        }

        public static int Insert(string sql)
        {
           return DataAccess.Data.Insert(sql);
        }

        public static void Delete(string sql)
        {
            DataAccess.Data.Delete(sql);
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
            return DataAccess.Data.GetDataset(proc, pName, pValue);
        }

        /// <summary>
        /// GetDataset
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="commandType"></param>
        /// <param name="pName"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static DataSet GetDataset(string Query, CommandType commandType, List<string> pName, List<object> pValue)
        {
            return DataAccess.Data.GetDataset(Query, commandType, pName, pValue);
        }

        /// <summary>
        /// Lay du lieu, khong tham so
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public static DataSet GetDataset(string Query)
        {
            return DataAccess.Data.GetDataset(Query, CommandType.Text, null, null);
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
            DataAccess.Data.ExecuteNonQuery(Query, commandType, pName, pValue);
        }

       /// <summary>
       /// Them moi,cap nhat,xoa khong tham so
       /// </summary>
       /// <param name="Query"></param>
        public static void ExecuteNonQuery(string Query)
        {
            DataAccess.Data.ExecuteNonQuery(Query, CommandType.Text, null, null);
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
            return DataAccess.Data.ExecuteScalar(Query, commandType, pName, pValue);
        }

        public static double ConvertToDouble(string s)
        {
            return DataAccess.Commom.ConvertToDouble(s);
        }
           
    }    
}

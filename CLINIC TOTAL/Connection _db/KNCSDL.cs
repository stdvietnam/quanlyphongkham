using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connection_db
{
    public class KNCSDL
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection cn;
        private SqlCommand myCommand;
        private Boolean Ketnoithanhcong = true;
        private ConnectionInfor conn = new ConnectionInfor();
        //string strConn = "SERVER=MAYTINH\\SQLEXPRESS;DATABASE=QUANLYBANHANG;Integrated Security=True";
        //string strConn = @"Initial Catalog=QUANLYBANHANG;Server=MAYTINH\SQLEXPRESS;Integrated Security=True ";
        public string Server
        {
            get { return conn.Server; }
        }
        public string Database
        {
            get { return conn.Database; }

        }
        public string Username
        {
            get { return conn.Username; }
        }
        public string Pasword
        {
            get { return conn.Pasword; }
        }
        public SqlConnection openConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Closed | cn.State == ConnectionState.Broken)
                {
                    cn.Open();
                    Ketnoithanhcong = true;
                }
            }
            catch (Exception)
            {
                Ketnoithanhcong = false;

                //MessageBox.Show("Lỗi kết nối tới SQL Server!", "Thông báo");

            }

            return cn;
        }
        public SqlConnection closeConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Open | cn.State == ConnectionState.Connecting)
                {
                    cn.Close();
                    Ketnoithanhcong = true;
                }
            }
            catch
            {
                Ketnoithanhcong = false;
                //MessageBox.Show("Lỗi kết nối tới SQL Server!", "Thông báo");
            }
            return cn;
        }
        public KNCSDL()
        {
            myAdapter = new SqlDataAdapter();
            //cn = new SqlConnection(strConn);
            cn = new SqlConnection(conn.strConnectionInfor());
            myCommand = new SqlCommand();
        }
        public KNCSDL(string _Server, string _Database, string _Username, string _Password)
        {
            myAdapter = new SqlDataAdapter();
            string strConn = "SERVER=" + _Server + ";DATABASE=" + _Database + ";User Id=" + _Username + ";Password=" + _Password + ";Connect TimeOut=30";
            cn = new SqlConnection(strConn);
            myCommand = new SqlCommand();
        }
        public Boolean testopenConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Closed | cn.State == ConnectionState.Broken)
                {
                    cn.Open();
                    Ketnoithanhcong = true;
                }
            }
            catch (Exception)
            {
                Ketnoithanhcong = false;

                //MessageBox.Show(ex.StackTrace.ToString());

            }

            return Ketnoithanhcong;
        }
        public DataTable executeSelectQuery(string _query, CommandType ct, SqlParameter[] mysqlParameter)
        {
            DataTable mydataTable = new DataTable();
            mydataTable = null;
            DataSet ds = new DataSet();
            myCommand.Connection = openConnection();
            if (Ketnoithanhcong)
            {
                try
                {
                    myCommand.Parameters.Clear();
                    myCommand.CommandText = _query;
                    myCommand.CommandType = ct;
                    if (mysqlParameter != null)
                    {
                        // Neu khong co dieu kien/bien dau vao ->null;
                        myCommand.Parameters.AddRange(mysqlParameter);
                    }
                    myCommand.ExecuteNonQuery();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(ds);
                    mydataTable = ds.Tables[0];
                    closeConnection();
                    ds.Dispose();
                    myCommand.Dispose();
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.StackTrace.ToString());
                    //MessageBox.Show("Error - Connection.executeSelectQuery - Query:" + _query + " \\nException: " + ex.StackTrace.ToString());
                    return null;

                }
            }

            return mydataTable;
        }
        public bool executeInsertQuery(string _query, CommandType ct, SqlParameter[] mysqlParameter)
        {
            bool bo = false;
            myCommand.Connection = openConnection();
            if (Ketnoithanhcong)
            {
                try
                {
                    myCommand.Parameters.Clear();
                    myCommand.CommandText = _query;
                    myCommand.CommandType = ct;

                    if (mysqlParameter != null)
                    {
                        // Neu khong co dieu kien/bien dau vao ->null;
                        myCommand.Parameters.AddRange(mysqlParameter);
                    }
                    myAdapter.InsertCommand = myCommand;
                    myCommand.ExecuteNonQuery();
                    closeConnection();
                    bo = true;
                }

                catch (Exception)
                {
                    bo = false;
                    //MessageBox.Show(ex.StackTrace.ToString());
                    //MessageBox.Show("Bạn không có quyền này", "QUANLYBANHANG-THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return bo;
        }
        public bool executeUpdateQuery(string _query, CommandType ct, SqlParameter[] mysqlParameter)
        {
            bool bo = false;
            myCommand.Connection = openConnection();
            if (Ketnoithanhcong)
            {
                try
                {
                    myCommand.Parameters.Clear();

                    myCommand.CommandText = _query;
                    myCommand.CommandType = ct;
                    if (mysqlParameter != null)
                    {
                        // Neu khong co dieu kien/bien dau vao ->null;
                        myCommand.Parameters.AddRange(mysqlParameter);
                    }
                    myAdapter.UpdateCommand = myCommand;
                    myCommand.ExecuteNonQuery();
                    closeConnection();
                    bo = true;
                }

                catch (Exception)
                {
                    bo = false;

                    //MessageBox.Show(ex.StackTrace.ToString());
                    //MessageBox.Show("Bạn không có quyền này", "QUANLYBANHANG-THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {

                }
            }
            return bo;
        }
        public bool executeDeleteQuery(string _query, CommandType ct, SqlParameter[] mysqlParameter)
        {
            bool bo = false;
            myCommand.Connection = openConnection();
            if (Ketnoithanhcong)
            {
                try
                {
                    myCommand.Parameters.Clear();

                    myCommand.CommandText = _query;
                    myCommand.CommandType = ct;
                    myCommand.Parameters.AddRange(mysqlParameter);
                    myAdapter.DeleteCommand = myCommand;
                    myCommand.ExecuteNonQuery();
                    closeConnection();
                    bo = true;
                }

                catch (Exception)
                {

                    bo = false;
                    //MessageBox.Show(ex.StackTrace.ToString());
                    //MessageBox.Show("Bạn không có quyền này", "QUANLYBANHANG-THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {

                }
            }
            return bo;
        }
    }
}

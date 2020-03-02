using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using System.Diagnostics;
namespace Connection_db
{
    public partial class Login_Database :Form
    {
        public Login_Database()
        {
            InitializeComponent();
        }
        private ConnectionInfor _ConnInfor = new ConnectionInfor();
        private KNCSDL kn;
        private Int16 i = 0;
        private string[] vs = new string[1];
        private void Login_Database_Load(object sender, EventArgs e)
        {
            //txtserver.Text = "103.78.88.10";
            //txtUser.Text = "user_dakhoa";
            //txtPass.Text = "duc@123";
            //txtdata.Text = "std_phongkham_dakhoa_demo";
            txtserver.Text = "local";
            txtUser.Text = "sa";
            txtPass.Text = "123";
            txtdata.Text = "STD_CLINIC_TOTAL";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            Boolean bo;
            if (txtserver.Text == "")
            {
                MessageBox.Show("Chưa nhập tên Server");
                kiemtra = false;
            }
            else
            {
                if (txtdata.Text == "")
                {
                    MessageBox.Show("Chưa chọn Database");
                    kiemtra = false;
                }
            }
            if (kiemtra)
            {
               _ConnInfor.Database = txtdata.Text.Trim();
               _ConnInfor.Server = txtserver.Text.Trim();
               _ConnInfor.Username = txtUser.Text.Trim();
                _ConnInfor.Pasword = txtPass.Text.Trim();
                _ConnInfor.SerialKey = "";
                kn = new KNCSDL(_ConnInfor.Server,_ConnInfor.Database,_ConnInfor.Username,_ConnInfor.Pasword);
                bo = kn.testopenConnection();
                 if (bo == true)
                {
                    MessageBox.Show("Đã kết nối đến Server thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _ConnInfor.Save_Connect();//Thay doi duong dan
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi kết nối đến Server!\n Bạn cần kiểm tra tên server,tên databse,\n tên đăng nhập và mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    i++;
                }
            }
            if (i == 4)
            {
                Application.Exit();
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

      }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections;



namespace Connection_db
{
    public static class Manhanvien
    {
        public  static string manhanvien="";
        public static Int16 Quyen = -1;
        public static Int16 quanly = 0;
    }
    class Class_Public
    {
        public string _Server="";
        public string _Database="";
        public string _User="";
        public string _Pass="";
        //public string _manv;
        public string Chuanhoa_chucaidau(string strChuoi)
        {
            if (strChuoi.Length > 0)
            {
                strChuoi = strChuoi.Trim();
                strChuoi = strChuoi.Substring(0, 1).ToUpper() + strChuoi.Substring(1);
                for (Int16 i = 0; i < strChuoi.Length; i++)
                {
                    if (strChuoi.Substring(i, 1) == " ")
                    {
                        string strTemp = strChuoi.Substring(i + 1).Trim();                        
                        strChuoi = strChuoi.Substring(0, i) + " " + strTemp;
                    }
                }
            }
            return strChuoi;
        }
        public string Chuanhoaten(string Hoten)
        {
            if (Hoten.Length > 0)
            {
                Hoten = Hoten.Trim();
                Hoten = Hoten.Substring(0, 1).ToUpper() + Hoten.Substring(1);
                for (Int16 i = 0; i < Hoten.Length; i++)
                {
                    if (Hoten.Substring(i, 1) == " ")
                    {
                        string strTemp = Hoten.Substring(i + 1).Trim();
                        strTemp = strTemp.Substring(0, 1).ToUpper() + strTemp.Substring(1);
                        Hoten = Hoten.Substring(0, i) + " " + strTemp;
                    }
                }
            }
            return Hoten;
        }
        public Boolean Kiemtra_chuoiso(string myStr)
        {
          try
            {
                myStr = Chuanhoachuoi_so(myStr).ToString();
                Convert.ToDouble(myStr);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string Layma(string strMa, string strManhom, string strmakd)
        {
            string strMaMoi = "";
            //bool ok = false;
            int i = 0;
            if (strManhom.Length > 0 && strMa.Length > strManhom.Length)
            {
                strMa = strMa.Substring(strManhom.Length);
            }
            if (strMa.Length > 0)
            {
                for (i = 0; i <= strMa.Length - 1; i++)
                {

                    if (Kiemtra_chuoiso(strMa.Substring(i, 1)))
                    {
                        strMaMoi += strMa.Substring(i, 1);
                    }
                }
            }
            if (Kiemtra_chuoiso(strMaMoi) && strMaMoi!="")
            {
                if (int.Parse(strMaMoi.Substring(0, 1)) == 0)
                {
                    if (strMaMoi.Length == 2)
                    {
                        if (int.Parse(strMaMoi) < 9)
                        {
                            strMaMoi = "0" + (int.Parse(strMaMoi) + 1).ToString();
                        }
                        else
                        {
                            strMaMoi = "10";
                        }
                    }
                    else
                    {
                        if (int.Parse(strMaMoi.Substring(strMaMoi.Length - 1, 1)) != 9)
                        {
                            strMaMoi = strMaMoi.Substring(0, strMaMoi.Length - 1) + (Convert.ToInt16(strMaMoi.Substring(strMaMoi.Length - 1, 1)) + 1).ToString();
                        }
                        else if (int.Parse(strMaMoi.Substring(strMaMoi.Length - 2, 1)) != 0 && int.Parse(strMaMoi.Substring(strMaMoi.Length - 2, 1)) != 9)
                        {
                            strMaMoi = strMaMoi.Substring(0, strMaMoi.Length - 2) + (Convert.ToInt16(strMaMoi.Substring(strMaMoi.Length - 2, 2)) + 1).ToString();
                        }
                        else
                        {
                            if (int.Parse(strMaMoi.Substring(strMaMoi.Length - 2, 1)) == 9)
                            {
                                strMaMoi = strMaMoi.Substring(0, strMaMoi.Length - 3) + (Convert.ToInt16(strMaMoi.Substring(strMaMoi.Length - 3, 3)) + 1).ToString();
                            }
                            else
                            {
                                strMaMoi = strMaMoi.Substring(0, strMaMoi.Length - 2) + "10";

                            }
                        }
                    }
                }
                else
                {
                    strMaMoi = Convert.ToString(Convert.ToInt64(strMaMoi) + 1);
                }
            }
            else
            {
                strMaMoi = strmakd;
            }
            return strManhom.ToUpper() + strMaMoi;
        }
        //------------------Hàm doc so tien ra chu------------------------------
        public string DoiSoVND(string x)
        {
            x = ((Int64)float.Parse(x)).ToString();
            //Doi toan bo chuoi so thanh chu và đọc theo VNĐ
            string[] Donvi = { "", "nghìn ", "triệu ", "tỷ ", "nghìn ", "triệu ", "tỷ " };
            string so = null;
            string chuoi = "";
            string temp = null;
            Int32 ID = 0;
            //Dim sochan As Boolean
            if (x.Length > 21)
            {
                MessageBox.Show("Số quá lớn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                return null;
            }
            //Neu bang 0 thoat ra luon
                if (Convert.ToInt64(x) == 0)
            {
                return chuoi;
            }

            //Neu tat ca cac so dung sau con so dau tien deu la 0 thi la so (tie^`n) chan
            //If Right(x, Len(x) - 1) = 0 Or Len(x) = 1 Then sochan = True
            while (x != "")
            {
                if (x.Length != 0)
                {
                    so = Lay3So(x);

                    x = x.Substring(0, (x.Length - so.Length));
                    temp = Tinh3So(so);
                    so = temp;
                    if (so != "")
                    {
                        temp = temp + Donvi[ID];
                        chuoi = temp + chuoi;
                    }
                    else
                    {
                        //So=""
                        if (ID == 3)
                        {
                            chuoi = temp + "tỷ " + chuoi;
                        }
                    }
                    ID = ID + 1;
                }
            }
            //Doi ky tu dau tien cua chuoi ra chu hoa
            chuoi = chuoi.Substring(0, 1).ToUpper() + chuoi.Substring(1);
            chuoi = chuoi + "đồng";
            return chuoi.Trim();
        }
       private string Lay3So(string x)
        {
            //Tach chuoi so thanh tung nhom 3 ky tu
            string so = null;
            if (x.Length >= 3)
            {
                so = x.Substring(x.Length - 3, 3);
            }
            else
            {
                so = x.Substring(0);
            }
            return so;
        }
        private string Tinh3So(string x)
        {
            //Chuyen 3 ky tu so da lay duoc thanh chu
            string functionReturnValue = null;
            string chuoi = "";
            string temp = null;
            bool flag0 = false;
            bool flag1 = false;
            temp = x;
            string[] KySo = { "không ", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín " };
            //Neu bang khong, thoat ra luon
            if (x == "000")
            {
                functionReturnValue = "";
                goto End1;
            }
            //Xet hang tram
            if (x.Length == 3)
            {
                chuoi = KySo[int.Parse(x.Substring(0, 1))] + "trăm ";
                x = x.Substring(x.Length - 2, 2);
            }
            //Xet hang chuc           
            if (x.Length == 2 & x != "00")
            {
                switch (int.Parse(x.Substring(0, 1)))
                {
                    case 0:
                        chuoi = chuoi + "linh" + " ";
                        flag0 = true;
                        break;
                    case 1:
                        chuoi = chuoi + "mười ";
                        flag1 = true;
                        break;
                    default:
                        chuoi = chuoi + KySo[int.Parse(x.Substring(0, 1))] + "muơi ";
                        break;
                }
                x = x.Substring(x.Length - 1, 1);
            }
            //Xet hang don vi
            switch (int.Parse(x))
            {
                case 1:
                    if (!flag0 & !flag1 & temp.Length > 1)
                    {
                        chuoi = chuoi + "mốt ";
                    }
                    else
                    {
                        chuoi = chuoi + "một ";
                    }

                    break;
                case 5:
                    if (flag0 || temp.Length == 1) chuoi = chuoi + "năm ";
                    if (flag1) chuoi = chuoi + "lăm ";
                    if (!flag0 & !flag1 & temp.Length > 1) chuoi = chuoi + "lăm ";
                    break;
                case 4:
                    if (!flag1 & !flag0 & chuoi.Length > 1)
                    {
                        chuoi = chuoi + "tư ";
                    }
                    else
                    {
                        chuoi = chuoi + "bốn ";
                    }

                    break;
                default:
                    if ((temp.Length <= 2 & int.Parse(x) != 0) | (temp.Length == 3 & int.Parse(x) != 0)) chuoi = chuoi + KySo[int.Parse(x.Substring(0, 1))];
                    break;
            }
            functionReturnValue = chuoi;
        End1:
            return functionReturnValue;
        }
        //---------------------------Chuan hoa chuoi------------------------------
      public float Chuanhoachuoi_so(string chuoi)
        {
            if (chuoi == "")
            { chuoi = "0"; }
            chuoi = chuoi.Trim();
            chuoi = chuoi.Replace(",", "");
         
            return float.Parse(chuoi.Trim());
        }
        //------------------------------Dung de xoa Grv--------------------------------
        public void myClear_Grv(DataGridView Grv)
        {
            int sodong=Grv.Rows.Count;
            int i = 0;
            while (i<sodong && sodong>1)
            {
                Grv.Rows.RemoveAt(i);
                sodong--;
                
            }
        }
        public string chuahoa_Barcode(string Barcode_)
        {
            while (Barcode_.Substring(0, 1) == "0")
            {
                Barcode_ = Barcode_.Substring(1);
            }
            return Barcode_;
        }
        public Boolean Kiemtra_Barcode(string Barcode_)
        {
            string Barcode;
            int makt,i,_makt;
            int Tongle, Tongchan,tong;
            Tongchan = 0;
            Tongle = 0;
            i = 0;
            Barcode = Barcode_.Substring(0,Barcode_.Length-1);
            makt =int.Parse(Barcode_.Substring(Barcode_.Length - 1));
            while (i<Barcode.Length )
            {
                if (i % 2 == 0)
                {
                    Tongchan += int.Parse(Barcode.Substring(Barcode.Length - i-1,1));
                    i++;
                }
                else
                {
                    Tongle += int.Parse(Barcode.Substring(Barcode.Length - i - 1,1));
                    i++;
                }
            }
            tong = Tongchan * 3 + Tongle;
            _makt = (10 - tong % 10)%10;
            if (makt == _makt)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       
        //------------------------Ham ma hoa mat khau---------------------------------
        private byte[] key = { }; // we are going to pass in the key portion in our method calls
        private byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xab, 0xcd, 0xef };
        public string DecryptFromBase64String(string stringToDecrypt, string sEncryptionKey)
        {
            byte[] inputByteArray = new byte[stringToDecrypt.Length + 1];
            // Note: The DES CryptoService only accepts certain key byte lengths()
            // We are going to make things easy by insisting on an 8 byte legal key length
            key = System.Text.Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            // we have a base 64 encoded string so first must decode to regular unencoded (encrypted) string
            inputByteArray = Convert.FromBase64String(stringToDecrypt);
            // now decrypt the regular string
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding;
            encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }
        public string EncryptToBase64String(string stringToEncrypt, string sEncryptionKey)
        {

            key = System.Text.Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            // convert our input string to a byte array
            byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
            //now encrypt the bytearray
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            // now return the byte array as a "safe for XMLDOM" Base64 String
            return Convert.ToBase64String(ms.ToArray());

        }
        //--------------------------------o0o--------------------------------------------
    }
}

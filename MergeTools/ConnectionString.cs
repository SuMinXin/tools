using MergeTools.Encrypt;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MergeTools
{
    public partial class ConnectForm : Form
    {
        private string _key = "14198561";
        private string _iv = "79495349";
        private static string _cryptoKeya = "1dce0c8cb9c54cbdaf21976405dc8903";
        public static String ALGORITHM_D = "DES";
        public static String ALGORITHM_A = "AES";
        public ConnectForm()
        {
            InitializeComponent();
            rBtn_newGDS.Checked = true;
        }

        //解密
        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string value = richTxt_Enc.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Text Box is empty.");
                return;
            }
            EncryptMethod dec = MethodByType();
            richTxt_Dec.Text = dec.Decrypt(value);
            
        }

        //加密
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string value = richTxt_Dec.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Text Box is empty.");
                return;
            }
            EncryptMethod dec = MethodByType();
            richTxt_Enc.Text = dec.Encrypt(value);
        }

        private EncryptMethod MethodByType() {
            if (rBtn_TKT.Checked)
            {
                return new DESEncrypt();
            }
            else if (rBtn_newGDS.Checked)
            {
                return new AESEncrypt();
            }
            else if (rBtn_SERP.Checked)
            {
                return new DESEncryptSERP();
            }
            throw new Exception("Method undefined!");
        }

        #region - MD5加密 -
        private void btn_MD5_Click(object sender, EventArgs e)
        {
            //string value = txt_String.Text;
            try
            {
                //txt_Output.Text = EncryptHelperMD5_2(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail:" + ex.ToString());
            }
            //EncryptHelperMD5(value);
        }

        private static string EncryptHelperMD5(string origin)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.Unicode.GetBytes(origin);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }

        private static string EncryptHelperMD5_2(string origin)
        {
            StringBuilder sb = new StringBuilder();

            //sb.append(agentCode).append("").append("SHA").append("PEK");
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] t = md5.ComputeHash(Encoding.UTF8.GetBytes(origin));
            for (int i = 0; i < t.Length; i++)
            {
                sb.Append(t[i].ToString("x").PadLeft(2, '0'));
            }

            return sb.ToString();
        }
        #endregion

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(menu_panel, this);
            menu.drawButton();
        }

        private void rBtn_TKT_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rBtn_newGDS_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

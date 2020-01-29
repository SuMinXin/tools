using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MergeTools.Encrypt
{

    public class DESEncrypt : EncryptMethod
    {
        private string _key = "14198561";
        private string _iv = "79495349";

        override
        public string Encrypt(string value) {
            string result = "";
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Text Box is empty.");
                    return result;
                }
                StringBuilder stringBuilder = new StringBuilder();
                using (DESCryptoServiceProvider desCryptoService = new DESCryptoServiceProvider())
                {

                    byte[] inputByteArray;
                    inputByteArray = Encoding.Default.GetBytes(value);
                    desCryptoService.Key = ASCIIEncoding.ASCII.GetBytes(_key);
                    desCryptoService.IV = ASCIIEncoding.ASCII.GetBytes(_iv);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, desCryptoService.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        foreach (byte b in memoryStream.ToArray())
                        {
                            stringBuilder.AppendFormat("{0:X2}", b);
                        }
                    }
                }
                result = stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail:" + ex.ToString());
            }
            return result;
        }
        override
        public string Decrypt(string value) {
            string result = "";
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Text Box is empty.");
                    return result;
                }
                using (DESCryptoServiceProvider desCryptoService = new DESCryptoServiceProvider())
                {
                    byte[] inputByteArray = new byte[value.Length / 2];
                    desCryptoService.Key = ASCIIEncoding.ASCII.GetBytes(_key);
                    desCryptoService.IV = ASCIIEncoding.ASCII.GetBytes(_iv);

                    for (int i = 0; i < value.Length / 2; i++)
                    {
                        inputByteArray[i] = (byte)(Convert.ToInt32(value.Substring(i * 2, 2), 16));
                    }

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, desCryptoService.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                            cryptoStream.FlushFinalBlock();
                            result = Encoding.Default.GetString(memoryStream.ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail:" + ex.ToString());
            }
            return result;
        }
    }

}

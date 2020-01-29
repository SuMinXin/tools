using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MergeTools.Encrypt
{

    public class DESEncryptSERP : EncryptMethod
    {
        private string _key = "7x52cr6P";
        private string _iv = "4kQJaTyT";

        override
        public string Encrypt(string value) {
            string result = "";
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                using (DESCryptoServiceProvider dESCryptoServiceProvider1 = new DESCryptoServiceProvider())
                {
                    byte[] bytes1 = Encoding.Default.GetBytes(value);
                    dESCryptoServiceProvider1.Key = Encoding.ASCII.GetBytes(_key);
                    dESCryptoServiceProvider1.IV = Encoding.ASCII.GetBytes(_iv);
                    using (MemoryStream memoryStream1 = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream1 = new CryptoStream(memoryStream1, dESCryptoServiceProvider1.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream1.Write(bytes1, 0, (int)bytes1.Length);
                            cryptoStream1.FlushFinalBlock();
                            byte[] array = memoryStream1.ToArray();
                            for (int j = 0; j < (int)array.Length; j++)
                            {
                                stringBuilder.Append(array[j].ToString("X2"));
                            }
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
                using (DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider())
                {
                    byte[] num = new byte[value.Length / 2];
                    dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(_key);
                    dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(_iv);
                    for (int i = 0; i < value.Length / 2; i++)
                    {
                        num[i] = (byte)Convert.ToInt32(value.Substring(i * 2, 2), 16);
                    }
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(num, 0, (int)num.Length);
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

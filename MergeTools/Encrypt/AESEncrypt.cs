using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MergeTools.Encrypt
{

    public class AESEncrypt : EncryptMethod
    {
        private static string _cryptoKeya = "1dce0c8cb9c66cbdaf53120589dc8903";
        private static AesManaged getAesCipher()
        {
            AesManaged aesCipher = new AesManaged();
            aesCipher.KeySize = 128;
            aesCipher.BlockSize = 128;
            aesCipher.Mode = CipherMode.CBC;
            aesCipher.Padding = PaddingMode.PKCS7;
            aesCipher.Key = Encoding.UTF8.GetBytes(_cryptoKeya);
            aesCipher.IV = new byte[16];
            return aesCipher;
        }
        override
        public string Encrypt(string value) {
            string result = "";
            try
            {
                AesManaged aesCipher = getAesCipher();
                byte[] valueByte = Encoding.UTF8.GetBytes(value);
                ICryptoTransform encryptTransform = aesCipher.CreateEncryptor();
                byte[] ctext = encryptTransform.TransformFinalBlock(valueByte, 0, valueByte.Length);
                result = Convert.ToBase64String(ctext);
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
                AesManaged aesCipher = getAesCipher();
                ICryptoTransform decryptTransform = aesCipher.CreateDecryptor();
                byte[] ciphertext = Convert.FromBase64String(value);
                byte[] plainText = decryptTransform.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
                result = Encoding.UTF8.GetString(plainText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail:" + ex.ToString());
            }
            return result;
        }
    }

}

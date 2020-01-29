namespace MergeTools.Encrypt
{

    public abstract class EncryptMethod : EncryptFactory
    {
        public abstract string Encrypt(string value);
        public abstract string Decrypt(string value);
    }

}

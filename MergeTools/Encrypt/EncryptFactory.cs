namespace MergeTools.Encrypt
{
    public interface EncryptFactory
    {
        string Encrypt(string value);
        string Decrypt(string value);
    }
}

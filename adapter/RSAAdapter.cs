public class RSAAdapter : ICrypto
{
    private RSA rsa;

    public RSAAdapter(RSA rsa)
    {
        this.rsa = rsa;
    }

    public string decrypt(string encryptedText)
    {
        return rsa.decodeTheText(encryptedText);
    }
    public string encrypt(string text)
    {
        return rsa.encodeTheText(text);
    }
}
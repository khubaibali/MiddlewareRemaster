using Domain.shared.Cryptography;

namespace Infra_Cryptography;

internal class CryptoAes : ICrypto
{
    private string _algorithm;
    private string _key;
    private string _plainText;
    private string _encipherText;
    public void Decrypt(string encryptedText)
    {
        throw new NotImplementedException();
    }

    public string Decryption()
    {
        throw new NotImplementedException();
    }

    public void Encrypt(string plainText)
    {
        throw new NotImplementedException();
    }

    public string Encryption()
    {
        throw new NotImplementedException();
    }
}

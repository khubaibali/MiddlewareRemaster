using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.shared.Cryptography;

public interface ICrypto
{
    public string Encryption();
    public string Decryption();
    public void Encrypt(string plainText);
    public void Decrypt(string encryptedText);
}

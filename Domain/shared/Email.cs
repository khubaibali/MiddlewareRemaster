using Domain.shared.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.shared;

public sealed class Email
{
    public string Value { get; private set; }
    public Email(string e)
    {
        Value = e;
    }

    public void EncryptEmail(ICrypto crypto)
    {
        crypto.Encrypt(Value);
        Value = crypto.Encryption();
    }
    public void DecryptEmail(ICrypto crypto)
    {
        crypto.Decrypt(Value);
        Value = crypto.Decryption();
    }

}

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
    #region Constructors
    private Email() { }
    public Email(string e)
    {
        Value = e;
    }
    #endregion

    #region Public Properties
    public override string ToString()
    {
        return Value;
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
    #endregion
}

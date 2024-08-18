using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class CustomerAdapterParam
{
    public Guid Id { get; private set; }
    public string Value { get; private set; }
    private CustomerAdapterParam() { }
    public CustomerAdapterParam(string value)
    {
        Value = value;
        Id = Guid.NewGuid();
    }
}

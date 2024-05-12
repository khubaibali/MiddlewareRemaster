using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.shared;

public sealed class UniqueIdentifier
{
    public string Value { get; private set; }
    public UniqueIdentifier(string value)
    {
        Value = value.Trim();
    }
}

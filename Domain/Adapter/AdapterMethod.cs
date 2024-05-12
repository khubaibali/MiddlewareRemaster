using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class AdapterMethod
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public AdapterMethod(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}

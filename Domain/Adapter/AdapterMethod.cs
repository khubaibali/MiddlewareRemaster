using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class AdapterMethod
{
    public Adapter Adapter { get; private set; }
    public AdapterMethodId Id { get; private set; }
    public string Name { get; private set; }
    public AdapterMethod(AdapterMethodId id, string name)
    {
        Id = id;
        Name = name;
    }
}
public sealed class AdapterMethodId
{
    public Guid Id { get; private set; }
    public AdapterMethodId()
    {
        Id = Guid.NewGuid();
    }
}
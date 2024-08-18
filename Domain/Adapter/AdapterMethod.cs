using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class AdapterMethod
{
    public AdapterMethodId Id { get; private set; }
    public string Name { get; private set; }
    private AdapterMethod() { }
    public AdapterMethod(AdapterMethodId id, string name)
    {
        Id = id;
        Name = name;
    }
}
public sealed class AdapterMethodId
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public AdapterMethodId(Guid id)
    {
        Id = id;
    }
}
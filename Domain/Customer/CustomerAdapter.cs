using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class CustomerAdapter
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Adapter Adapter { get; private set; }
    public IList<AdapterParam> AdapterParams { get; private set; } = [];
    public IList<AdapterMethod> AdapterMethods { get; private set; } = [];
}

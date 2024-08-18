using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class CustomerAdapter
{
    public Guid Id { get; private set; }
    public string CustomerAdapterName { get; private set; }
    public List<CustomerAdapterParam> CustomerAdapterParams { get; private set; } = [];
    public Adapter Adapter { get; private set; }
    private CustomerAdapter() { }
    public CustomerAdapter(string customerAdapterName,Adapter adapter)
    {
        Id = Guid.NewGuid();
        CustomerAdapterName = customerAdapterName;
        Adapter = adapter;
    }
    public CustomerAdapter(string customerAdapterName, Adapter adapter,List<CustomerAdapterParam> customerAdapterParams) :this(customerAdapterName, adapter) 
    {
        CustomerAdapterParams = customerAdapterParams;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class CustomerId
{
    public Guid Id { get; private set; }

    public CustomerId()
    {
        Id = Guid.NewGuid();
    }

    public CustomerId(Guid id)
    {
        Id = id;
    }
}

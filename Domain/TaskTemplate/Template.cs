using Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TaskTemplate;

public abstract class Template
{
    public Guid Id { get; private set; } 
    public string Name { get; private set; }
    public string Description { get; private set; }

}

using Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TaskTemplate;

public abstract class Template
{
    public TemplateId Id { get; set; } = new TemplateId();
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Gateway> Gateways { get; private set; } = [];

}


public sealed class TemplateId
{
    public Guid Id { get; private set; } = Guid.NewGuid();
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TaskTemplate;

public class Template
{
    public TemplateId Id { get; set; } = new TemplateId();
    public string Name { get; private set; }
    public string Description { get; private set; }
    public TemplateType Type { get; set; }
    public List<TemplateParam> TemplateParams { get; private set; } = [];
    public List<Adapter> adapters { get; private set; }
    private Template(TemplateType type, string name, string description, List<TemplateParam> templateParams) 
    {
        Name = name;
        Description = description;
        TemplateParams = templateParams;
        Type = type;
    }

}


public sealed class TemplateId
{
    public Guid Id { get; private set; } = Guid.NewGuid();
}
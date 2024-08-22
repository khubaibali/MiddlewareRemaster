using Domain.TaskTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class Task
{
    public TaskId Id { get; set; } = new();
    public string Name { get; set; }
    public string Description { get; set; }
    public Template Template { get; set; }

    #region Constructors
    private Task() { }
    public Task(string name, string description, Template template)
    {
        Name = name;
        Description = description;
        Template = template;
    }
    #endregion
}

public sealed class TaskId
{
    public Guid Id { get; private set; } = Guid.NewGuid();

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    #region Constructors
    private Task() { }
    public Task(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
    #endregion
}

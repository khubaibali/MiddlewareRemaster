using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.shared;

public sealed class Mobile
{
    public string Number { get; set; }
    public Mobile(string number) 
    {
        Number = number;
    }
}

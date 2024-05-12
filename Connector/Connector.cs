using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connector;

public abstract class Connector
{
    public abstract IConnector Make();
}

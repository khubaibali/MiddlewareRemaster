using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connector.restfull;

public sealed class RestfullConnector : Connector
{
    public override IConnector Make()
    {
        return new Restfull();
    }
}

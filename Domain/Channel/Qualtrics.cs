using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Gateways;

public sealed class QualtricsGateway : Gateway
{
    public GatewayType Type { get; private set; } = GatewayType.QALT;
    public string ClientId {  get; private set; }
    public string ClientSecret { get; private set; }
    public string XAPIToken { get; private set; }
    public QualtricsGateway()
    {

    }

}

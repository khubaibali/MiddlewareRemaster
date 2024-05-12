using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.Request;

public abstract class Request
{
    public Request ConnectorRequest { get; set; }
    public int RetryCount { get; set; }
    public int Delay { get; set; }
    public int Attempts { get; set; }
    public bool IsSOAP { get; set; }

    protected Request(Request request, int retryCount, int delay, int attemps, bool isSoap)
    {
        ConnectorRequest = request;
        RetryCount = retryCount;
        Delay = delay;
        Attempts = attemps;
        IsSOAP = isSoap;
    }
}

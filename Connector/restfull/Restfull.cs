using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Connector.restfull;

internal sealed class Restfull : IConnector
{
    private readonly IHttpClientFactory clientFactory;
    private HttpMethod httpMethod;
    private HttpClient httpClient;
    public Restfull()
    {
    }
    public void ProcessRequest()
    {
        var client = clientFactory.
            CreateClient("restfulClient");
        throw new NotImplementedException();
    }
}

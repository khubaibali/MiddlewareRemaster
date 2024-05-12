using QualtricsServiceHttpClient.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsServiceHttpClient.Endpoints.Libraries;

public class ListLibraries : Endpoint
{
    public ListLibraries(IServiceProvider serviceProvider):base(serviceProvider)
    {
        this.uri = new StringBuilder("/API/v3/libraries");
    }
    public ListLibraries(IServiceProvider serviceProvider, string AccessToken) : this(serviceProvider)
    {
        this._qualtricsService.AddAuthorization(AccessToken);
    }
    public override async Task Request()
    {
        this._response = await _qualtricsService.httpClient.GetAsync(this.uri.ToString());
    }
    public override HttpResponseMessage Response()
    {
        return this._response;
    }
}

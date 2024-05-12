using Microsoft.Extensions.DependencyInjection;
using QualtricsServiceHttpClient.Shared;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
namespace QualtricsServiceHttpClient.Endpoints.Token;
public sealed class AccessToken : Endpoint
{
    private  IEnumerable<KeyValuePair<string,string>> requestParams;
    private HttpResponseMessage _response;
    #region constructors
    public AccessToken(IServiceProvider serviceProvider): base(serviceProvider)
    {
        uri = new StringBuilder("oauth2/token");
    }
    #endregion
    #region Public Methods
    public override async Task Request()
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        var _content = new StringContent("");
        _content.Headers.ContentType = MediaTypeWithQualityHeaderValue.Parse("application/x-www-form-urlencoded");
        _response = await _qualtricsService.httpClient.PostAsync(uri.ToString(), _content);
        this.AddDefaultHeader();
    }
    public override HttpResponseMessage Response()
    {
        return _response;
    }
    #endregion

    #region Private Methods
    private void AddDefaultHeader()
    {
        var _res = _response.Content.ReadAsStringAsync().Result;
        var _token = NetJSON.NetJSON.Deserialize<Token>(_res);
        _qualtricsService.httpClient.DefaultRequestHeaders.Add(nameof(HttpRequestHeader.Authorization), _token.access_token);
    }
    #endregion
}

using Microsoft.AspNetCore.Mvc;
using QualtricsServiceHttpClient;
using QualtricsServiceHttpClient.Endpoints.Libraries;
using QualtricsServiceHttpClient.Endpoints.Token;
using QualtricsServiceHttpClient.Shared;
using netjson = NetJSON.NetJSON;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Qualtrics : ControllerBase
{
    private readonly QualtricsService serviceProvider;

    public Qualtrics(QualtricsService qualtricsService)
    {
        this.serviceProvider = qualtricsService;
    }
    [HttpPost("AccessToken")]
    public async Task<IActionResult> AccessToken(string clientId, string clientSecret)
    {
        var _params = new RequestParams();
        _params.Add("client_id", clientId);
        _params.Add("client_secret", clientSecret);
        _params.Add("scope", "manage:all");
        _params.Add("grant_type", "client_credentials");
        var resp = new AccessToken(serviceProvider);
        resp.Paramertrize(_params);
        await resp.Request();
        return Ok(netjson.DeserializeObject(await resp.Response().Content.ReadAsStringAsync()));
        
    }
    [HttpGet("ListLibraries")]
    public async Task<IActionResult> ListLibraries(string accessToken){
        var _req = new ListLibraries(serviceProvider,accessToken);
        await _req.Request();
        return Ok(netjson.DeserializeObject(await _req.Response().Content.ReadAsStringAsync()));
    }
    [HttpGet("GetLibraryMessage")]
    public async Task<IActionResult> GetLibraryMessage(string accessToken, string libraryId, string messageId) 
    {
        var _req = new GetLibraryMessage(serviceProvider, accessToken, libraryId, messageId);
        await _req.Request();
        return Ok(netjson.DeserializeObject(await _req.Response().Content.ReadAsStringAsync()));
    }
}


using System.Net;

namespace QualtricsServiceHttpClient;

public class QualtricsService
{
    public readonly HttpClient httpClient;
    public QualtricsService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        httpClient.BaseAddress = new Uri("https://fra1.qualtrics.com/API");
        httpClient.DefaultRequestHeaders.Add(nameof(HttpRequestHeader.Accept), "application/json");
    }
    public void AddAuthorization(string accessToken)
    {
        httpClient.DefaultRequestHeaders.Add(nameof(HttpRequestHeader.Authorization), accessToken.Trim()); 
    }
}

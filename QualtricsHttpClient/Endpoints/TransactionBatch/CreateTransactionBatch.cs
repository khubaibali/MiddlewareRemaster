using QualtricsServiceHttpClient.Endpoints.Token;
using QualtricsServiceHttpClient.Shared;
using System.Text;

namespace QualtricsServiceHttpClient;

public sealed class CreateTransactionBatch : Endpoint
{
    private readonly string _directoryId;
    private HttpResponseMessage _response;
    private CreateTransactionBatch(QualtricsService qualtricsService) : base(qualtricsService)
    {
        this.uri = new StringBuilder("API/v3/directories/{directoryId}/transactionbatches");
    }
    CreateTransactionBatch(QualtricsService qualtricsService, string accessToken, string directoryId) : this(qualtricsService) 
    {
        _directoryId = directoryId;
        _appendUri();
        this._qualtricsService.AddAuthorization(accessToken);
    }

    public override async Task Request()
    {
        _response = await this._qualtricsService.httpClient.PostAsync(this.uri.ToString(),new StringContent(""));
    }

    public override HttpResponseMessage Response()
    {
        return _response;
    }
    private void _appendUri()
    {
        this.uri.Append($"/{this._directoryId}/transactionbatches");
    }
}

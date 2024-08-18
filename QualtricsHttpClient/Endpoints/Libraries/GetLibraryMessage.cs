using QualtricsServiceHttpClient.Endpoints.Token;
using QualtricsServiceHttpClient.Shared;
using System.Text;

namespace QualtricsServiceHttpClient.Endpoints.Libraries;
public sealed class GetLibraryMessage : Endpoint
{   
    private readonly string _libraryId;
    private readonly string _messageId;
    private GetLibraryMessage(QualtricsService serviceProvider) : base(serviceProvider)
    {
        this.uri = new StringBuilder("/API/v3/libraries");
    }
    public GetLibraryMessage(QualtricsService serviceProvider,string accessToken, string libraryId,string messageId) : this(serviceProvider)
    {
        _libraryId = libraryId;
        _messageId = messageId;
        _appendUri();
        this._qualtricsService.AddAuthorization(accessToken);
    }

    public override async Task Request()
    {
        _response = await _qualtricsService.httpClient.GetAsync(this.uri.ToString());
    }

    public override HttpResponseMessage Response()
    {
       return _response;
    }

    #region Private Methods
    private void _appendUri()
    {
        this.uri.Append($"/{this._libraryId}/messages/{this._messageId}");
    }
    #endregion
}

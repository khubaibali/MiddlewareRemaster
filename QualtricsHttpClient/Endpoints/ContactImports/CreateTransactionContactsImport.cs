using QualtricsServiceHttpClient.Shared;
using System.Text;

namespace QualtricsServiceHttpClient.Endpoints;

public sealed class CreateTransactionContactsImport : Endpoint
{
    private readonly string _directoryId;
    private readonly string _mailingListId;
    private CreateTransactionContactsImport(QualtricsService qualtricsService) : base(qualtricsService)
    {
        this.uri = new StringBuilder("/API/v3/directories/{0}/mailinglists/{1}/transactioncontacts");
    }

    public CreateTransactionContactsImport(QualtricsService qualtricsService, string accessToken, string directoryId, string mailingListId) : this(qualtricsService)
    {
        _directoryId = directoryId;
        _mailingListId = mailingListId;
        this.uri = this.uri.AppendFormat(this.uri.ToString(), directoryId, mailingListId);
        this._qualtricsService.AddAuthorization(accessToken);
    }
    public override Task Request()
    {
        throw new NotImplementedException();
    }

    public override HttpResponseMessage Response()
    {
        throw new NotImplementedException();
    }

    
}

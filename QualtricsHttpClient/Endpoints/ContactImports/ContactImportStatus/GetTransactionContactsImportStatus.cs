using QualtricsServiceHttpClient.Shared;
using System.IO;

namespace QualtricsServiceHttpClient.Endpoints;

public class GetTransactionContactsImportStatus : Endpoint
{

    private GetTransactionContactsImportStatus(QualtricsService qualtricsService): base(qualtricsService)
    {
        this.uri = new System.Text.StringBuilder("/directories/{0}/mailinglists/{1}/transactioncontacts/{2}");
    }

    public GetTransactionContactsImportStatus(QualtricsService qualtricsService, string accessToken,string directoryId, string mailingListId,string importId) : this(qualtricsService)
    {
        this.uri = this.uri.AppendFormat(this.uri.ToString(), directoryId, mailingListId, importId);     
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

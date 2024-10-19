using QualtricsServiceHttpClient.Shared;
using System.Text;

namespace QualtricsServiceHttpClient.Endpoints;
public sealed class CreateDistribution : Endpoint
{
    public CreateDistribution(QualtricsService qualtricsService) :base(qualtricsService)
    {
        this.uri = new StringBuilder("/distributions");
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

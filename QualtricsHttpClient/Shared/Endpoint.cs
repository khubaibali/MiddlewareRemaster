using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace QualtricsServiceHttpClient.Shared;
public abstract class Endpoint
{
    protected readonly QualtricsService _qualtricsService;
    protected HttpResponseMessage _response;
    public StringBuilder uri { get; protected set; }
    #region Contructors
    protected Endpoint(IServiceProvider serviceProvider)
    {
        _qualtricsService = serviceProvider.GetRequiredService<QualtricsService>();
    }
    #endregion
    
    #region Public Methods
    public void Paramertrize(IRequestParams requestParams)
    {
        int count = 0;
        foreach (var item in requestParams.Params())
        {
            if(count == 0)
            {
                uri.Append("?");
                uri.Append(item.Key.ToString()+"="+item.Value.ToString());
                count++;
                continue;
            }
            uri.Append("&"+item.Key.ToString() + "=" + item.Value.ToString());
        }
    }
    public abstract Task Request();
    public abstract HttpResponseMessage Response();
    #endregion
}

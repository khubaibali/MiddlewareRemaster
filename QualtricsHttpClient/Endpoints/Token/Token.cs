using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsServiceHttpClient.Endpoints.Token;

public record Token
{
    public string access_token { get; set; }
    public string TokenType { get; set; }
    public int ExpiresIn { get; set; }
    public string Scope { get; set; }
    public DateTime TokenReceiveDateTime { get; set; }
    public string token { get; set; }
}

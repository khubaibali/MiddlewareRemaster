using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsServiceHttpClient.Endpoints.Token;

public record Token
{
    public string access_token { get; set; } = string.Empty;
    public string TokenType { get; set; } = string.Empty;
    public int ExpiresIn { get; set; } = 0;
    public string Scope { get; set; } = string.Empty;
    public DateTime TokenReceiveDateTime { get; set; } = DateTime.Now;
    public string token { get; set; } = string.Empty;
}

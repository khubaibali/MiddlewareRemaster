using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsServiceHttpClient.Shared;

public sealed class RequestParams : IRequestParams
{
    private Dictionary<string, string> _params = new Dictionary<string, string>();
    public void Add(string key, string value)
    {
        if (_params.ContainsKey(key))
        {
            _params[key] = value;
            return;
        }
        _params.Add(key, value);
    }
    public string Params(string key)
    {
        if(_params.ContainsKey(key))
        {
            return _params[key];
        }
        return string.Empty;
    }
    public Dictionary<string, string> Params()
    {
        return _params;
    }
    public void Remove(string key, string value)
    {
        if (_params.ContainsKey(key))
        {
            _params.Remove(key);
        }
        return;
    }
}
public interface IRequestParams
{
    string Params(string key);
    Dictionary<string, string> Params();
    void Add(string key, string value);
    void Remove(string key, string value);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class Adapter
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public IList<AdapterMethod> Methods { get; private set; } = [];
    public IList<AdapterParam> Params { get; private set; } = [];
    #region Contructors
    public Adapter(Guid id, string name, string code)
    {
        Id = id;
        Name = name;
        Code = code;
    }
    public Adapter(Guid id, string name, string code, IList<AdapterMethod> methods):this(id,name,code)
    {
        Methods = methods;
    }
    public Adapter(Guid id, string name, string code, IList<AdapterParam> adapterparams):this(id, name, code)
    {
        Params = adapterparams;
    }
    public Adapter(Guid id, string name, string code, IList<AdapterMethod> methods, IList<AdapterParam> adapterparams) : this(id, name, code)
    {
        Methods = methods;
        Params = adapterparams;
    }
    #endregion
}

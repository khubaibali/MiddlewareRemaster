
namespace Domain;

public sealed class Adapter
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public AdapterType Type { get; private set; }
    public List<AdapterMethod> Methods { get; private set; } = [];
    public List<AdapterParam> Params { get; private set; } = [];
    #region Contructors
    private Adapter() { }
    public Adapter(string name, string code,AdapterType type)
    {
        Name = name;
        Code = code;
        Type = type;
    }
    public Adapter(string name, string code, AdapterType type,IList<AdapterMethod> methods):this(name,code,type)
    {
        Methods = methods.ToList();
    }
    public Adapter(string name, string code, AdapterType type, IList<AdapterParam> adapterparams):this(name, code, type)
    {
        Params = adapterparams.ToList();
    }
    public Adapter(string name, string code, AdapterType type, IList<AdapterMethod> methods, IList<AdapterParam> adapterparams) : this(name, code, type)
    {
        Methods = methods.ToList();
        Params = adapterparams.ToList();
    }
    #endregion
}
//public sealed class AdapterId
//{
//    public Guid Value { get; private set; } = Guid.NewGuid();
//    public AdapterId() { }
//    public AdapterId(Guid value) { this.Value = value; }
    
//}
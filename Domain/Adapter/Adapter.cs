
namespace Domain;

public sealed class Adapter
{
    public AdapterId Id { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public List<AdapterMethod> Methods { get; private set; } = [];
    public List<AdapterParam> Params { get; private set; } = [];
    #region Contructors
    public Adapter(AdapterId id, string name, string code)
    {
        Id = id;
        Name = name;
        Code = code;
    }
    public Adapter(AdapterId id, string name, string code, IList<AdapterMethod> methods):this(id,name,code)
    {
        Methods = methods.ToList();
    }
    public Adapter(AdapterId id, string name, string code, IList<AdapterParam> adapterparams):this(id, name, code)
    {
        Params = adapterparams.ToList();
    }
    public Adapter(AdapterId id, string name, string code, IList<AdapterMethod> methods, IList<AdapterParam> adapterparams) : this(id, name, code)
    {
        Methods = methods.ToList();
        Params = adapterparams.ToList();
    }
    #endregion
}
public sealed class AdapterId
{
    public Guid Id { get; private set; }
    public AdapterId()
    {
        Id = Guid.NewGuid();
    }
}
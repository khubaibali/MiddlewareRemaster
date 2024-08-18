namespace Domain;

public sealed class AdapterMethodParam
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string UIName { get; private set; }
    public string ParamDescription { get; private set; }
    public string DefaultValue { get; private set; }
    public bool IsRequired { get; private set; }

    #region Constructors
    private AdapterMethodParam() { }
    public AdapterMethodParam(string name, string uIName, string paramDescription, string defaultValue, bool isRequired)
    {
    }
    #endregion
}

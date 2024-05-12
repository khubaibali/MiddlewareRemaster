namespace Domain;

public sealed class AdapterParam
{
    public Guid Id { get; private set; }
    public string UiName { get; private set; }
    public string KeyName { get; private set; }
    public bool IsRequired { get; private set; }

}
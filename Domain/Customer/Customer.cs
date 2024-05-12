namespace Domain;

public sealed class Customer
{
    public CustomerId CustomerId { get; private set; }
    public string CustomerName { get; private set;}
    public bool IsOnPremise { get; private set; }
    public bool IsActive { get; private set; }
    public IList<CustomerAdapter> CustomerAdapters { get; private set; } = [];
    public Customer(CustomerId customerId,string customerName,bool isOnPremise,bool isActive)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        IsActive = isActive;
        IsOnPremise = isOnPremise;
    }
    public Customer(CustomerId customerId, string customerName, bool isOnPremise, bool isActive, IList<CustomerAdapter> customerAdapters):this(customerId, customerName, isOnPremise, isActive) 
    {
        CustomerAdapters = customerAdapters;
    }
}

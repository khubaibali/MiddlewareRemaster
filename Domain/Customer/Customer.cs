namespace Domain;

public sealed class Customer
{
    public Guid Id { get; private set; }
    public string CustomerName { get; private set;}
    public string CompanyName { get; private set;}
    public string CompanyGroup { get; private set;}
    public string CompanyPhoneNumber { get; private set;}
    public bool IsOnPremise { get; private set; }
    public bool IsActive { get; private set; }
    public List<Task> Tasks { get; private set; } = [];
    public List<CustomerAdapter> CustomerAdapters { get; private set; } = [];
    public List<Contact> Contacts { get; private set; } = []; 
    private Customer() { }
    public Customer(string customerName,bool isOnPremise,bool isActive)
    {
        CustomerName = customerName;
        IsActive = isActive;
        IsOnPremise = isOnPremise;
    }
    public Customer(string customerName, bool isOnPremise, bool isActive, IList<CustomerAdapter> customerAdapters):this(customerName, isOnPremise, isActive) 
    {
        CustomerAdapters = customerAdapters.ToList();
    }
    public void AddCustomerAdapter(CustomerAdapter customerAdapter) 
    { 
        CustomerAdapters.Add(customerAdapter); 
    }
}

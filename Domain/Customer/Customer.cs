namespace Domain;

public sealed class Customer
{
    public Guid Id { get; private set; }
    public string CustomerName { get; private set;}
    public string CompanyName { get; private set;}
    public string CompanyGroup { get; private set;}
    public string CompanyPhoneNumber { get; private set; } = "";
    public bool IsOnPremise { get; private set; }
    public bool IsActive { get; private set; }
    //public List<Task> Tasks { get; private set; } = [];
    public List<CustomerAdapter> CustomerAdapters { get; private set; } = [];
    public List<Contact> Contacts { get; private set; } = []; 
    private Customer() { }
    public Customer(string customerName,string companyName,string companyGroup,bool isOnPremise,bool isActive)
    {
        CustomerName = customerName;
        CompanyName = companyName;
        CompanyGroup = companyGroup;
        IsActive = isActive;
        IsOnPremise = isOnPremise;
    }
    public Customer(string customerName, string companyName, string companyGroup, bool isOnPremise, bool isActive, IList<CustomerAdapter> customerAdapters):this(customerName,companyName,companyGroup, isOnPremise, isActive) 
    {
        CustomerAdapters = customerAdapters.ToList();
    }
    public void AddCustomerAdapter(CustomerAdapter customerAdapter) 
    { 
        CustomerAdapters.Add(customerAdapter); 
    }
}

using Domain.Gateways;
using Domain.TaskTemplate;

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
    public ICollection<Gateway> Gateways { get; private set; } = [];
    public ICollection<Contact> Contacts { get; private set; } = []; 
    public ICollection<Template> Templates { get; private set; } = [];
    private Customer() { }
    public Customer(string customerName,string companyName,string companyGroup,bool isOnPremise,bool isActive)
    {
        CustomerName = customerName;
        CompanyName = companyName;
        CompanyGroup = companyGroup;
        IsActive = isActive;
        IsOnPremise = isOnPremise;
    }
    
}

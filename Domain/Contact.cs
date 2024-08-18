using Domain.NMFLoId;
using Domain.shared;
using Domain.shared.Cryptography;
namespace Domain;

public sealed class Contact
{
    public UniqueIdentifier UniqueIdentifier { get; private set; }
    public NmfloId NMFLoId { get; private set; }
    public Customer Customer { get; private set; }
    public bool IsSubscribed { get; private set; }
    public Email Email { get; private set; }
    public Mobile MobileNumber { get; private set; }
    public Language Language { get; private set; }
    public DateTimeOffset SurveySendOn { get; private set; }
    public DateTimeOffset CreatedOn { get; private set; } = DateTime.UtcNow;
    private Contact() { }
    public Contact(
            Customer customer,
            UniqueIdentifier uniqueIdentifier,
            NmfloId id,
            Email email,
            Mobile mobileNumber)
    {
        UniqueIdentifier = uniqueIdentifier;
        Customer = customer;
        NMFLoId = id;
        Email = email;
        MobileNumber = mobileNumber;
    }

}
using Domain.shared.ShortId;
namespace Domain;

public sealed class CustomerId
{
    public Guid Id { get; private set; }

    public CustomerId()
    {
        Id = Guid.NewGuid();
    }

    public CustomerId(Guid id)
    {
        Id = id;
    }

    private void GetCustomerIdFromService(ISquid squidService)
    {
        squidService.SquidId();
    }
}

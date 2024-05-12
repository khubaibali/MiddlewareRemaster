using Domain;
using Domain.shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infra_DataAccess.Configurations;
internal sealed class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder
            .HasKey(c => c.NMFLoId)
            .IsClustered(false);
        builder
            .Property(c => c.NMFLoId)
            .HasConversion(x => x.Id, x => new Domain.NMFLoId.NmfloId(x));
        builder
            .Property(c => c.UniqueIdentifier)
            .HasConversion(x => x.Value,x => new UniqueIdentifier(x));
        
    }
}

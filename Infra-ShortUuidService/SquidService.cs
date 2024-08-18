using Domain.shared.ShortId;
using Sqids;
namespace Infra_ShortUuidService;
public sealed class SquidService : ISquid
{

    public string SquidId()
    {
        var sqids = new SqidsEncoder<int>(new SqidsOptions
        {
            MinLength = 10,
            Alphabet = "mTHivO7hx3RAbr1f586SwjNnK2lgpcUVuG09BCtekZdJ4DYFPaWoMLQEsXIqyz"
        });


        return sqids.Encode(123);
    }
}

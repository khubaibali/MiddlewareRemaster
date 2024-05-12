using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NMFLoId;

public sealed class NmfloId
{
    public Guid Id { get; private set; }

    #region constructors

    public NmfloId()
    {
        Id = Guid.NewGuid();
    }
    public NmfloId(string id)
    {
        Id = Guid.Parse(id);
    }
    public NmfloId(Guid id) 
    {
        Id = id;
    }

    #endregion 


}

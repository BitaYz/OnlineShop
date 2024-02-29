using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Frameworks.Absracts
{
    public interface IMainEntity :
        IEntity<Guid> , ICodedEntity<long> , ITitledEntity , IDescribedEntity , IActiveEntity , ICreatedEntity , IModifiedEntity , ISoftDeletedEntity
    {
    }
}

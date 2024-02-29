using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Frameworks.Absracts
{
    public interface ISoftDeletedEntity
    {
        bool IsDeleted { get; set; }
        DateTime DateSoftDeletedLatin { get; set; }
        string DateSoftDeletedPersian { get; set; }
    }
}

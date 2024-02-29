using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Frameworks.Absracts
{
    public interface ICreatedEntity
    {
        DateTime DateCreatedLatin { get; set; }
        string DateCreatedPersian { get; set; }
    }
}

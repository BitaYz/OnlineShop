using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Frameworks.Absracts
{
    public interface ICodedEntity <TCode>
    {
        public TCode Code { get; set; }
    }
}

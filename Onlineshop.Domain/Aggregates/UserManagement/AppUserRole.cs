using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Aggregates.UserManagement
{
    public class AppUserRole : IdentityUserRole<string>, IActiveEntity
    {
        public bool IsActive { get ; set ; }
    }
}

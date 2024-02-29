using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Aggregates.UserManagement
{
    public class AppUser : IdentityUser , IActiveEntity  , ICreatedEntity , IDbSetEntity , IModifiedEntity ,ISoftDeletedEntity
    {
        public  string FirstName  { get; set; }
        public  string LastName  { get; set; }
        public  string CellPhone  { get; set; }
        public bool IsActive { get ; set ; }
        public DateTime DateCreatedLatin { get; set; }
        public string? DateCreatedPersian { get; set; }
        public bool IsModified { get; set; }
        public DateTime DateModifiedLatin { get; set; }
        public string? DateModifiedPersian { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateSoftDeletedLatin { get; set; }
        public string? DateSoftDeletedPersian { get; set; }
    }
}

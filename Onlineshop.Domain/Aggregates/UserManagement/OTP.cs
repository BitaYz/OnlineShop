using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Aggregates.UserManagement
{
    internal class OTP : IEntity<Guid>, ICreatedEntity, IDbSetEntity
    {
        public Guid Id { get ; set; }
        public AppUserRole AppUserRole { get; set; }
        public string PinCode { get; set; }
        public string TargetCellPhone { get; set; }
        public TimeOnly ExpirationTime { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public bool IsUsed { get; set; }
        public TimeOnly UsedTime { get; set; }
        public DateOnly UsedDate { get; set; }
        public string HashedExtraData { get; set; }
        public string ExtraData { get; set; }
        public DateTime DateCreatedLatin { get ; set ; }
        public string DateCreatedPersian { get ; set ; }
    }
}

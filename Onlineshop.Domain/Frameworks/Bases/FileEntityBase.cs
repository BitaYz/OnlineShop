using Onlineshop.Domain.Frameworks.Absracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.Domain.Frameworks.Bases
{
    public class FileEntityBase : IFileEntity
    {
        public Guid Id { get ; set ; }
        public string Title { get ; set ; }
        public string EntityDescription { get; set; }
        public long Code { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateSoftDeletedLatin { get; set; }
        public string DateSoftDeletedPersian { get; set; }
    }
}

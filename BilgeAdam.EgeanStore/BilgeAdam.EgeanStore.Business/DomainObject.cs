using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.EgeanStore.Business
{
    public abstract class DomainObject
    {
        public DomainObject()
        {
            IsActive = true;
            IsDeleted = false;
            Created = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public Nullable<DateTime> Modified { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}

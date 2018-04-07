using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EgeanStore.Business.Entities
{
    [Table("Stores")]
    public class Store : DomainObject
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(14)]
        public string Phone { get; set; }
        [Required]
        public int ManagerId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EgeanStore.Business.Entities
{
    [Table("Brands")]
    public class Brand : DomainObject
    {
        [Required]
        public string Name { get; set; }
    }
}

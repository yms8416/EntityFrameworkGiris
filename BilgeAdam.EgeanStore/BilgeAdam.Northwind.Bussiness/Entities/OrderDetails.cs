using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Northwind.Bussiness.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        [Key, Column("OrderId", Order = 0)]
        public int OrderId { get; set; }
        [Key, Column("ProductId", Order = 1)]
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        [Required]
        public System.Single Discount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}

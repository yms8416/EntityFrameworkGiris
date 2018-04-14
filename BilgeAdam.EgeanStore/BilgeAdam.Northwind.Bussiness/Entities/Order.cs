using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.Bussiness.Entities
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public int EmloyeeId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

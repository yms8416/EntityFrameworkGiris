﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.Bussiness.Entities
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductStoreWebAPI.Models
{
    public class ProductWebAPI
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }

        public  ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public ProductWebAPI Product { get; set; }
        public Order Order { get; set; }
    }
}
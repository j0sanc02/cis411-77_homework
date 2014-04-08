using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStoreWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class OrdersContextInitializer : DropCreateDatabaseIfModelChanges<OrdersWebAPIContext>
    {
        protected override void Seed(OrdersWebAPIContext context)
        {
            var products = new List<ProductWebAPI>()            
            {
                new ProductWebAPI () { Name = "Bread", Price = 1.99M, ActualCost = .89M },
                new ProductWebAPI () { Name = "Hand Towel", Price = 6.99M, ActualCost = 2.99M },
                new ProductWebAPI () { Name = "Toilet Paper", Price = 9.99M, ActualCost = 1.05M }
            };

            products.ForEach(p => context.ProductWebAPIs.Add(p));
            context.SaveChanges();

            var order = new Order() { Customer = "Bob" };
            var od = new List<OrderDetail>()
            {
                new OrderDetail() { Product = products[0], Quantity = 2, Order = order},
                new OrderDetail() { Product = products[1], Quantity = 4, Order = order }
            };
            context.Orders.Add(order);
            od.ForEach(o => context.OrderDetails.Add(o));

            context.SaveChanges();
        }
    }
}
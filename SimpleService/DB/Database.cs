using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleService.Models;

namespace SimpleService.DB
{
    public static class Database
    {
        public static List<Product> Products;
        public static List<Order> Orders;

        private static uint _nextOrder = 0;

        public static uint GetOrderID { get { return ++_nextOrder; } }

        public static void Initialize()
        {
            Products = new List<Product>();
            Orders = new List<Order>();

            Products.Add(new Product { ProductID = 1, ProductName = "Food", ProductPrice = 12.5f });
            Products.Add(new Product { ProductID = 2, ProductName = "Wood", ProductPrice = 1.5f });
            Products.Add(new Product { ProductID = 3, ProductName = "Loot", ProductPrice = 1552f });
        }
    }
}

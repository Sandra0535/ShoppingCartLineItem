using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingCartLineItem.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            Orders = new List<Order>();

            Products = new List<Product>();
        }
        public void AddOrder(int orderId, DateTime orderDate)
        {
            Order order = new Order(orderId, orderDate);
            Orders.Add(order);
        }

        public void AddLineItem(int orderId, int lineItemId, int quantity, Product product)
        {
            Order order = Orders.Find(o => o.Id == orderId);
            if (order != null)
            {
                LineItem lineItem = new LineItem(lineItemId, quantity, product);
                order.AddLineItem(lineItem);
            }
        }
        public void AddProduct(int productId, string productName, double productPrice, double discountPercent)
        {
            Product product = new Product(productId, productName, productPrice, discountPercent);
            Products.Add(product);
        }
    }
}

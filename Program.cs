using ShoppingCartLineItem.Model;
namespace ShoppingCartLineItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Alex");

            customer.AddProduct(11, "Book", 100.0, 10.0);
            customer.AddProduct(12, "Bag", 550.0, 5.0);
            customer.AddProduct(13, "Washing Machine", 19000.0, 25.0);
            customer.AddProduct(14, "Laptop", 48000.0, 30.0);

            // Add orders
            customer.AddOrder(1, DateTime.Now);
            customer.AddOrder(2, DateTime.Now);
            //Add line items
            customer.AddLineItem(1, 1, 1, customer.Products[0]);
            customer.AddLineItem(1, 2, 3, customer.Products[1]);
            customer.AddLineItem(2, 3, 1, customer.Products[2]);
            customer.AddLineItem(2, 4, 2, customer.Products[3]);

            Console.WriteLine($"Customer:\nId:{customer.Id}\tName:{customer.Name}");
            Console.WriteLine();

            // Display details for each order
            foreach (Order order in customer.Orders)
            {
                Console.WriteLine($"Order {order.Id} - Date: {order.Date}");
                foreach (LineItem lineItem in order.Items)
                {
                    Product product = lineItem.GetProduct();
                    Console.WriteLine($"  Line Item ID:{lineItem.Id}");
                    Console.Write($"  Product ID:{product.Id}");
                    Console.Write($"  Product Name:{product.Name}");
                    Console.Write($"  Quantity:{lineItem.Quantity}");
                    Console.Write($"  Price:{product.Price}");
                    Console.Write($"  Discount Percent:{product.DiscountPercent}%");
                    Console.Write($"  Price After Discount:{product.DiscountPrice}");
                    Console.WriteLine($"  Total Line Item Cost:{lineItem.CalculateLineItemCost()}");
                }
                Console.WriteLine($"Total Order Cost:{order.CalculateTotalOrderCost()}");
                Console.WriteLine();
            }
        }
    }
}
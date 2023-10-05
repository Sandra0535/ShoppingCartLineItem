using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLineItem.Model
{
    internal class Order
    {
        private int id;
        private DateTime date;
        private List<LineItem> items;
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            items = new List<LineItem>();
        }
        public void AddLineItem(LineItem lineItem)
        {
            items.Add(lineItem);
        }
        public List<LineItem> Items
        {
            get { return items; }
        }
        public double CalculateTotalOrderCost()
        {
            double totalCost = 0.0;
            foreach (var item in items)
            {
                totalCost += item.CalculateLineItemCost();
            }
            return totalCost;
        }
    }
}

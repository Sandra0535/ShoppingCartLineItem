using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLineItem.Model
{
    internal class LineItem
    {
        private int _id;
        private int _quantity;
        private Product product;
        public int Id { get { return _id; } set { _id = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            this.product = product;
        }
        public Product GetProduct()
        {
            return product;
        }
        public double CalculateLineItemCost()
        {
            return Quantity * product.DiscountPrice;
        }
    }
}

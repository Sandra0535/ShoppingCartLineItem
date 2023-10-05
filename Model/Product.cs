using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartLineItem.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public double DiscountPercent { get { return _discountPercent; } set { _discountPercent = value; } }
        public Product(int id, string name, double price, double discountPercent)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }
        public double DiscountPrice
        {
            get { return Price - (Price * DiscountPercent / 100.0);}
        }
    }
 }

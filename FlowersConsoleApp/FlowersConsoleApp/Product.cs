using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersConsoleApp
{
    public class Product
    {
        private int productId;
        private string title;
        private string description;
        private string category;
        private int quantity;
        private float unitPrice;

        public int ProductId 
        {
            set { this.productId = value; }
            get { return this.productId; }
        }

        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }

        public string Category
        {
            set { this.category = value; }
            get { return this.category; }
        }

        public int Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }

        public float UnitPrice
        {
            set { this.unitPrice = value; }
            get { return this.unitPrice; }
        }

        public Product () { }

        public Product(int productid, string title, string description , string category, int quantity, float unitprice)
        {
            this.productId = productid;
            this.title = title;
            this.description = description;
            this.category = category;
            this.quantity = quantity;
            this.unitPrice = unitprice;
        }

        ~Product () { }

        public override string ToString()
        {
            return this.productId + " " + this.title + " " + this.description + " " + this.category + " " + this.Quantity + " " + this.unitPrice;
        }

        public float GetTotalPrice()
        { 
            return this.quantity * this.unitPrice; 
        }

        public float GetDiscountedPrice()
        {
            return unitPrice * 0.9f; // 10% discount
        }

        public void Display()
        {
            Console.WriteLine("Product Id : " + this.productId);
            Console.WriteLine("title : " + this.title);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Category: " + this.category);
            Console.WriteLine("Quantity: " + this.quantity);
            Console.WriteLine("Price: $" + this.unitPrice);
            Console.WriteLine("--------------------------");
        }
    }
}
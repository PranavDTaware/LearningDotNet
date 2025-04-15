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
        private float price;

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

        public float Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public Product () { }

        public Product(int productid, string title, string description , string category, int quantity, float price)
        {
            this.productId = productid;
            this.title = title;
            this.description = description;
            this.category = category;
            this.quantity = quantity;
            this.price = price;
        }

        ~Product () { }

        public override string ToString()
        {
            return this.productId + " " + this.title + " " + this.description + " " + this.category + " " + this.Quantity + " " + this.price;
        }

        float getTotalPrice()

        public void Display()
        {
            Console.WriteLine("Product Id : " + this.productId);
            Console.WriteLine("title : " + this.title);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Category: " + this.category);
            Console.WriteLine("Quantity: " + this.quantity);
            Console.WriteLine("Price: $" + this.price);
            Console.WriteLine("--------------------------");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Catalog
{

    [Serializable]
    public class Product
    {
        private string title;
        private string description;
        private int quantity;
        private float unitPrice;
        private int id;

        public int Id  //Readonly property(only get block)
        {
            set {this.id = value;}
            get { return this.id; }
        }

        public string Title //T is property and t is private variable(data member)
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Description
        { 
            get { return this.description; }
            set { this.description = value; } 
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public float UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        

        public Product() { }

        public Product(int id, string title,  string description, int quantity, float unitPrice)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        ~Product() 
        {
            //to deintialize object instance before getting destroyed
        }

        public override string ToString()
        {
            // return base.ToString();
            return this.id + " " + this.title + " " + this.description + " " + this.quantity + " " + this.unitPrice;    
        }
    }
}

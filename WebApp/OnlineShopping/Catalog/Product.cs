using System;

namespace Catalog
{
    public class Product
    {


        //ecapsulated variable  are private
       /*
        private int likes;

        // Property
        public int Likes{
            get{ return likes;}   // getter function

            set{ likes=value;}    //setter function

        }
        */
       
        // How  we can write Propery 
        // Auto property get by default private variable
        public int Id{get;set;}
        public string Title {get;set;}
        public string Category{get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}
        public  int Likes{get;set;}

        public Product(){ }

        public Product(int id, string title, string description, double unitPrice, int quantity)
        {
            this.Id=id;
            this.Title=title;
            this.Description=description;
            this.Quantity=quantity;
            this.UnitPrice=unitPrice;
        }

    }
}

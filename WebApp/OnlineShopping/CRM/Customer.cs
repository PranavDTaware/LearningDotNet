using System;
namespace CRM
{
    public class Customer
    { 
        public int Id{get;set;}
        public string Name{get;set;}
        public string ContactNumber{get;set;}
        public string Email{get;set;}
        public string Location{get;set;}
        public int Age{get;set;}
    

        public Customer(){ }

        public Customer(int id, string name, string contactnumber, string email, string location,int Age)
        {
            this.Id=id;
            this.Name=name;
            this.ContactNumber=contactnumber;
            this.Email=email;
            this.Location=Location;
            this.Age=Age;
        }
    }
}

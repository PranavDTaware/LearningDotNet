using System.Collections.Generic;
using System;
using System.Linq;
using Core.Models;
using Core.Repositories.Intefaces;
using Core.Repositories;

namespace Core.Managers
{
    public class PaymentRepository : IPaymentRepository
    {
        public void Delete(int id)
        {
            using(var context = new RepoCollectionContext())
            {
                context.Payments.Remove(context.Payments.Find(id));
                context.SaveChanges();
            }
        }

        public List<Payment> GetPayments()
        {
            using (var context = new RepoCollectionContext())
            {
             var products = from prod in context.Payments select prod;
             return products.ToList<Payment>();
            }
        }

        public Payment GetPaymentById(int id)
        {
            using (var context = new RepoCollectionContext())
            {
             var product = context.Payments.Find(id);
             return product;
            }
        }

        public void Insert(Payment payment)
        {
            using(var context = new RepoCollectionContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();   
            }
        }

        public void Update(Payment payment)
        {
            using(var context = new RepoCollectionContext())
            {
                var thePayment = context.Payments.Find(payment.Id);
                thePayment.Amount =payment.Amount;
                thePayment.PaymentMode=payment.PaymentMode;
                context.SaveChanges();
            }
        }
    }
}
using System.Collections.Generic;
using Core.Models;
namespace Core.Repositories.Intefaces
{
    public interface IPaymentRepository
    {
        List<Payment> GetPayments();
         Payment GetPaymentById(int id);
        void Insert(Payment product);
        void Update(Payment product);
        void Delete(int id);
    }
}

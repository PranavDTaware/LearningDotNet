using Core.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int id);
        // void Insert(Order order);
        // void Update(Order order);
        // void Delete(int id);
    }
}
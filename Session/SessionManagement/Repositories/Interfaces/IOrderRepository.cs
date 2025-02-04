using Core.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int id);
        public void Insert(Order order);
    }
}
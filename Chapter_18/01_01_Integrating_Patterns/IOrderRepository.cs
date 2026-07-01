using System;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public interface IOrderRepository
    {
        Order GetById(Guid orderId);
        void Save(Order order);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class ShipOrderHandler
    {
        private readonly IOrderRepository _repository;

        public ShipOrderHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void Handle(ShipOrderCommand command)
        {
            var order = _repository.GetById(command.OrderId);
            order.Ship();
            _repository.Save(order);
        }
    }
}

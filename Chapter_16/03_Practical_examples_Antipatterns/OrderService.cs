using Chapter_16._02_Common_Antipatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._03_Practical_examples_Antipatterns
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IOrderValidator _validator;

        public OrderService(IOrderRepository repository, IOrderValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public bool Save(Order order)
        {
            if (!_validator.IsValid(order))
                return false;

            _repository.Save(order);
            return true;
        }
    }
}

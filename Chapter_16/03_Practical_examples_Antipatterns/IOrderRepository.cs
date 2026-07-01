using Chapter_16._02_Common_Antipatterns;

namespace Chapter_16._03_Practical_examples_Antipatterns
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
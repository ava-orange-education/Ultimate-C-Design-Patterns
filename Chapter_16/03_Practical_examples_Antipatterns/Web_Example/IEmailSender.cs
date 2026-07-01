using Chapter_16._05_Best_Practices_Anti;

namespace Chapter_16._03_Practical_examples_Antipatterns.Web_Example
{
    public interface IEmailSender
    {
        void SendAlert(Invoice invoice);
        void SendWelcomeEmail(string email);
    }
}
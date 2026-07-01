// Singleton1 Usage
using Classes;
using Classes.EmployeeClasses;
using Classes.PaymentProcessorClasses;
using Classes.StrategyClasses;

Singleton1.Instance.ShowMessage();

// Usage Strategy
Context context = new();
context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();  // Outputs: Executing Strategy A

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();  // Outputs: Executing Strategy B

// PaymentProcessor Usage example
ILogger logger = new ConsoleLogger();
PaymentProcessor processor = new PaymentProcessor(logger);
processor.ProcessPayment();

// Employee Usage example
Employee employee = new Employee("Alice", 50000);
Manager manager = new Manager("Bob", 75000, "IT");

employee.DisplayInfo();
manager.DisplayInfo();



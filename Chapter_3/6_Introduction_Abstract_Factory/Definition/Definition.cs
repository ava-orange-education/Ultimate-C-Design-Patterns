using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.Definition
{
    public class Definition
    {
    }

    // Step 1: Define Abstract Product Interfaces
    public interface IButton
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Check();
    }

    // Step 2: Implement Concrete Products for Windows
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows-style button");
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking Windows-style checkbox");
    }

    // Step 3: Implement Concrete Products for MacOS
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac-style button");
    }

    public class MacCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking Mac-style checkbox");
    }

    // Step 4: Define Abstract Factory Interface
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Step 5: Implement Concrete Factories
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }

    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

    // Step 6: Client Code Uses Abstract Factory
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Check();
        }
    }

}

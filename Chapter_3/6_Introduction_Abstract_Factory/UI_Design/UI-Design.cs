using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.UI_Design
{
    internal class UI_Design
    {
        // Select Theme Factory Based on User Settings
        public static IUIFactory GetThemeFactory(string themePreference)
        {
            switch (themePreference)
            {
                case "Light":
                    return new LightThemeFactory();
                case "Dark":
                    return new DarkThemeFactory();
                default:
                    throw new ArgumentException("Unknown theme");
            }
        }
    }

    // Abstract UI Components
    public interface IButton
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Check();
    }

    // Light Theme Components
    public class LightButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Light-themed Button");
    }

    public class LightCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking Light-themed Checkbox");
    }

    // Dark Theme Components
    public class DarkButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Dark-themed Button");
    }

    public class DarkCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking Dark-themed Checkbox");
    }

    // Abstract UI Factory
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Concrete Factories
    public class LightThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new LightButton();
        public ICheckbox CreateCheckbox() => new LightCheckbox();
    }

    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ICheckbox CreateCheckbox() => new DarkCheckbox();
    }

    // Application Code
    public class UIManager
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public UIManager(IUIFactory factory)
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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chapter_12._04_Examples_GUI
{
    public class SelectableDecorator : ContentControl
    {
        public SelectableDecorator(UIElement content)
        {
            this.Content = content;
            this.BorderBrush = Brushes.Blue;
            this.BorderThickness = new Thickness(2);
        }
    }
}

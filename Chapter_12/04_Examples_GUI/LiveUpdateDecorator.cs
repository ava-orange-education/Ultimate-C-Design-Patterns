using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chapter_12._04_Examples_GUI
{
    public class LiveUpdateDecorator : Grid
    {
        public LiveUpdateDecorator(UIElement content)
        {
            this.Children.Add(content);
            var badge = new TextBlock
            {
                Text = "Live",
                Background = Brushes.Red,
                Foreground = Brushes.White,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 5, 5),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top
            };
            this.Children.Add(badge);
        }
    }
}

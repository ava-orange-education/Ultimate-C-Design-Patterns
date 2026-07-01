using System.Drawing;
using System.Windows.Forms;

namespace Chapter_12._04_Examples_GUI
{
    public class ValidationDecorator
    {
        private Button _button;
        private TextBox _textBox;

        public ValidationDecorator(Button button, TextBox textBox)
        {
            _button = button;
            _textBox = textBox;
            _textBox.TextChanged += (s, e) => UpdateState();
            UpdateState();
        }

        private void UpdateState()
        {
            _button.Enabled = !string.IsNullOrWhiteSpace(_textBox.Text);
        }
    }
}

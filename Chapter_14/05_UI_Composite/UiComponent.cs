using System.Windows.Forms;

namespace Chapter_14._05_UI_Composite
{
    abstract class UiComponent
    {
        public abstract Control Render();
    }

    class UiControl : UiComponent
    {
        private string label;

        public UiControl(string label)
        {
            this.label = label;
        }

        public override Control Render()
        {
            return new Button { Text = label, Width = 100, Height = 30 };
        }
    }
}

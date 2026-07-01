using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter_14._05_UI_Composite
{
    class UiContainer : UiComponent
    {
        private List<UiComponent> children = new List<UiComponent>();

        public void Add(UiComponent component)
        {
            children.Add(component);
        }

        public override Control Render()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel { AutoSize = true };
            foreach (var child in children)
            {
                panel.Controls.Add(child.Render());
            }
            return panel;
        }
    }
}

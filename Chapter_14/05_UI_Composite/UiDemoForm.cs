using System.Windows.Forms;

namespace Chapter_14._05_UI_Composite
{
    class UiDemoForm : Form
    {
        public UiDemoForm()
        {
            UiContainer root = new UiContainer();
            root.Add(new UiControl("Submit"));
            root.Add(new UiControl("Cancel"));

            UiContainer nested = new UiContainer();
            nested.Add(new UiControl("Option A"));
            nested.Add(new UiControl("Option B"));

            root.Add(nested);

            Control ui = root.Render();
            Controls.Add(ui);
        }
    }
}

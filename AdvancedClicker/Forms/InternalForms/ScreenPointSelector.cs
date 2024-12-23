using AdvancedClicker.Data;
using AdvancedClicker.Utilities;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class ScreenPointSelector : Form
    {
        public ClickPoint Result;
        public ScreenPointSelector()
        {
            InitializeComponent();
        }

        private void ScreenPointSelector_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = ((MouseEventArgs)e);
            ClickPoint clickPoint = new ClickPoint();
            clickPoint.DelayAfterClick = 0;
            clickPoint.MouseCoords = new Point(mouseEvent.X, mouseEvent.Y);
            clickPoint.MouseButton = mouseEvent.Button;
            Result = clickPoint;
            this.Close();
        }
    }
}

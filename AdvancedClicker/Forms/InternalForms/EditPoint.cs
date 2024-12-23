using AdvancedClicker.Data;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class EditPoint : Form
    {
        public ClickPoint ClickPoint = new ClickPoint();
        public EditPoint(ClickPoint tempClickPoint)
        {
            InitializeComponent();
            numericTextBox1.Text = tempClickPoint.MouseCoords.X.ToString();
            numericTextBox2.Text = tempClickPoint.MouseCoords.Y.ToString();
            comboBox1.Text = tempClickPoint.MouseButton.ToString();
            numericTextBox3.Text = tempClickPoint.DelayAfterClick.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickPoint.MouseCoords = new Point(numericTextBox1.GetNumber(), numericTextBox2.GetNumber());
            ClickPoint.MouseButton =
                (comboBox1.Text == "Left") ? MouseButtons.Left :
                (comboBox1.Text == "Right") ? MouseButtons.Right :
                (comboBox1.Text == "Middle") ? MouseButtons.Middle : MouseButtons.None;
            ClickPoint.DelayAfterClick = numericTextBox3.GetNumber();
        }
    }
}

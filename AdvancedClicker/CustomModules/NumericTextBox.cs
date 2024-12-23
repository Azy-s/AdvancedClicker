using System.ComponentModel;

namespace AdvancedClicker.CustomModules
{
    [DesignerCategory("Code")]
    [ToolboxBitmap(typeof(NumericTextBox), "NumericTextBox.bmp")]
    internal class NumericTextBox : TextBox
    {
        public NumericTextBox() 
        {
            BackColor = ThemeColors.SecondaryColor1;
            BorderStyle = BorderStyle.FixedSingle;
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            ForeColor = Color.White;
            MaxLength = 4;
            Size = new Size(51, 27);
            Text = "0";
            TextAlign = HorizontalAlignment.Center;
            KeyPress += NumberCheck;
        }

        private void NumberCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public int GetNumber()
        {
            if (Text == "" || Text == null)
                return 0;

            return int.Parse(Text);
        }
    }
}

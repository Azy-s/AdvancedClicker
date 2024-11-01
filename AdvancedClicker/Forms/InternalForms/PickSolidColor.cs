
using AdvancedClicker.Properties;
using System.Windows.Forms;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class PickSolidColor : Form
    {
        private List<Button> _colorButtons = new List<Button>();
        private List<Button> _imageButtons = new List<Button>();
        private List<Button> _delButtons = new List<Button>();
        private int _number = 0;
        public int ColorOffset = 95;
        public List<Color> GetColors()
        {
            List<Color> colors = new List<Color>();
            foreach (Button button in _colorButtons)
            {
                colors.Add(button.BackColor);
            }
            return colors;
        }
        public PickSolidColor()
        {
            InitializeComponent();
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
        }


        private void AddColorButton_Click(object sender, EventArgs e)
        {
            Button colorButton = new Button();
            colorButton.Name = "ButtonColor" + _number;
            colorButton.Size = new Size(80, 40);
            colorButton.Location = new Point(0, 0);
            colorButton.FlatAppearance.BorderColor = Color.Gray;
            colorButton.FlatStyle = FlatStyle.Flat;
            colorButton.Tag = _number;
            colorButton.BackColor = Color.White;
            colorButton.Click += ChooseColorButton_Click;
            colorButton.BackgroundImageLayout = ImageLayout.Zoom;
            colorButton.BackgroundImage = Resources.colorpicker_black_icon;
            _colorButtons.Add(colorButton);
            flowLayoutPanel1.Controls.Add(colorButton);

            Button colorFromImageButton = new Button();
            colorFromImageButton.Name = "ButtonColor" + _number;
            colorFromImageButton.Size = new Size(40, 40);
            colorFromImageButton.Location = new Point(0, 0);
            colorFromImageButton.BackColor = Color.FromArgb(65, 65, 65);
            colorFromImageButton.FlatAppearance.BorderColor = Color.Gray;
            colorFromImageButton.FlatStyle = FlatStyle.Flat;
            colorFromImageButton.Tag = _number;
            colorFromImageButton.Click += ColorFromImageButton_Click;
            colorFromImageButton.BackgroundImageLayout = ImageLayout.Zoom;
            colorFromImageButton.BackgroundImage = Resources.image_icon;
            _imageButtons.Add(colorFromImageButton);
            flowLayoutPanel1.Controls.Add(colorFromImageButton);

            Button delButton = new Button();
            delButton.Name = "ButtonDel" + _number;
            delButton.Size = new Size(40, 40);
            delButton.Location = new Point(0, 0);
            delButton.BackColor = Color.FromArgb(65, 65, 65);
            delButton.BackgroundImage = Resources.close_window_red_icon;
            delButton.BackgroundImageLayout = ImageLayout.Stretch;
            delButton.FlatAppearance.BorderColor = Color.Gray;
            delButton.FlatStyle = FlatStyle.Flat;
            delButton.Tag = _number;
            delButton.Click += DeleteRow;
            _delButtons.Add(delButton);
            flowLayoutPanel1.Controls.Add(delButton);

            _number++;
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Установка начального цвета
                colorDialog.FullOpen = true;
                colorDialog.Color = ((Button)sender).BackColor;
                // Открытие диалога и проверка результата
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((Button)sender).BackColor = colorDialog.Color;
                    if (colorDialog.Color.R + colorDialog.Color.G + colorDialog.Color.B > 350)
                        ((Button)sender).BackgroundImage = Resources.colorpicker_black_icon;
                    else
                        ((Button)sender).BackgroundImage = Resources.colorpicker_white_icon;

                }
            }
        }

        private void ColorFromImageButton_Click(object sender, EventArgs e)
        {
            using (PickColorFromImage pickcolor = new PickColorFromImage())
            {
                if (pickcolor.ShowDialog() == DialogResult.OK)
                {
                    _colorButtons.Find(b => b.Tag != null && (int)b.Tag == (int)((Button)sender).Tag).BackColor = pickcolor.Result;
                }
                pickcolor.Dispose();
            }
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            Button buttonToRemove1 = _colorButtons.FirstOrDefault(b => b.Tag != null && (int)b.Tag == (int)((Button)sender).Tag);
            Button buttonToRemove2 = _delButtons.FirstOrDefault(b => b.Tag != null && (int)b.Tag == (int)((Button)sender).Tag);
            Button buttonToRemove3 = _imageButtons.FirstOrDefault(b => b.Tag != null && (int)b.Tag == (int)((Button)sender).Tag);
            if (buttonToRemove1 != null)
            {
                flowLayoutPanel1.Controls.Remove(buttonToRemove1);
                _colorButtons.Remove(buttonToRemove1);
            }
            if (buttonToRemove2 != null)
            {
                flowLayoutPanel1.Controls.Remove(buttonToRemove2);
                _delButtons.Remove(buttonToRemove2);
            }
            if (buttonToRemove3 != null)
            {
                flowLayoutPanel1.Controls.Remove(buttonToRemove3);
                _imageButtons.Remove(buttonToRemove3);
            }
            buttonToRemove1.Dispose();
            buttonToRemove2.Dispose();
            buttonToRemove3.Dispose();
        }

        private void roundTrackBar1_Scroll(object sender, EventArgs e)
        {
            colorOffsetTextBox.Text = "" + roundTrackBar1.Value.ToString();
        }

        private void colorOffsetTextBox_TextChanged(object sender, EventArgs e)
        {
            ColorOffset = colorOffsetTextBox.GetNumber();
        }
    }
}

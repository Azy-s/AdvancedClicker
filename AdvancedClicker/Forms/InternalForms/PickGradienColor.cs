
using System.Drawing.Drawing2D;


namespace AdvancedClicker.Forms.InternalForms
{
    public partial class PickGradienColor : Form
    {
        private Brush _gradientBrush;

        public int ColorOffset = 95;
        public Color GradientColor1 = Color.Red;
        public Color GradientColor2 = Color.DarkRed;
        
        public PickGradienColor()
        {
            InitializeComponent();
            PaintGradient();
        }

        private void PaintGradient()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            _gradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(pictureBox1.Width, pictureBox1.Height), GradientColor1, GradientColor2);
            g.FillRectangle(_gradientBrush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            pictureBox1.Image = bitmap;
        }

        private void pickGradientButton1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Установка начального цвета
                colorDialog.Color = GradientColor1;
                colorDialog.FullOpen = true;

                // Открытие диалога и проверка результата
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GradientColor1 = colorDialog.Color;
                    PaintGradient();
                }
            }
        }

        private void pickGradientButton2_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Установка начального цвета
                colorDialog.Color = GradientColor2;
                colorDialog.FullOpen = true;

                // Открытие диалога и проверка результата
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GradientColor2 = colorDialog.Color;
                    PaintGradient();
                }
            }
        }

        private void colorFromImageButton1_Click(object sender, EventArgs e)
        {
            using (PickColorFromImage pickcolor = new PickColorFromImage())
            {
                if (pickcolor.ShowDialog() == DialogResult.OK)
                {
                    GradientColor1 = pickcolor.Result;
                    PaintGradient();
                }
            }
        }

        private void colorFromImageButton2_Click(object sender, EventArgs e)
        {
            using (PickColorFromImage pickcolor = new PickColorFromImage())
            {
                if (pickcolor.ShowDialog() == DialogResult.OK)
                {
                    GradientColor2 = pickcolor.Result;
                    PaintGradient();
                }
            }
        }

        private void roundTrackBar1_Scroll(object sender, EventArgs e)
        {
            numericTextBox1.Text = roundTrackBar1.Value.ToString();
        }

        private void numericTextBox1_TextChanged(object sender, EventArgs e)
        {
            ColorOffset = numericTextBox1.GetNumber();
        }
    }
}

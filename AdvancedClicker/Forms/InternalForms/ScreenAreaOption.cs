using AdvancedClicker.CustomModules;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class ScreenAreaOption : Form
    {
        public Bitmap ScreenArea { get; private set; }
        public int ScreenPosX { get; private set; }
        public int ScreenPosY { get; private set; }
        public int ScreenWidth { get; private set; }
        public int ScreenHeight { get; private set; }
        public List<Point> ClickPoints { get; private set; }
        private ColorDetectorPage _mainForm;
        public ScreenAreaOption(ColorDetectorPage form)
        {
            InitializeComponent();
            ScreenArea = new Bitmap(100, 100);
            ScreenPosX = 0;
            ScreenPosY = 0;
            ScreenWidth = ScreenArea.Width;
            ScreenHeight = ScreenArea.Height;
            _mainForm = form;
        }

        private void ChooseAreaButton_Click(object sender, EventArgs e)
        {
            Screen screen = Screen.FromControl(this);
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            Bitmap bitmap = ScreenCapture.CaptureScreenArea(0, 0, screenWidth, screenHeight);
            ScreenAreaSelector screenAreaSelector = new ScreenAreaSelector(bitmap);
            var result = screenAreaSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                Rectangle data = screenAreaSelector.ResultData;
                xPositionTextBox.Text = data.X.ToString();
                yPositionTextBox.Text = data.Y.ToString();
                widthTextBox.Text = data.Width.ToString();
                heightTextBox.Text = data.Height.ToString();
                ScreenPosX = data.X;
                ScreenPosY = data.Y;
                screenWidth = data.Width;
                screenHeight = data.Height;
                _mainForm.ScreenCoords.X = data.X;
                _mainForm.ScreenCoords.Y = data.Y;
                _mainForm.ScreenArea.X = data.Width;
                _mainForm.ScreenArea.Y = data.Height;

                ScreenArea = ScreenCapture.CaptureScreenArea(data.X, data.Y, data.Width, data.Height);

            }
            screenAreaSelector.Dispose();
            bitmap.Dispose();
            screen = null;
        }

        private void ChooseDPIButton_Click(object sender, EventArgs e)
        {
            ScreenDPISelector screenDPI = new ScreenDPISelector(ScreenArea);
            var result = screenDPI.ShowDialog();

            if (result == DialogResult.OK)
            {
                ClickPoints = screenDPI.Points;
                pointsCountLabel.Text = ClickPoints.Count.ToString();
                switch (ClickPoints.Count)
                {
                    case int n when (n > 0 && n <= 100):
                        pointsCountLabel.ForeColor = Color.Lime;
                        break;
                    case int n when (n > 100 && n <= 350):
                        pointsCountLabel.ForeColor = Color.Yellow;
                        break;
                    case int n when (n > 350 && n <= 700):
                        pointsCountLabel.ForeColor = Color.Orange;
                        break;
                    case int n when (n > 700 || n == 0):
                        pointsCountLabel.ForeColor = Color.Red;
                        break;
                }
                _mainForm.PointsToSearch = ClickPoints;
            }

            screenDPI.Dispose();
        }

        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((NumericTextBox)sender).GetNumber() == 0)
                ((NumericTextBox)sender).BackColor = Color.DarkRed;
            else
                ((NumericTextBox)sender).BackColor = ThemeColors.SecondaryColor1;
        }
    }
}

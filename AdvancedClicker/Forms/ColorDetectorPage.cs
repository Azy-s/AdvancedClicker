
using AdvancedClicker.Data;
using AdvancedClicker.Forms.InternalForms;
using AdvancedClicker.Properties;
using System.Diagnostics;
using System.Drawing;
using WindowsInput;

namespace AdvancedClicker.Forms
{
    public partial class ColorDetectorPage : Form
    {
        private Color _gradientColor1 = Color.White;
        private Color _gradientColor2 = Color.LightGray;
        private Brush _gradientBrush;
        private PickGradienColor _pickGradienColor = new PickGradienColor();
        private PickSolidColor _pickSolidColor = new PickSolidColor();
        private ScreenAreaOption _screenAreaOption;
        private MouseCursorOption _mouseCursorOption;
        private Form _activeColorTypeForm;
        private Form _activeScreenAreaForm;
        private bool _isDetecting = false;
        private CancellationTokenSource ctsDetection;
        private const int HOTKEY_START_ID = 1;
        private const int HOTKEY_STOP_ID = 2;

        public List<Point> PointsToSearch = new List<Point>();
        public Point ScreenCoords = new Point(0, 0);
        public Point ScreenArea = new Point(1, 1);
        public float Smoothness = 1;

        public ColorDetectorPage()
        {
            InitializeComponent();
            
            _screenAreaOption = new ScreenAreaOption(this);
            _mouseCursorOption = new MouseCursorOption(this);
            mouseCursorRadioButton.CheckedChanged += radioButton_StateChanged;
            screenAreaRadioButton.CheckedChanged += radioButton_StateChanged;
            OpenColorTypeForm(_pickSolidColor);
            OpenPositionTypeForm(_mouseCursorOption);
            comboBox1.SelectedIndex = 0;
            ctsDetection = new CancellationTokenSource();
            RegisterHotKey();
            PointsToSearch.Add(new Point(0, 0));
            comboBox2.SelectedIndex = 1;
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == HotKeyManager.WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_START_ID)
            {
                startButton.PerformClick();
            }

            if (m.Msg == HotKeyManager.WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_STOP_ID)
            {
                stopButton.PerformClick();
            }


            base.WndProc(ref m);
        }

        private void RegisterHotKey()
        {
            // Регистрация горячей клавиши F6 (ключ 0x75) без модификаторов
            HotKeyManager.RegisterHotKey(this.Handle, HOTKEY_START_ID, 0, (int)Keys.F6);
            HotKeyManager.RegisterHotKey(this.Handle, HOTKEY_STOP_ID, 0, (int)Keys.F7);
        }

        private void UnregisterHotKey()
        {
            // Отмена регистрации горячей клавиши
            HotKeyManager.UnregisterHotKey(this.Handle, HOTKEY_START_ID);
            HotKeyManager.UnregisterHotKey(this.Handle, HOTKEY_STOP_ID);
        }
        private void OpenColorTypeForm(Form childForm)
        {
            if (_activeColorTypeForm != null)
            {
                _activeColorTypeForm.Visible = false;
                _activeColorTypeForm.Enabled = false;
            }

            _activeColorTypeForm = childForm;
            childForm.Enabled = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if (!colorPickPanel.Controls.Contains(childForm))
                colorPickPanel.Controls.Add(childForm);
            colorPickPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenPositionTypeForm(Form childForm)
        {
            if (_activeScreenAreaForm != null)
            {
                _activeScreenAreaForm.Visible = false;
                _activeScreenAreaForm.Enabled = false;
            }

            _activeScreenAreaForm = childForm;
            childForm.Enabled = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if (!panel2.Controls.Contains(childForm))
                panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(60000);
            //await Task.Run(() => TestPixels(cts.Token, this, gradientColor1, gradientColor2), cts.Token);
            _gradientColor1 = _pickGradienColor.GradientColor1;
            _gradientColor2 = _pickGradienColor.GradientColor2;
            //await Task.Run(() => PixelCapture(cts.Token, this, _gradientColor1, _gradientColor2), cts.Token);
        }
        

        private async void button4_Click(object sender, EventArgs e)
        {
            DebugOverlay db = new DebugOverlay();
            db.Show();
            await Task.Delay(0);
        }

        private async void button5_Click_1(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    OpenColorTypeForm(_pickSolidColor);
                    break;
                case 1:
                    OpenColorTypeForm(_pickGradienColor);
                    break;
            }
        }

        private void radioButton_StateChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ((RadioButton)sender).Image = Resources.radiobutton_on_icon;
                ((RadioButton)sender).Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            }
            else
            {
                ((RadioButton)sender).Image = Resources.radiobutton_off_icon;
                ((RadioButton)sender).Font = new Font("Segoe UI", 9.75F);
            }

            switch (((RadioButton)sender).Tag.ToString())
            {
                case "RMouse":
                    OpenPositionTypeForm(_mouseCursorOption);
                    break;
                case "RArea":
                    OpenPositionTypeForm(_screenAreaOption);
                    break;
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (_isDetecting)
                return;


            ctsDetection = new CancellationTokenSource();
            ctsDetection.CancelAfter(60000);
            ColorDetectData cdData = new ColorDetectData();

            cdData.ColorGradient1 = _pickGradienColor.GradientColor1;
            cdData.ColorGradient2 = _pickGradienColor.GradientColor2;
            cdData.SolidColors = _pickSolidColor.GetColors();
            cdData.IsSolidColor = _pickSolidColor.Enabled;
            cdData.IsGradient = _pickGradienColor.Enabled;
            cdData.ColorOffset = _pickGradienColor.Enabled ? _pickGradienColor.ColorOffset : _pickSolidColor.ColorOffset;
            cdData.Points = PointsToSearch;
            cdData.AreaWidth = ScreenArea.X;
            cdData.AreaHeight = ScreenArea.Y;
            cdData.ScreenPosX = ScreenCoords.X;
            cdData.ScreenPosY = ScreenCoords.Y;
            cdData.MouseButton = Data.MouseButton.Left;
            cdData.FolowMouseCursor = mouseCursorRadioButton.Checked;
            cdData.Smoothness = Smoothness;
            cdData.IsAimMode = _mouseCursorOption.IsAimMode();
            cdData.MouseButton = (Data.MouseButton)comboBox2.SelectedIndex;
            cdData.DelayAfterClick = delayAfterCLick.GetNumber();
            cdData.RandomDelayAfterCLick = randomDelayAfterClick.GetNumber();
            cdData.HoldButtonTime = holdButtonTime.GetNumber();
            cdData.RandomHoldButtonTime = randomHoldButtonTime.GetNumber();
            cdData.IsColorInCenter = _mouseCursorOption.IsColorInCenter();

            startButton.Enabled = false;
            stopButton.Enabled = true;
            startButton.BackgroundImage = Resources.play_disabled_icon;
            stopButton.BackgroundImage = Resources.stop_icon;

            _isDetecting = true;
            if (!ctsDetection.IsCancellationRequested)
                await Task.Run(() => ClickingTasks.ColorDetectionTask(ctsDetection.Token, cdData), ctsDetection.Token);
            _isDetecting = false;

            stopButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.BackgroundImage = Resources.stop_disabled_icon;
            startButton.BackgroundImage = Resources.play_icon;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.BackgroundImage = Resources.stop_disabled_icon;
            startButton.BackgroundImage = Resources.play_icon;
            _isDetecting = false;

            if (!ctsDetection.IsCancellationRequested)
                ctsDetection.Cancel();
        }

        private void ColorDetectorPage_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                RegisterHotKey();
            }
            else
            {
                UnregisterHotKey();
                if (!ctsDetection.IsCancellationRequested)
                    ctsDetection.Cancel();
            }
        }
    }
}

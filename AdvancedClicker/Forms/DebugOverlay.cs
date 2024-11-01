
using System.Runtime.InteropServices;

namespace AdvancedClicker.Forms
{
    public partial class DebugOverlay : Form
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        public DebugOverlay()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.TopMost = true;
            cts = new CancellationTokenSource();
            Task.Run(() => DebugTask(cts.Token, this), cts.Token);
        }

        public void UpdateForm(Point mousePos, Color color)
        {
            RValue.Text = "R: " + color.R;
            GValue.Text = "G: " + color.G;
            BValue.Text = "B: " + color.B;
            colorPanel.BackColor = color;

            mouseLocation.Text = "X: " + mousePos.X + "\nY: " + mousePos.Y;
        }

        private static async void DebugTask(CancellationToken cancellationToken, DebugOverlay form)
        {
            Color pixelColor = Color.White;
            Point mousePos = new Point(0, 0);

            while (!cancellationToken.IsCancellationRequested)
            {
                mousePos = MouseControl.GetPosition();
                pixelColor = ScreenCapture.GetPixel(mousePos);
                form.Invoke(new Action(() => form.UpdateForm(mousePos, pixelColor)));
                Task.Delay(50);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DebugOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DebugOverlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }

        private async void closeButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            await Task.Delay(50);
            this.Close();
        }

        public async void SetFps(string fps) 
        {
            label1.Text = fps;
            await Task.Delay(1);
        }
    }
}

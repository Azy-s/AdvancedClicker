using AdvancedClicker.Properties;
using System.Runtime.InteropServices;

namespace AdvancedClicker
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private Forms.ClickerPage ClickerPage = new Forms.ClickerPage();
        private Forms.ColorDetectorPage ColorDetectorPage = new Forms.ColorDetectorPage();
        private Forms.TriggerPage TriggerPage = new Forms.TriggerPage();
        private Forms.SettingsPage SettingsPage;
        public MainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SettingsPage = new Forms.SettingsPage(this);
            ColorDetectorPage.Enabled = false;
            TriggerPage.Enabled = false;
            SettingsPage.Enabled = false;
            OpenChildForm(ClickerPage, clickerPageButton);
            //delayComboBox.SelectedIndex = 0;
            //timeLimitComboBox.SelectedIndex = 1;
            uint color = 0xc0414a;
        }

        public void UpdateLocalization()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OpenChildForm(SettingsPage, settingsPageButton);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Task.Run(() => GetPixelTask(this));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (btnSender == currentButton)
                return;
            if (activeForm != null)
            {
                activeForm.Visible = false;
                activeForm.Enabled = false;
            }

            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.Enabled = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if (!mainPanel.Controls.Contains(childForm))
                mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(currentButton);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ThemeColors.AccentColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton(Button previousBtn)
        {
            if (previousBtn == null)
                return;
            previousBtn.BackColor = ThemeColors.SecondaryColor1;
            previousBtn.ForeColor = Color.White;
            previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumberCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //closeFormButton.BackgroundImage = Resources.close_window_red_icon;
            closeFormButton.BackColor = Color.FromArgb(220, 40, 40);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //closeFormButton.BackgroundImage = Resources.close_window_white_icon;
            closeFormButton.BackColor = ThemeColors.SecondaryColor2;
        }

        private void clickerPageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(ClickerPage, sender);
        }

        private void colorDetectorPageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(ColorDetectorPage, sender);
        }

        private void trigerPageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(TriggerPage, sender);
        }

        private void settingsPageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(SettingsPage, sender);
        }

        private void pinnFormButton_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                pinnFormButton.BackgroundImage = Resources.form_not_pinned_icon;
            }
            else
            {
                this.TopMost = true;
                pinnFormButton.BackgroundImage = Resources.form_pinned_icon;
            }
        }
    }
}

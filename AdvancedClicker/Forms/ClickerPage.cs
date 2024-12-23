using AdvancedClicker.Data;
using AdvancedClicker.Forms.InternalForms;
using AdvancedClicker.Properties;
using System.ComponentModel;
using System.Diagnostics;
using Windows.ApplicationModel.Background;
using WinRT;

namespace AdvancedClicker.Forms
{
    public partial class ClickerPage : Form
    {
        private const int HOTKEY_START_ID = 1;
        private const int HOTKEY_STOP_ID = 2;
        private const int HOTKEY_HOOK_ID = 3;

        private CancellationTokenSource _ctsClicker = new CancellationTokenSource();
        private bool _isClicking = false;

        private int _clickCounter = 0;
        private int _timeToTest = 0;
        private bool _clickTestStarted = false;
        private Stopwatch _stopwatch = new Stopwatch();
        public ClickerPage()
        {
            InitializeComponent();
            mouseButtonComboBox.SelectedIndex = 1;
            timeToTestComboBox.SelectedIndex = 2;
            RegisterHotKey();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                ((CheckBox)sender).Image = Resources.checkbox_on_darkicon;
            else
                ((CheckBox)sender).Image = Resources.checkbox_off_darkicon;
        }

        private void randomDelayCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            randomDelayTextBox.Enabled = randomDelayCheckBox.Checked;
            labelRandomDelay.Enabled = randomDelayCheckBox.Checked;
        }

        private void timeLImitCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            timeLimitHours.Enabled = timeLImitCheckbox.Checked;
            timeLimitMinutes.Enabled = timeLImitCheckbox.Checked;
            timeLimitSeconds.Enabled = timeLImitCheckbox.Checked;
            timeLimitMiliseconds.Enabled = timeLImitCheckbox.Checked;
            labelTimeLimitHours.Enabled = timeLImitCheckbox.Checked;
            labelTimeLimitMinutes.Enabled = timeLImitCheckbox.Checked;
            labelTimeLimitSeconds.Enabled = timeLImitCheckbox.Checked;
            labelTimeLimitMiliseconds.Enabled = timeLImitCheckbox.Checked;
        }

        private void clickLimitCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            clickLimitTextBox.Enabled = clickLimitCheckBox.Checked;
            labelClickLimit.Enabled = clickLimitCheckBox.Checked;
        }

        private void delayedStartCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            delayedStartTextBox.Enabled = !delayedStartTextBox.Enabled;
        }

        private async void customCoordCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            addClickPointButton.Enabled = customCoordCheckBox.Checked;
            deleteClickPointButton.Enabled = customCoordCheckBox.Checked;
            editClickPointButton.Enabled = customCoordCheckBox.Checked;
            listBox1.Enabled = customCoordCheckBox.Checked;

            mouseButtonComboBox.Enabled = !customCoordCheckBox.Checked;
            labelMouseButton.Enabled = !customCoordCheckBox.Checked;

            if (customCoordCheckBox.Checked)
            {
                addClickPointButton.BackgroundImage = Resources.add_icon;
                deleteClickPointButton.BackgroundImage = Resources.close_window_red_icon;
                editClickPointButton.BackgroundImage = Resources.edit_icon_gray;
            }
            else
            {
                addClickPointButton.BackgroundImage = Resources.add_disabled_icon;
                deleteClickPointButton.BackgroundImage = Resources.close_window_disabled_icon;
                editClickPointButton.BackgroundImage = Resources.edit_disabled_icon;
            }
        }

        private void delayMilisecondsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberCheck(sender, e);
            int hours = GetNumberFromTextBox(delayHoursTextBox);
            int minutes = GetNumberFromTextBox(delayMinutesTextBox);
            int seconds = GetNumberFromTextBox(delaySecondsTextBox);
            int miliseconds = GetNumberFromTextBox(delayMilisecondsTextBox);
            int totalMs = miliseconds + seconds * 10 + minutes * 10 + hours * 10; //totally wrong, but for this usage it's works
            if (totalMs < 5)
            {

            }
            else
            {
                //labelWarningMessage.Visible = false;
            }
        }

        private void NumberCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int GetNumberFromTextBox(object sender)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == null)
                return 0;

            return int.Parse(((TextBox)sender).Text);
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            if (_isClicking)
                return;

            _ctsClicker = new CancellationTokenSource();
            Data.ClickData clickData = new Data.ClickData();
            clickData.ClickDelay = (
                GetNumberFromTextBox(delayHoursTextBox) * 1000 * 60 * 60 +
                GetNumberFromTextBox(delayMinutesTextBox) * 1000 * 60 +
                GetNumberFromTextBox(delaySecondsTextBox) * 1000 +
                GetNumberFromTextBox(delayMilisecondsTextBox));

            if (randomDelayCheckBox.Checked)
            {
                clickData.ClickRandomDelay = GetNumberFromTextBox(randomDelayTextBox);
                clickData.IsRandomEnabled = true;
            }

            if (clickLimitCheckBox.Checked)
            {
                clickData.ClickCountLimit = GetNumberFromTextBox(clickLimitTextBox);
                clickData.IsClickLimitEnabled = true;
            }

            if (customCoordCheckBox.Checked)
            {
                //clickData.MouseCoords = new Point(GetNumberFromTextBox(xCordTextbox), GetNumberFromTextBox(yCordTextbox));
                clickData.IsMouseCoordEnabled = true;
            }

            switch (mouseButtonComboBox.SelectedItem)
            {
                case "None":
                    clickData.MouseButton = MouseButtons.None;
                    break;
                case "Left":
                    clickData.MouseButton = MouseButtons.Left;
                    break;
                case "Right":
                    clickData.MouseButton = MouseButtons.Right;
                    break;
                case "Middle":
                    clickData.MouseButton = MouseButtons.Middle;
                    break;
            }


            startButton.Enabled = false;
            stopButton.Enabled = true;
            startButton.BackgroundImage = Resources.play_disabled_icon;
            stopButton.BackgroundImage = Resources.stop_icon;



            if (delayedStartCheckBox.Checked)
            {
                for (int i = 0; i < GetNumberFromTextBox(delayedStartTextBox) * 10; i++)
                {
                    await Task.Delay(100);                  //check for cancelation token every 100ms
                    if (_ctsClicker.IsCancellationRequested) //if click event was canceled -> exit
                        return;
                }
            }

            int cancelationTime = (
                    GetNumberFromTextBox(timeLimitHours) * 1000 * 60 * 60 +
                    GetNumberFromTextBox(timeLimitMinutes) * 1000 * 60 +
                    GetNumberFromTextBox(timeLimitSeconds) * 1000 +
                    GetNumberFromTextBox(timeLimitMiliseconds));

            if (cancelationTime == 0)
            {
                stopButton.PerformClick();
                return;
            }

            if (timeLImitCheckbox.Checked)
            {
                _ctsClicker.CancelAfter(cancelationTime + 5);
            }

            clickData.ClickPoints = new List<ClickPoint>();
            foreach (String item in listBox1.Items)
            {
                ClickPoint point = new ClickPoint();
                string[] tempData = item.Split(';');
                point.MouseCoords = new Point(int.Parse(tempData[0]), int.Parse(tempData[1]));
                point.MouseButton =
                    (tempData[2] == "Left") ? MouseButtons.Left :
                    (tempData[2] == "Right") ? MouseButtons.Right :
                    (tempData[2] == "Middle") ? MouseButtons.Middle : MouseButtons.None;
                point.DelayAfterClick = int.Parse(tempData[3]);
                clickData.ClickPoints.Add(point);
            }

            _isClicking = true;
            if (!_ctsClicker.IsCancellationRequested)
                await Task.Run(() => ClickingTasks.MouseClicker(_ctsClicker.Token, clickData), _ctsClicker.Token);
            _isClicking = false;

            stopButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.BackgroundImage = Resources.stop_disabled_icon;
            startButton.BackgroundImage = Resources.play_icon;
        }

        private async void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.BackgroundImage = Resources.stop_disabled_icon;
            startButton.BackgroundImage = Resources.play_icon;

            _isClicking = false;
            _ctsClicker.Cancel();
            await Task.Delay(1);
        }

        private async void testClickButton_Click(object sender, EventArgs e)
        {
            if (_clickTestStarted)
            {
                //Interlocked.Increment(ref _clickCounter);
                _clickCounter++;
            }
            else
            {
                _clickTestStarted = true;
                _clickCounter = 0;
                _timeToTest = int.Parse(timeToTestComboBox.SelectedItem.ToString());
                _stopwatch = new Stopwatch();
                _stopwatch.Start();
                if (!clickTestBackgroundWorker.IsBusy)
                    clickTestBackgroundWorker.RunWorkerAsync();
            }
            await Task.Delay(1);
        }

        private async void TestClickerCPS(object sender, DoWorkEventArgs e)
        {
            while (!clickTestBackgroundWorker.CancellationPending)
            {
                if (_timeToTest < _stopwatch.Elapsed.TotalSeconds)
                {
                    clickTestBackgroundWorker.ReportProgress(100);
                    break;
                }
                clickTestBackgroundWorker.ReportProgress(0);
                Thread.Sleep(100);
            }
            e.Cancel = true;
        }

        private async void UpdateTime(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() =>
                    {
                        labelClicksCounter.Text = AppStrings.ResourceManager.GetString("ClickCounterLabel") + ": " + _clickCounter;
                        cpsLabel.Text = "cps: " + Math.Round(_clickCounter / (_stopwatch.ElapsedMilliseconds / 1000.0), 1);
                        labelTimeSeconds.Text = "" + _stopwatch.ElapsedMilliseconds / 1000.0;
                    }));
                }
                else
                {
                    labelClicksCounter.Text = AppStrings.ResourceManager.GetString("ClickCounterLabel") + ": " + _clickCounter;
                    cpsLabel.Text = "cps: " + Math.Round(_clickCounter / (_stopwatch.ElapsedMilliseconds / 1000.0), 1);
                    labelTimeSeconds.Text = "" + _stopwatch.ElapsedMilliseconds / 1000.0;
                }
            }
            else
            {
                testClickButton.Enabled = false;
                _stopwatch.Stop();
                _clickTestStarted = false;
                if (clickTestBackgroundWorker.IsBusy)
                    clickTestBackgroundWorker.CancelAsync();
            }
            await Task.Delay(1);
        }

        private void UpdateCoordinates(object sender, ProgressChangedEventArgs e)
        {
            //labelMouseCoords.Text = e.UserState.ToString();
        }

        private void ClickerPage_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                RegisterHotKey();
            }
            else
            {
                UnregisterHotKey();
                if (!_ctsClicker.IsCancellationRequested)
                    _ctsClicker.Cancel();
            }
        }

        private bool hooked = false;
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
            HotKeyManager.RegisterHotKey(this.Handle, HOTKEY_HOOK_ID, 0, (int)Keys.F8);
        }

        private void UnregisterHotKey()
        {
            // Отмена регистрации горячей клавиши
            HotKeyManager.UnregisterHotKey(this.Handle, HOTKEY_START_ID);
            HotKeyManager.UnregisterHotKey(this.Handle, HOTKEY_STOP_ID);
            HotKeyManager.UnregisterHotKey(this.Handle, HOTKEY_HOOK_ID);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            UnregisterHotKey(); // Отмена регистрации горячей клавиши при закрытии формы
            if (!_ctsClicker.IsCancellationRequested)
                _ctsClicker.Cancel();
            base.OnFormClosed(e);
        }

        private void resetTestButton_Click(object sender, EventArgs e)
        {
            if (clickTestBackgroundWorker.IsBusy)
                clickTestBackgroundWorker.CancelAsync();
            testClickButton.Enabled = true;
            _clickCounter = 0;
            _clickTestStarted = false;
            _stopwatch.Stop();

            cpsLabel.Text = "cps: 0";
            labelClicksCounter.Text = AppStrings.ResourceManager.GetString("ClickCounterLabel") + ": 0";
        }

        private void addClickPointButton_Click(object sender, EventArgs e)
        {
            using (ScreenPointSelector sps = new ScreenPointSelector())
            {
                sps.ShowDialog();
                listBox1.Items.Add(sps.Result.MouseCoords.X + ";" +
                    sps.Result.MouseCoords.Y + ";" + 
                    sps.Result.MouseButton.ToString() + ";" + 
                    sps.Result.DelayAfterClick);
            }
        }

        private void deleteClickPointButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int lastSelectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (lastSelectedIndex >= listBox1.Items.Count)
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                else
                    listBox1.SelectedIndex = lastSelectedIndex;
            }
        }

        private void editClickPointButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show(AppStrings.ResourceManager.GetString("SelectPoint"));
                return;
            }
            ClickPoint clickPoint = new ClickPoint();
            string[] pointData = listBox1.Items[listBox1.SelectedIndex].ToString().Split(";");
            clickPoint.MouseCoords = new Point(int.Parse(pointData[0]), int.Parse(pointData[1]));
            clickPoint.MouseButton =
                (pointData[2] == "Left") ? MouseButtons.Left :
                (pointData[2] == "Right") ? MouseButtons.Right :
                (pointData[2] == "Middle") ? MouseButtons.Middle : MouseButtons.None;
            clickPoint.DelayAfterClick = int.Parse(pointData[3]);
            using (EditPoint editPoint = new EditPoint(clickPoint))
            {
                editPoint.StartPosition = FormStartPosition.CenterParent;
                editPoint.ShowDialog();
                if (editPoint.DialogResult == DialogResult.OK)
                {
                    listBox1.Items[listBox1.SelectedIndex] = editPoint.ClickPoint.MouseCoords.X + ";" +
                    editPoint.ClickPoint.MouseCoords.Y + ";" + editPoint.ClickPoint.MouseButton.ToString() + ";" + editPoint.ClickPoint.DelayAfterClick;
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            editClickPointButton.PerformClick();
        }

        bool mouseDownOnList = false;
        int itemListIndex = 0;
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownOnList = true;
            itemListIndex = listBox1.SelectedIndex;
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownOnList = false;
            if (listBox1.SelectedIndex != itemListIndex && listBox1.SelectedIndex != -1)
            {
                int lastSelectedIndex = listBox1.SelectedIndex;
                Object tempObj = listBox1.Items[itemListIndex];
                listBox1.Items.Remove(listBox1.Items[itemListIndex]);
                listBox1.Items.Insert(lastSelectedIndex, tempObj);
                listBox1.SelectedIndex = lastSelectedIndex;
            }
        }
    }
}

namespace AdvancedClicker.Forms
{
    partial class ClickerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DelayLabel = new Label();
            delayHoursTextBox = new TextBox();
            delayMinutesTextBox = new TextBox();
            delaySecondsTextBox = new TextBox();
            delayMilisecondsTextBox = new TextBox();
            randomDelayCheckBox = new CheckBox();
            labelHoursDelay = new Label();
            labelMinutesDelay = new Label();
            labelSwcondsDelay = new Label();
            labelMilisecondsDelay = new Label();
            randomDelayTextBox = new TextBox();
            label3 = new Label();
            labelRandomDelay = new Label();
            timeLimitHours = new TextBox();
            timeLimitMinutes = new TextBox();
            timeLimitSeconds = new TextBox();
            timeLimitMiliseconds = new TextBox();
            label17 = new Label();
            labelTimeLimitHours = new Label();
            labelTimeLimitMinutes = new Label();
            labelTimeLimitSeconds = new Label();
            labelTimeLimitMiliseconds = new Label();
            clickLimitTextBox = new TextBox();
            label22 = new Label();
            labelClickLimit = new Label();
            timeLImitCheckbox = new CheckBox();
            clickLimitCheckBox = new CheckBox();
            delayCheckBox = new CheckBox();
            delayHint = new PictureBox();
            toolTip1 = new ToolTip(components);
            randomDelayHint = new PictureBox();
            timeLimitHint = new PictureBox();
            clickLimitHint = new PictureBox();
            delayedStartHint = new PictureBox();
            startButton = new Button();
            stopButton = new Button();
            panel1 = new Panel();
            labelDelayedStart = new Label();
            delayedStartTextBox = new TextBox();
            delayedStartCheckBox = new CheckBox();
            label2 = new Label();
            labelMouseButton = new Label();
            mouseButtonComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            editClickPointButton = new Button();
            deleteClickPointButton = new Button();
            addClickPointButton = new Button();
            listBox1 = new ListBox();
            customCoordCheckBox = new CheckBox();
            label1 = new Label();
            coordHint = new PictureBox();
            testClickButton = new Button();
            labelClicksCounter = new Label();
            cpsLabel = new Label();
            clickTestBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            timeToTestComboBox = new ComboBox();
            labelTimeToTest = new Label();
            resetTestButton = new Button();
            labelTimeSeconds = new Label();
            ((System.ComponentModel.ISupportInitialize)delayHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)randomDelayHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeLimitHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clickLimitHint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)delayedStartHint).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coordHint).BeginInit();
            SuspendLayout();
            // 
            // DelayLabel
            // 
            DelayLabel.AutoSize = true;
            DelayLabel.Font = new Font("Tahoma", 11.25F);
            DelayLabel.ForeColor = Color.White;
            DelayLabel.Location = new Point(84, 21);
            DelayLabel.Name = "DelayLabel";
            DelayLabel.Size = new Size(126, 18);
            DelayLabel.TabIndex = 3;
            DelayLabel.Text = "Задержка кликов";
            // 
            // delayHoursTextBox
            // 
            delayHoursTextBox.BackColor = Color.FromArgb(68, 68, 68);
            delayHoursTextBox.BorderStyle = BorderStyle.FixedSingle;
            delayHoursTextBox.Cursor = Cursors.IBeam;
            delayHoursTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delayHoursTextBox.ForeColor = Color.White;
            delayHoursTextBox.Location = new Point(252, 18);
            delayHoursTextBox.MaxLength = 4;
            delayHoursTextBox.Name = "delayHoursTextBox";
            delayHoursTextBox.Size = new Size(51, 27);
            delayHoursTextBox.TabIndex = 8;
            delayHoursTextBox.Text = "0";
            delayHoursTextBox.TextAlign = HorizontalAlignment.Center;
            delayHoursTextBox.KeyPress += NumberCheck;
            // 
            // delayMinutesTextBox
            // 
            delayMinutesTextBox.BackColor = Color.FromArgb(68, 68, 68);
            delayMinutesTextBox.BorderStyle = BorderStyle.FixedSingle;
            delayMinutesTextBox.Cursor = Cursors.IBeam;
            delayMinutesTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delayMinutesTextBox.ForeColor = Color.White;
            delayMinutesTextBox.Location = new Point(303, 18);
            delayMinutesTextBox.MaxLength = 4;
            delayMinutesTextBox.Name = "delayMinutesTextBox";
            delayMinutesTextBox.Size = new Size(51, 27);
            delayMinutesTextBox.TabIndex = 8;
            delayMinutesTextBox.Text = "0";
            delayMinutesTextBox.TextAlign = HorizontalAlignment.Center;
            delayMinutesTextBox.KeyPress += NumberCheck;
            // 
            // delaySecondsTextBox
            // 
            delaySecondsTextBox.BackColor = Color.FromArgb(68, 68, 68);
            delaySecondsTextBox.BorderStyle = BorderStyle.FixedSingle;
            delaySecondsTextBox.Cursor = Cursors.IBeam;
            delaySecondsTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delaySecondsTextBox.ForeColor = Color.White;
            delaySecondsTextBox.Location = new Point(352, 18);
            delaySecondsTextBox.MaxLength = 4;
            delaySecondsTextBox.Name = "delaySecondsTextBox";
            delaySecondsTextBox.Size = new Size(51, 27);
            delaySecondsTextBox.TabIndex = 8;
            delaySecondsTextBox.Text = "0";
            delaySecondsTextBox.TextAlign = HorizontalAlignment.Center;
            delaySecondsTextBox.KeyPress += NumberCheck;
            // 
            // delayMilisecondsTextBox
            // 
            delayMilisecondsTextBox.BackColor = Color.FromArgb(68, 68, 68);
            delayMilisecondsTextBox.BorderStyle = BorderStyle.FixedSingle;
            delayMilisecondsTextBox.Cursor = Cursors.IBeam;
            delayMilisecondsTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delayMilisecondsTextBox.ForeColor = Color.White;
            delayMilisecondsTextBox.Location = new Point(402, 18);
            delayMilisecondsTextBox.MaxLength = 4;
            delayMilisecondsTextBox.Name = "delayMilisecondsTextBox";
            delayMilisecondsTextBox.Size = new Size(82, 27);
            delayMilisecondsTextBox.TabIndex = 8;
            delayMilisecondsTextBox.Text = "50";
            delayMilisecondsTextBox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(delayMilisecondsTextBox, "Слишком низкие значения\r\nмогут сломать некоторые программы,\r\nв том числе эту.");
            delayMilisecondsTextBox.KeyPress += delayMilisecondsTextBox_KeyPress;
            // 
            // randomDelayCheckBox
            // 
            randomDelayCheckBox.Appearance = Appearance.Button;
            randomDelayCheckBox.AutoSize = true;
            randomDelayCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            randomDelayCheckBox.FlatAppearance.BorderSize = 0;
            randomDelayCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            randomDelayCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            randomDelayCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            randomDelayCheckBox.FlatStyle = FlatStyle.Flat;
            randomDelayCheckBox.ForeColor = Color.White;
            randomDelayCheckBox.Image = Properties.Resources.checkbox_off_darkicon;
            randomDelayCheckBox.Location = new Point(28, 69);
            randomDelayCheckBox.Name = "randomDelayCheckBox";
            randomDelayCheckBox.Size = new Size(50, 28);
            randomDelayCheckBox.TabIndex = 9;
            randomDelayCheckBox.UseVisualStyleBackColor = true;
            randomDelayCheckBox.CheckedChanged += checkBox_CheckedChanged;
            randomDelayCheckBox.CheckStateChanged += randomDelayCheckBox_CheckStateChanged;
            // 
            // labelHoursDelay
            // 
            labelHoursDelay.AutoSize = true;
            labelHoursDelay.Font = new Font("Tahoma", 9F);
            labelHoursDelay.ForeColor = Color.White;
            labelHoursDelay.Location = new Point(252, 48);
            labelHoursDelay.Name = "labelHoursDelay";
            labelHoursDelay.Size = new Size(26, 14);
            labelHoursDelay.TabIndex = 10;
            labelHoursDelay.Text = "час";
            // 
            // labelMinutesDelay
            // 
            labelMinutesDelay.AutoSize = true;
            labelMinutesDelay.Font = new Font("Tahoma", 9F);
            labelMinutesDelay.ForeColor = Color.White;
            labelMinutesDelay.Location = new Point(303, 48);
            labelMinutesDelay.Name = "labelMinutesDelay";
            labelMinutesDelay.Size = new Size(29, 14);
            labelMinutesDelay.TabIndex = 10;
            labelMinutesDelay.Text = "мин";
            // 
            // labelSwcondsDelay
            // 
            labelSwcondsDelay.AutoSize = true;
            labelSwcondsDelay.Font = new Font("Tahoma", 9F);
            labelSwcondsDelay.ForeColor = Color.White;
            labelSwcondsDelay.Location = new Point(352, 48);
            labelSwcondsDelay.Name = "labelSwcondsDelay";
            labelSwcondsDelay.Size = new Size(26, 14);
            labelSwcondsDelay.TabIndex = 10;
            labelSwcondsDelay.Text = "сек";
            // 
            // labelMilisecondsDelay
            // 
            labelMilisecondsDelay.AutoSize = true;
            labelMilisecondsDelay.Font = new Font("Tahoma", 9F);
            labelMilisecondsDelay.ForeColor = Color.White;
            labelMilisecondsDelay.Location = new Point(402, 48);
            labelMilisecondsDelay.Name = "labelMilisecondsDelay";
            labelMilisecondsDelay.Size = new Size(83, 14);
            labelMilisecondsDelay.TabIndex = 10;
            labelMilisecondsDelay.Text = "милисекунды";
            // 
            // randomDelayTextBox
            // 
            randomDelayTextBox.BackColor = Color.FromArgb(68, 68, 68);
            randomDelayTextBox.BorderStyle = BorderStyle.FixedSingle;
            randomDelayTextBox.Cursor = Cursors.IBeam;
            randomDelayTextBox.Enabled = false;
            randomDelayTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            randomDelayTextBox.ForeColor = Color.White;
            randomDelayTextBox.Location = new Point(252, 70);
            randomDelayTextBox.MaxLength = 4;
            randomDelayTextBox.Name = "randomDelayTextBox";
            randomDelayTextBox.Size = new Size(102, 27);
            randomDelayTextBox.TabIndex = 8;
            randomDelayTextBox.Text = "5";
            randomDelayTextBox.TextAlign = HorizontalAlignment.Center;
            randomDelayTextBox.KeyPress += NumberCheck;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 73);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 3;
            label3.Text = "Случайная задержка";
            // 
            // labelRandomDelay
            // 
            labelRandomDelay.AutoSize = true;
            labelRandomDelay.Enabled = false;
            labelRandomDelay.Font = new Font("Tahoma", 9F);
            labelRandomDelay.ForeColor = Color.White;
            labelRandomDelay.Location = new Point(252, 100);
            labelRandomDelay.Name = "labelRandomDelay";
            labelRandomDelay.Size = new Size(84, 14);
            labelRandomDelay.TabIndex = 10;
            labelRandomDelay.Text = "Милисекунды";
            // 
            // timeLimitHours
            // 
            timeLimitHours.BackColor = Color.FromArgb(68, 68, 68);
            timeLimitHours.BorderStyle = BorderStyle.FixedSingle;
            timeLimitHours.Cursor = Cursors.IBeam;
            timeLimitHours.Enabled = false;
            timeLimitHours.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            timeLimitHours.ForeColor = Color.White;
            timeLimitHours.Location = new Point(252, 124);
            timeLimitHours.MaxLength = 4;
            timeLimitHours.Name = "timeLimitHours";
            timeLimitHours.Size = new Size(51, 27);
            timeLimitHours.TabIndex = 8;
            timeLimitHours.Text = "0";
            timeLimitHours.TextAlign = HorizontalAlignment.Center;
            timeLimitHours.KeyPress += NumberCheck;
            // 
            // timeLimitMinutes
            // 
            timeLimitMinutes.BackColor = Color.FromArgb(68, 68, 68);
            timeLimitMinutes.BorderStyle = BorderStyle.FixedSingle;
            timeLimitMinutes.Cursor = Cursors.IBeam;
            timeLimitMinutes.Enabled = false;
            timeLimitMinutes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            timeLimitMinutes.ForeColor = Color.White;
            timeLimitMinutes.Location = new Point(303, 124);
            timeLimitMinutes.MaxLength = 4;
            timeLimitMinutes.Name = "timeLimitMinutes";
            timeLimitMinutes.Size = new Size(51, 27);
            timeLimitMinutes.TabIndex = 8;
            timeLimitMinutes.Text = "0";
            timeLimitMinutes.TextAlign = HorizontalAlignment.Center;
            timeLimitMinutes.KeyPress += NumberCheck;
            // 
            // timeLimitSeconds
            // 
            timeLimitSeconds.BackColor = Color.FromArgb(68, 68, 68);
            timeLimitSeconds.BorderStyle = BorderStyle.FixedSingle;
            timeLimitSeconds.Cursor = Cursors.IBeam;
            timeLimitSeconds.Enabled = false;
            timeLimitSeconds.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            timeLimitSeconds.ForeColor = Color.White;
            timeLimitSeconds.Location = new Point(352, 124);
            timeLimitSeconds.MaxLength = 4;
            timeLimitSeconds.Name = "timeLimitSeconds";
            timeLimitSeconds.Size = new Size(51, 27);
            timeLimitSeconds.TabIndex = 8;
            timeLimitSeconds.Text = "30";
            timeLimitSeconds.TextAlign = HorizontalAlignment.Center;
            timeLimitSeconds.KeyPress += NumberCheck;
            // 
            // timeLimitMiliseconds
            // 
            timeLimitMiliseconds.BackColor = Color.FromArgb(68, 68, 68);
            timeLimitMiliseconds.BorderStyle = BorderStyle.FixedSingle;
            timeLimitMiliseconds.Cursor = Cursors.IBeam;
            timeLimitMiliseconds.Enabled = false;
            timeLimitMiliseconds.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            timeLimitMiliseconds.ForeColor = Color.White;
            timeLimitMiliseconds.Location = new Point(402, 124);
            timeLimitMiliseconds.MaxLength = 4;
            timeLimitMiliseconds.Name = "timeLimitMiliseconds";
            timeLimitMiliseconds.Size = new Size(82, 27);
            timeLimitMiliseconds.TabIndex = 8;
            timeLimitMiliseconds.Text = "0";
            timeLimitMiliseconds.TextAlign = HorizontalAlignment.Center;
            timeLimitMiliseconds.KeyPress += NumberCheck;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 11.25F);
            label17.ForeColor = Color.White;
            label17.Location = new Point(84, 127);
            label17.Name = "label17";
            label17.Size = new Size(107, 18);
            label17.TabIndex = 3;
            label17.Text = "Лимит работы";
            // 
            // labelTimeLimitHours
            // 
            labelTimeLimitHours.AutoSize = true;
            labelTimeLimitHours.Enabled = false;
            labelTimeLimitHours.Font = new Font("Tahoma", 9F);
            labelTimeLimitHours.ForeColor = Color.White;
            labelTimeLimitHours.Location = new Point(252, 154);
            labelTimeLimitHours.Name = "labelTimeLimitHours";
            labelTimeLimitHours.Size = new Size(26, 14);
            labelTimeLimitHours.TabIndex = 10;
            labelTimeLimitHours.Text = "час";
            // 
            // labelTimeLimitMinutes
            // 
            labelTimeLimitMinutes.AutoSize = true;
            labelTimeLimitMinutes.Enabled = false;
            labelTimeLimitMinutes.Font = new Font("Tahoma", 9F);
            labelTimeLimitMinutes.ForeColor = Color.White;
            labelTimeLimitMinutes.Location = new Point(303, 154);
            labelTimeLimitMinutes.Name = "labelTimeLimitMinutes";
            labelTimeLimitMinutes.Size = new Size(29, 14);
            labelTimeLimitMinutes.TabIndex = 10;
            labelTimeLimitMinutes.Text = "мин";
            // 
            // labelTimeLimitSeconds
            // 
            labelTimeLimitSeconds.AutoSize = true;
            labelTimeLimitSeconds.Enabled = false;
            labelTimeLimitSeconds.Font = new Font("Tahoma", 9F);
            labelTimeLimitSeconds.ForeColor = Color.White;
            labelTimeLimitSeconds.Location = new Point(352, 154);
            labelTimeLimitSeconds.Name = "labelTimeLimitSeconds";
            labelTimeLimitSeconds.Size = new Size(26, 14);
            labelTimeLimitSeconds.TabIndex = 10;
            labelTimeLimitSeconds.Text = "сек";
            // 
            // labelTimeLimitMiliseconds
            // 
            labelTimeLimitMiliseconds.AutoSize = true;
            labelTimeLimitMiliseconds.Enabled = false;
            labelTimeLimitMiliseconds.Font = new Font("Tahoma", 9F);
            labelTimeLimitMiliseconds.ForeColor = Color.White;
            labelTimeLimitMiliseconds.Location = new Point(402, 154);
            labelTimeLimitMiliseconds.Name = "labelTimeLimitMiliseconds";
            labelTimeLimitMiliseconds.Size = new Size(83, 14);
            labelTimeLimitMiliseconds.TabIndex = 10;
            labelTimeLimitMiliseconds.Text = "милисекунды";
            // 
            // clickLimitTextBox
            // 
            clickLimitTextBox.BackColor = Color.FromArgb(68, 68, 68);
            clickLimitTextBox.BorderStyle = BorderStyle.FixedSingle;
            clickLimitTextBox.Cursor = Cursors.IBeam;
            clickLimitTextBox.Enabled = false;
            clickLimitTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            clickLimitTextBox.ForeColor = Color.White;
            clickLimitTextBox.Location = new Point(252, 176);
            clickLimitTextBox.MaxLength = 9;
            clickLimitTextBox.Name = "clickLimitTextBox";
            clickLimitTextBox.Size = new Size(102, 27);
            clickLimitTextBox.TabIndex = 8;
            clickLimitTextBox.Text = "100";
            clickLimitTextBox.TextAlign = HorizontalAlignment.Center;
            clickLimitTextBox.KeyPress += NumberCheck;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label22.ForeColor = Color.White;
            label22.Location = new Point(84, 179);
            label22.Name = "label22";
            label22.Size = new Size(103, 18);
            label22.TabIndex = 3;
            label22.Text = "Лимит кликов";
            // 
            // labelClickLimit
            // 
            labelClickLimit.AutoSize = true;
            labelClickLimit.Enabled = false;
            labelClickLimit.Font = new Font("Tahoma", 9F);
            labelClickLimit.ForeColor = Color.White;
            labelClickLimit.Location = new Point(252, 206);
            labelClickLimit.Name = "labelClickLimit";
            labelClickLimit.Size = new Size(41, 14);
            labelClickLimit.TabIndex = 10;
            labelClickLimit.Text = "Клики";
            // 
            // timeLImitCheckbox
            // 
            timeLImitCheckbox.Appearance = Appearance.Button;
            timeLImitCheckbox.AutoSize = true;
            timeLImitCheckbox.BackgroundImageLayout = ImageLayout.Stretch;
            timeLImitCheckbox.FlatAppearance.BorderSize = 0;
            timeLImitCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            timeLImitCheckbox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            timeLImitCheckbox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            timeLImitCheckbox.FlatStyle = FlatStyle.Flat;
            timeLImitCheckbox.ForeColor = Color.White;
            timeLImitCheckbox.Image = Properties.Resources.checkbox_off_darkicon;
            timeLImitCheckbox.Location = new Point(28, 123);
            timeLImitCheckbox.Name = "timeLImitCheckbox";
            timeLImitCheckbox.Size = new Size(50, 28);
            timeLImitCheckbox.TabIndex = 9;
            timeLImitCheckbox.UseVisualStyleBackColor = true;
            timeLImitCheckbox.CheckedChanged += checkBox_CheckedChanged;
            timeLImitCheckbox.CheckStateChanged += timeLImitCheckbox_CheckStateChanged;
            // 
            // clickLimitCheckBox
            // 
            clickLimitCheckBox.Appearance = Appearance.Button;
            clickLimitCheckBox.AutoSize = true;
            clickLimitCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            clickLimitCheckBox.FlatAppearance.BorderSize = 0;
            clickLimitCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            clickLimitCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            clickLimitCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            clickLimitCheckBox.FlatStyle = FlatStyle.Flat;
            clickLimitCheckBox.ForeColor = Color.White;
            clickLimitCheckBox.Image = Properties.Resources.checkbox_off_darkicon;
            clickLimitCheckBox.Location = new Point(28, 175);
            clickLimitCheckBox.Name = "clickLimitCheckBox";
            clickLimitCheckBox.Size = new Size(50, 28);
            clickLimitCheckBox.TabIndex = 9;
            clickLimitCheckBox.UseVisualStyleBackColor = true;
            clickLimitCheckBox.CheckedChanged += checkBox_CheckedChanged;
            clickLimitCheckBox.CheckStateChanged += clickLimitCheckBox_CheckStateChanged;
            // 
            // delayCheckBox
            // 
            delayCheckBox.Appearance = Appearance.Button;
            delayCheckBox.AutoSize = true;
            delayCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            delayCheckBox.Checked = true;
            delayCheckBox.CheckState = CheckState.Checked;
            delayCheckBox.Enabled = false;
            delayCheckBox.FlatAppearance.BorderSize = 0;
            delayCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            delayCheckBox.FlatStyle = FlatStyle.Flat;
            delayCheckBox.ForeColor = Color.White;
            delayCheckBox.Image = Properties.Resources.checkbox_on_darkicon;
            delayCheckBox.Location = new Point(28, 17);
            delayCheckBox.Name = "delayCheckBox";
            delayCheckBox.Size = new Size(50, 28);
            delayCheckBox.TabIndex = 9;
            delayCheckBox.UseVisualStyleBackColor = true;
            delayCheckBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // delayHint
            // 
            delayHint.BackgroundImage = Properties.Resources.hint_icon;
            delayHint.BackgroundImageLayout = ImageLayout.Stretch;
            delayHint.Cursor = Cursors.Help;
            delayHint.Location = new Point(6, 22);
            delayHint.Name = "delayHint";
            delayHint.Size = new Size(20, 20);
            delayHint.TabIndex = 11;
            delayHint.TabStop = false;
            toolTip1.SetToolTip(delayHint, "Задежка между кликами\r\nВАЖНО! Не реомендуется ставить задержку\r\nменьше 5 мс, некоторые приложения\r\nне могут обработать такое количество кликов");
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 6000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            // 
            // randomDelayHint
            // 
            randomDelayHint.BackgroundImage = Properties.Resources.hint_icon;
            randomDelayHint.BackgroundImageLayout = ImageLayout.Stretch;
            randomDelayHint.Cursor = Cursors.Help;
            randomDelayHint.Location = new Point(6, 74);
            randomDelayHint.Name = "randomDelayHint";
            randomDelayHint.Size = new Size(20, 20);
            randomDelayHint.TabIndex = 11;
            randomDelayHint.TabStop = false;
            toolTip1.SetToolTip(randomDelayHint, "Случайная задержка\r\nмежду кликами.\r\nЗначения (0-999) мс");
            // 
            // timeLimitHint
            // 
            timeLimitHint.BackgroundImage = Properties.Resources.hint_icon;
            timeLimitHint.BackgroundImageLayout = ImageLayout.Stretch;
            timeLimitHint.Cursor = Cursors.Help;
            timeLimitHint.Location = new Point(6, 128);
            timeLimitHint.Name = "timeLimitHint";
            timeLimitHint.Size = new Size(20, 20);
            timeLimitHint.TabIndex = 11;
            timeLimitHint.TabStop = false;
            toolTip1.SetToolTip(timeLimitHint, "Время через которое\r\nкликер сам отключится.");
            // 
            // clickLimitHint
            // 
            clickLimitHint.BackgroundImage = Properties.Resources.hint_icon;
            clickLimitHint.BackgroundImageLayout = ImageLayout.Stretch;
            clickLimitHint.Cursor = Cursors.Help;
            clickLimitHint.Location = new Point(6, 180);
            clickLimitHint.Name = "clickLimitHint";
            clickLimitHint.Size = new Size(20, 20);
            clickLimitHint.TabIndex = 11;
            clickLimitHint.TabStop = false;
            toolTip1.SetToolTip(clickLimitHint, "Ограничение по \r\nколичеству кликов");
            // 
            // delayedStartHint
            // 
            delayedStartHint.BackgroundImage = Properties.Resources.hint_icon;
            delayedStartHint.BackgroundImageLayout = ImageLayout.Stretch;
            delayedStartHint.Cursor = Cursors.Help;
            delayedStartHint.Location = new Point(330, 30);
            delayedStartHint.Name = "delayedStartHint";
            delayedStartHint.Size = new Size(20, 20);
            delayedStartHint.TabIndex = 11;
            delayedStartHint.TabStop = false;
            toolTip1.SetToolTip(delayedStartHint, "Начинает работу только\r\nчерез указанное время.");
            // 
            // startButton
            // 
            startButton.BackgroundImage = Properties.Resources.play_icon;
            startButton.BackgroundImageLayout = ImageLayout.Zoom;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(12, 13);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(1, 3, 8, 1);
            startButton.Size = new Size(51, 50);
            startButton.TabIndex = 12;
            startButton.Text = "F6";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += playButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackgroundImage = Properties.Resources.stop_disabled_icon;
            stopButton.BackgroundImageLayout = ImageLayout.Stretch;
            stopButton.Enabled = false;
            stopButton.FlatAppearance.BorderSize = 0;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.ForeColor = Color.White;
            stopButton.Location = new Point(69, 13);
            stopButton.Name = "stopButton";
            stopButton.Padding = new Padding(1, 2, 1, 1);
            stopButton.Size = new Size(51, 50);
            stopButton.TabIndex = 12;
            stopButton.Text = "F7";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(delayedStartHint);
            panel1.Controls.Add(stopButton);
            panel1.Controls.Add(labelDelayedStart);
            panel1.Controls.Add(delayedStartTextBox);
            panel1.Controls.Add(delayedStartCheckBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 80);
            panel1.TabIndex = 13;
            // 
            // labelDelayedStart
            // 
            labelDelayedStart.AutoSize = true;
            labelDelayedStart.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDelayedStart.ForeColor = Color.White;
            labelDelayedStart.Location = new Point(408, 29);
            labelDelayedStart.Name = "labelDelayedStart";
            labelDelayedStart.Size = new Size(141, 18);
            labelDelayedStart.TabIndex = 3;
            labelDelayedStart.Text = "Отложенный старт";
            // 
            // delayedStartTextBox
            // 
            delayedStartTextBox.BackColor = Color.FromArgb(68, 68, 68);
            delayedStartTextBox.BorderStyle = BorderStyle.FixedSingle;
            delayedStartTextBox.Cursor = Cursors.IBeam;
            delayedStartTextBox.Enabled = false;
            delayedStartTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delayedStartTextBox.ForeColor = Color.White;
            delayedStartTextBox.Location = new Point(576, 26);
            delayedStartTextBox.MaxLength = 7;
            delayedStartTextBox.Name = "delayedStartTextBox";
            delayedStartTextBox.Size = new Size(51, 27);
            delayedStartTextBox.TabIndex = 8;
            delayedStartTextBox.Text = "2";
            delayedStartTextBox.TextAlign = HorizontalAlignment.Center;
            delayedStartTextBox.KeyPress += NumberCheck;
            // 
            // delayedStartCheckBox
            // 
            delayedStartCheckBox.Appearance = Appearance.Button;
            delayedStartCheckBox.AutoSize = true;
            delayedStartCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            delayedStartCheckBox.FlatAppearance.BorderSize = 0;
            delayedStartCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(55, 55, 55);
            delayedStartCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 55, 55);
            delayedStartCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            delayedStartCheckBox.FlatStyle = FlatStyle.Flat;
            delayedStartCheckBox.ForeColor = Color.White;
            delayedStartCheckBox.Image = Properties.Resources.checkbox_off_darkicon;
            delayedStartCheckBox.Location = new Point(352, 25);
            delayedStartCheckBox.Name = "delayedStartCheckBox";
            delayedStartCheckBox.Size = new Size(50, 28);
            delayedStartCheckBox.TabIndex = 9;
            delayedStartCheckBox.UseVisualStyleBackColor = true;
            delayedStartCheckBox.CheckedChanged += checkBox_CheckedChanged;
            delayedStartCheckBox.CheckStateChanged += delayedStartCheckBox_CheckStateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(633, 33);
            label2.Name = "label2";
            label2.Size = new Size(27, 14);
            label2.TabIndex = 10;
            label2.Text = "Сек";
            // 
            // labelMouseButton
            // 
            labelMouseButton.AutoSize = true;
            labelMouseButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMouseButton.ForeColor = Color.White;
            labelMouseButton.Location = new Point(6, 66);
            labelMouseButton.Name = "labelMouseButton";
            labelMouseButton.Size = new Size(101, 18);
            labelMouseButton.TabIndex = 3;
            labelMouseButton.Text = "Кнопка мыши";
            // 
            // mouseButtonComboBox
            // 
            mouseButtonComboBox.BackColor = Color.FromArgb(64, 64, 64);
            mouseButtonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mouseButtonComboBox.FlatStyle = FlatStyle.Flat;
            mouseButtonComboBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mouseButtonComboBox.ForeColor = Color.White;
            mouseButtonComboBox.FormattingEnabled = true;
            mouseButtonComboBox.Items.AddRange(new object[] { "None", "Left", "Right", "Middle" });
            mouseButtonComboBox.Location = new Point(115, 62);
            mouseButtonComboBox.Name = "mouseButtonComboBox";
            mouseButtonComboBox.Size = new Size(121, 28);
            mouseButtonComboBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delayHint);
            groupBox1.Controls.Add(delayHoursTextBox);
            groupBox1.Controls.Add(delayMinutesTextBox);
            groupBox1.Controls.Add(clickLimitHint);
            groupBox1.Controls.Add(timeLimitHours);
            groupBox1.Controls.Add(timeLimitHint);
            groupBox1.Controls.Add(randomDelayTextBox);
            groupBox1.Controls.Add(randomDelayHint);
            groupBox1.Controls.Add(timeLimitMinutes);
            groupBox1.Controls.Add(clickLimitTextBox);
            groupBox1.Controls.Add(labelTimeLimitMiliseconds);
            groupBox1.Controls.Add(delaySecondsTextBox);
            groupBox1.Controls.Add(labelMilisecondsDelay);
            groupBox1.Controls.Add(delayMilisecondsTextBox);
            groupBox1.Controls.Add(labelTimeLimitSeconds);
            groupBox1.Controls.Add(timeLimitSeconds);
            groupBox1.Controls.Add(labelSwcondsDelay);
            groupBox1.Controls.Add(timeLimitMiliseconds);
            groupBox1.Controls.Add(labelTimeLimitMinutes);
            groupBox1.Controls.Add(DelayLabel);
            groupBox1.Controls.Add(labelMinutesDelay);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(labelClickLimit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelRandomDelay);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(labelTimeLimitHours);
            groupBox1.Controls.Add(randomDelayCheckBox);
            groupBox1.Controls.Add(labelHoursDelay);
            groupBox1.Controls.Add(delayCheckBox);
            groupBox1.Controls.Add(clickLimitCheckBox);
            groupBox1.Controls.Add(timeLImitCheckbox);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, -7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 230);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(editClickPointButton);
            groupBox2.Controls.Add(deleteClickPointButton);
            groupBox2.Controls.Add(addClickPointButton);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(mouseButtonComboBox);
            groupBox2.Controls.Add(customCoordCheckBox);
            groupBox2.Controls.Add(labelMouseButton);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(coordHint);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(0, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 177);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // editClickPointButton
            // 
            editClickPointButton.BackColor = Color.FromArgb(65, 65, 65);
            editClickPointButton.BackgroundImage = Properties.Resources.edit_disabled_icon;
            editClickPointButton.BackgroundImageLayout = ImageLayout.Zoom;
            editClickPointButton.Enabled = false;
            editClickPointButton.FlatAppearance.BorderColor = Color.DimGray;
            editClickPointButton.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            editClickPointButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            editClickPointButton.FlatStyle = FlatStyle.Flat;
            editClickPointButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editClickPointButton.ForeColor = Color.White;
            editClickPointButton.Location = new Point(300, 92);
            editClickPointButton.Name = "editClickPointButton";
            editClickPointButton.Size = new Size(32, 32);
            editClickPointButton.TabIndex = 18;
            editClickPointButton.UseVisualStyleBackColor = false;
            editClickPointButton.Click += editClickPointButton_Click;
            // 
            // deleteClickPointButton
            // 
            deleteClickPointButton.BackColor = Color.FromArgb(65, 65, 65);
            deleteClickPointButton.BackgroundImage = Properties.Resources.close_window_disabled_icon;
            deleteClickPointButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteClickPointButton.Enabled = false;
            deleteClickPointButton.FlatAppearance.BorderColor = Color.DimGray;
            deleteClickPointButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            deleteClickPointButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            deleteClickPointButton.FlatStyle = FlatStyle.Flat;
            deleteClickPointButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteClickPointButton.ForeColor = Color.White;
            deleteClickPointButton.Location = new Point(300, 53);
            deleteClickPointButton.Name = "deleteClickPointButton";
            deleteClickPointButton.Size = new Size(32, 32);
            deleteClickPointButton.TabIndex = 18;
            deleteClickPointButton.UseVisualStyleBackColor = false;
            deleteClickPointButton.Click += deleteClickPointButton_Click;
            // 
            // addClickPointButton
            // 
            addClickPointButton.BackColor = Color.FromArgb(65, 65, 65);
            addClickPointButton.BackgroundImage = Properties.Resources.add_disabled_icon;
            addClickPointButton.BackgroundImageLayout = ImageLayout.Zoom;
            addClickPointButton.Enabled = false;
            addClickPointButton.FlatAppearance.BorderColor = Color.DimGray;
            addClickPointButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 200, 50);
            addClickPointButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            addClickPointButton.FlatStyle = FlatStyle.Flat;
            addClickPointButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addClickPointButton.ForeColor = Color.White;
            addClickPointButton.Location = new Point(300, 15);
            addClickPointButton.Name = "addClickPointButton";
            addClickPointButton.Size = new Size(32, 32);
            addClickPointButton.TabIndex = 18;
            addClickPointButton.UseVisualStyleBackColor = false;
            addClickPointButton.Click += addClickPointButton_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.BackColor = Color.FromArgb(65, 65, 65);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Enabled = false;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.ForeColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(338, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 155);
            listBox1.TabIndex = 15;
            listBox1.DoubleClick += listBox1_DoubleClick;
            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.MouseUp += listBox1_MouseUp;
            // 
            // customCoordCheckBox
            // 
            customCoordCheckBox.Appearance = Appearance.Button;
            customCoordCheckBox.AutoSize = true;
            customCoordCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            customCoordCheckBox.FlatAppearance.BorderSize = 0;
            customCoordCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            customCoordCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            customCoordCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            customCoordCheckBox.FlatStyle = FlatStyle.Flat;
            customCoordCheckBox.ForeColor = Color.White;
            customCoordCheckBox.Image = Properties.Resources.checkbox_off_darkicon;
            customCoordCheckBox.Location = new Point(28, 22);
            customCoordCheckBox.Name = "customCoordCheckBox";
            customCoordCheckBox.Size = new Size(50, 28);
            customCoordCheckBox.TabIndex = 9;
            customCoordCheckBox.UseVisualStyleBackColor = true;
            customCoordCheckBox.CheckedChanged += checkBox_CheckedChanged;
            customCoordCheckBox.CheckStateChanged += customCoordCheckBox_CheckStateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 26);
            label1.Name = "label1";
            label1.Size = new Size(149, 18);
            label1.TabIndex = 3;
            label1.Text = "Указать координаты";
            // 
            // coordHint
            // 
            coordHint.BackgroundImage = Properties.Resources.hint_icon;
            coordHint.BackgroundImageLayout = ImageLayout.Stretch;
            coordHint.Cursor = Cursors.Help;
            coordHint.Location = new Point(6, 27);
            coordHint.Name = "coordHint";
            coordHint.Size = new Size(20, 20);
            coordHint.TabIndex = 11;
            coordHint.TabStop = false;
            // 
            // testClickButton
            // 
            testClickButton.BackColor = Color.FromArgb(65, 65, 65);
            testClickButton.FlatAppearance.BorderColor = Color.Black;
            testClickButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            testClickButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            testClickButton.FlatStyle = FlatStyle.Flat;
            testClickButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            testClickButton.ForeColor = Color.White;
            testClickButton.Location = new Point(499, 9);
            testClickButton.Name = "testClickButton";
            testClickButton.Size = new Size(193, 193);
            testClickButton.TabIndex = 17;
            testClickButton.Text = "Кликер тест";
            testClickButton.UseVisualStyleBackColor = false;
            testClickButton.Click += testClickButton_Click;
            // 
            // labelClicksCounter
            // 
            labelClicksCounter.AutoSize = true;
            labelClicksCounter.Font = new Font("Tahoma", 9F);
            labelClicksCounter.ForeColor = Color.White;
            labelClicksCounter.Location = new Point(499, 212);
            labelClicksCounter.Name = "labelClicksCounter";
            labelClicksCounter.Size = new Size(49, 14);
            labelClicksCounter.TabIndex = 10;
            labelClicksCounter.Text = "Клики: ";
            // 
            // cpsLabel
            // 
            cpsLabel.AutoSize = true;
            cpsLabel.Font = new Font("Tahoma", 9F);
            cpsLabel.ForeColor = Color.White;
            cpsLabel.Location = new Point(619, 212);
            cpsLabel.Name = "cpsLabel";
            cpsLabel.Size = new Size(29, 14);
            cpsLabel.TabIndex = 10;
            cpsLabel.Text = "cps:";
            // 
            // clickTestBackgroundWorker
            // 
            clickTestBackgroundWorker.WorkerReportsProgress = true;
            clickTestBackgroundWorker.WorkerSupportsCancellation = true;
            clickTestBackgroundWorker.DoWork += TestClickerCPS;
            clickTestBackgroundWorker.ProgressChanged += UpdateTime;
            // 
            // timeToTestComboBox
            // 
            timeToTestComboBox.BackColor = Color.FromArgb(64, 64, 64);
            timeToTestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeToTestComboBox.FlatStyle = FlatStyle.Flat;
            timeToTestComboBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timeToTestComboBox.ForeColor = Color.White;
            timeToTestComboBox.FormattingEnabled = true;
            timeToTestComboBox.Items.AddRange(new object[] { "3", "5", "10", "30", "60" });
            timeToTestComboBox.Location = new Point(619, 268);
            timeToTestComboBox.Name = "timeToTestComboBox";
            timeToTestComboBox.Size = new Size(73, 28);
            timeToTestComboBox.TabIndex = 14;
            // 
            // labelTimeToTest
            // 
            labelTimeToTest.AutoSize = true;
            labelTimeToTest.Font = new Font("Tahoma", 9F);
            labelTimeToTest.ForeColor = Color.White;
            labelTimeToTest.Location = new Point(499, 275);
            labelTimeToTest.Name = "labelTimeToTest";
            labelTimeToTest.Size = new Size(78, 14);
            labelTimeToTest.TabIndex = 10;
            labelTimeToTest.Text = "Время теста";
            // 
            // resetTestButton
            // 
            resetTestButton.BackColor = Color.FromArgb(65, 65, 65);
            resetTestButton.FlatAppearance.BorderColor = Color.Black;
            resetTestButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            resetTestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            resetTestButton.FlatStyle = FlatStyle.Flat;
            resetTestButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resetTestButton.ForeColor = Color.White;
            resetTestButton.Location = new Point(499, 316);
            resetTestButton.Name = "resetTestButton";
            resetTestButton.Size = new Size(193, 76);
            resetTestButton.TabIndex = 17;
            resetTestButton.Text = "Сброс";
            resetTestButton.UseVisualStyleBackColor = false;
            resetTestButton.Click += resetTestButton_Click;
            // 
            // labelTimeSeconds
            // 
            labelTimeSeconds.AutoSize = true;
            labelTimeSeconds.Font = new Font("Tahoma", 9F);
            labelTimeSeconds.ForeColor = Color.White;
            labelTimeSeconds.Location = new Point(500, 289);
            labelTimeSeconds.Name = "labelTimeSeconds";
            labelTimeSeconds.Size = new Size(0, 14);
            labelTimeSeconds.TabIndex = 10;
            // 
            // ClickerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(700, 480);
            Controls.Add(timeToTestComboBox);
            Controls.Add(resetTestButton);
            Controls.Add(testClickButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(cpsLabel);
            Controls.Add(labelTimeToTest);
            Controls.Add(labelTimeSeconds);
            Controls.Add(labelClicksCounter);
            Name = "ClickerPage";
            Text = "Кликер";
            EnabledChanged += ClickerPage_EnabledChanged;
            ((System.ComponentModel.ISupportInitialize)delayHint).EndInit();
            ((System.ComponentModel.ISupportInitialize)randomDelayHint).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeLimitHint).EndInit();
            ((System.ComponentModel.ISupportInitialize)clickLimitHint).EndInit();
            ((System.ComponentModel.ISupportInitialize)delayedStartHint).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coordHint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DelayLabel;
        private TextBox delayHoursTextBox;
        private TextBox delayMinutesTextBox;
        private TextBox delaySecondsTextBox;
        private TextBox delayMilisecondsTextBox;
        private CheckBox randomDelayCheckBox;
        private Label labelHoursDelay;
        private Label labelMinutesDelay;
        private Label labelSwcondsDelay;
        private Label labelMilisecondsDelay;
        private TextBox randomDelayTextBox;
        private Label label3;
        private Label labelRandomDelay;
        private TextBox timeLimitHours;
        private TextBox timeLimitMinutes;
        private TextBox timeLimitSeconds;
        private TextBox timeLimitMiliseconds;
        private Label label17;
        private Label labelTimeLimitHours;
        private Label labelTimeLimitMinutes;
        private Label labelTimeLimitSeconds;
        private Label labelTimeLimitMiliseconds;
        private TextBox clickLimitTextBox;
        private Label label22;
        private Label labelClickLimit;
        private CheckBox timeLImitCheckbox;
        private CheckBox clickLimitCheckBox;
        private CheckBox delayCheckBox;
        private PictureBox delayHint;
        private ToolTip toolTip1;
        private PictureBox randomDelayHint;
        private PictureBox timeLimitHint;
        private PictureBox clickLimitHint;
        private Button startButton;
        private Button stopButton;
        private Panel panel1;
        private TextBox delayedStartTextBox;
        private Label labelDelayedStart;
        private CheckBox delayedStartCheckBox;
        private Label label2;
        private PictureBox delayedStartHint;
        private Label labelMouseButton;
        private ComboBox mouseButtonComboBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox customCoordCheckBox;
        private Label label1;
        private PictureBox coordHint;
        private Button testClickButton;
        private Label labelClicksCounter;
        private Label cpsLabel;
        private System.ComponentModel.BackgroundWorker clickTestBackgroundWorker;
        private ComboBox timeToTestComboBox;
        private Label labelTimeToTest;
        private Button resetTestButton;
        private Label labelTimeSeconds;
        private ListBox listBox1;
        private Button editClickPointButton;
        private Button deleteClickPointButton;
        private Button addClickPointButton;
    }
}
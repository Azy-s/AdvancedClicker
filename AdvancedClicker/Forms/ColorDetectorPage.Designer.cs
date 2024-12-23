namespace AdvancedClicker.Forms
{
    partial class ColorDetectorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorDetectorPage));
            colorDialog1 = new ColorDialog();
            colorPickPanel = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            mouseCursorRadioButton = new RadioButton();
            panel2 = new Panel();
            screenAreaRadioButton = new RadioButton();
            label1 = new Label();
            panel1 = new Panel();
            delayedStartTextBox = new CustomModules.NumericTextBox();
            delayedStartCheckBox = new CustomModules.MobileCheckBox();
            startButton = new Button();
            delayedStartHint = new PictureBox();
            stopButton = new Button();
            labelDelayedStart = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            comboBox2 = new ComboBox();
            randomDelayAfterClick = new CustomModules.NumericTextBox();
            randomHoldButtonTime = new CustomModules.NumericTextBox();
            label12 = new Label();
            holdButtonTime = new CustomModules.NumericTextBox();
            label9 = new Label();
            delayAfterCLick = new CustomModules.NumericTextBox();
            label7 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delayedStartHint).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // colorPickPanel
            // 
            colorPickPanel.Location = new Point(1, 44);
            colorPickPanel.Name = "colorPickPanel";
            colorPickPanel.Size = new Size(450, 230);
            colorPickPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(82, 82, 82);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Цвета", "Градиент" });
            comboBox1.Location = new Point(129, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Тип цвета";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mouseCursorRadioButton);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(screenAreaRadioButton);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(1, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 126);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // mouseCursorRadioButton
            // 
            mouseCursorRadioButton.Appearance = Appearance.Button;
            mouseCursorRadioButton.AutoSize = true;
            mouseCursorRadioButton.Checked = true;
            mouseCursorRadioButton.FlatAppearance.BorderSize = 0;
            mouseCursorRadioButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            mouseCursorRadioButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            mouseCursorRadioButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            mouseCursorRadioButton.FlatStyle = FlatStyle.Flat;
            mouseCursorRadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mouseCursorRadioButton.ForeColor = SystemColors.Control;
            mouseCursorRadioButton.Image = Properties.Resources.radiobutton_on_icon;
            mouseCursorRadioButton.ImageAlign = ContentAlignment.MiddleLeft;
            mouseCursorRadioButton.Location = new Point(11, 42);
            mouseCursorRadioButton.Name = "mouseCursorRadioButton";
            mouseCursorRadioButton.Size = new Size(126, 30);
            mouseCursorRadioButton.TabIndex = 5;
            mouseCursorRadioButton.TabStop = true;
            mouseCursorRadioButton.Tag = "RMouse";
            mouseCursorRadioButton.Text = "Курсор мыши";
            mouseCursorRadioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            mouseCursorRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(245, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 110);
            panel2.TabIndex = 13;
            // 
            // screenAreaRadioButton
            // 
            screenAreaRadioButton.Appearance = Appearance.Button;
            screenAreaRadioButton.AutoSize = true;
            screenAreaRadioButton.FlatAppearance.BorderSize = 0;
            screenAreaRadioButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            screenAreaRadioButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            screenAreaRadioButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            screenAreaRadioButton.FlatStyle = FlatStyle.Flat;
            screenAreaRadioButton.Font = new Font("Segoe UI", 9.75F);
            screenAreaRadioButton.ForeColor = SystemColors.Control;
            screenAreaRadioButton.Image = Properties.Resources.radiobutton_off_icon;
            screenAreaRadioButton.ImageAlign = ContentAlignment.MiddleLeft;
            screenAreaRadioButton.Location = new Point(11, 78);
            screenAreaRadioButton.Name = "screenAreaRadioButton";
            screenAreaRadioButton.Size = new Size(137, 30);
            screenAreaRadioButton.TabIndex = 5;
            screenAreaRadioButton.Tag = "RArea";
            screenAreaRadioButton.Text = "Область экрана";
            screenAreaRadioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            screenAreaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 3;
            label1.Text = "Позиция сканирования";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(delayedStartTextBox);
            panel1.Controls.Add(delayedStartCheckBox);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(delayedStartHint);
            panel1.Controls.Add(stopButton);
            panel1.Controls.Add(labelDelayedStart);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 80);
            panel1.TabIndex = 14;
            // 
            // delayedStartTextBox
            // 
            delayedStartTextBox.BackColor = Color.FromArgb(65, 65, 65);
            delayedStartTextBox.BorderStyle = BorderStyle.FixedSingle;
            delayedStartTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            delayedStartTextBox.ForeColor = Color.White;
            delayedStartTextBox.Location = new Point(576, 27);
            delayedStartTextBox.MaxLength = 4;
            delayedStartTextBox.Name = "delayedStartTextBox";
            delayedStartTextBox.Size = new Size(51, 27);
            delayedStartTextBox.TabIndex = 13;
            delayedStartTextBox.Text = "2";
            delayedStartTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // delayedStartCheckBox
            // 
            delayedStartCheckBox.Appearance = Appearance.Button;
            delayedStartCheckBox.AutoSize = true;
            delayedStartCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            delayedStartCheckBox.FlatAppearance.BorderSize = 0;
            delayedStartCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            delayedStartCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            delayedStartCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            delayedStartCheckBox.FlatStyle = FlatStyle.Flat;
            delayedStartCheckBox.ForeColor = Color.White;
            delayedStartCheckBox.Image = (Image)resources.GetObject("delayedStartCheckBox.Image");
            delayedStartCheckBox.Location = new Point(352, 26);
            delayedStartCheckBox.Name = "delayedStartCheckBox";
            delayedStartCheckBox.Size = new Size(50, 28);
            delayedStartCheckBox.TabIndex = 9;
            delayedStartCheckBox.UseVisualStyleBackColor = true;
            delayedStartCheckBox.CheckedChanged += mobileCheckBox1_CheckedChanged;
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
            startButton.Click += startButton_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(633, 33);
            label3.Name = "label3";
            label3.Size = new Size(27, 14);
            label3.TabIndex = 10;
            label3.Text = "Сек";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(randomDelayAfterClick);
            groupBox2.Controls.Add(randomHoldButtonTime);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(holdButtonTime);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(delayAfterCLick);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(457, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 274);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(56, 19);
            label13.Name = "label13";
            label13.Size = new Size(127, 20);
            label13.TabIndex = 13;
            label13.Text = "Настройки клика";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(82, 82, 82);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = SystemColors.Control;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Mouse Left", "Mouse Right", "Mouse Middle", "Scroll Up", "Scroll Down" });
            comboBox2.Location = new Point(122, 242);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(112, 23);
            comboBox2.TabIndex = 12;
            // 
            // randomDelayAfterClick
            // 
            randomDelayAfterClick.BackColor = Color.FromArgb(68, 68, 68);
            randomDelayAfterClick.BorderStyle = BorderStyle.FixedSingle;
            randomDelayAfterClick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            randomDelayAfterClick.ForeColor = Color.White;
            randomDelayAfterClick.Location = new Point(144, 78);
            randomDelayAfterClick.MaxLength = 5;
            randomDelayAfterClick.Name = "randomDelayAfterClick";
            randomDelayAfterClick.Size = new Size(66, 23);
            randomDelayAfterClick.TabIndex = 11;
            randomDelayAfterClick.Text = "0";
            randomDelayAfterClick.TextAlign = HorizontalAlignment.Center;
            // 
            // randomHoldButtonTime
            // 
            randomHoldButtonTime.BackColor = Color.FromArgb(68, 68, 68);
            randomHoldButtonTime.BorderStyle = BorderStyle.FixedSingle;
            randomHoldButtonTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            randomHoldButtonTime.ForeColor = Color.White;
            randomHoldButtonTime.Location = new Point(144, 136);
            randomHoldButtonTime.MaxLength = 5;
            randomHoldButtonTime.Name = "randomHoldButtonTime";
            randomHoldButtonTime.Size = new Size(66, 23);
            randomHoldButtonTime.TabIndex = 11;
            randomHoldButtonTime.Text = "0";
            randomHoldButtonTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(212, 81);
            label12.Name = "label12";
            label12.Size = new Size(22, 15);
            label12.TabIndex = 10;
            label12.Text = "мс";
            // 
            // holdButtonTime
            // 
            holdButtonTime.BackColor = Color.FromArgb(68, 68, 68);
            holdButtonTime.BorderStyle = BorderStyle.FixedSingle;
            holdButtonTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            holdButtonTime.ForeColor = Color.White;
            holdButtonTime.Location = new Point(144, 107);
            holdButtonTime.MaxLength = 5;
            holdButtonTime.Name = "holdButtonTime";
            holdButtonTime.Size = new Size(66, 23);
            holdButtonTime.TabIndex = 11;
            holdButtonTime.Text = "0";
            holdButtonTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(212, 139);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 10;
            label9.Text = "мс";
            // 
            // delayAfterCLick
            // 
            delayAfterCLick.BackColor = Color.FromArgb(68, 68, 68);
            delayAfterCLick.BorderStyle = BorderStyle.FixedSingle;
            delayAfterCLick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delayAfterCLick.ForeColor = Color.White;
            delayAfterCLick.Location = new Point(144, 50);
            delayAfterCLick.MaxLength = 5;
            delayAfterCLick.Name = "delayAfterCLick";
            delayAfterCLick.Size = new Size(66, 23);
            delayAfterCLick.TabIndex = 11;
            delayAfterCLick.Text = "0";
            delayAfterCLick.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(212, 110);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 10;
            label7.Text = "мс";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(6, 81);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 10;
            label11.Text = "Случ. задержка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(6, 245);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 10;
            label10.Text = "Кнопка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(6, 139);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 10;
            label8.Text = "Случ. время зажатия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(212, 53);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 10;
            label5.Text = "мс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(6, 110);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 10;
            label6.Text = "Время зажатия кнопки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 53);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 10;
            label4.Text = "Задержка после клика";
            // 
            // ColorDetectorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(700, 480);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(colorPickPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ColorDetectorPage";
            ShowIcon = false;
            Text = "Детектор цвета";
            EnabledChanged += ColorDetectorPage_EnabledChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delayedStartHint).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel colorPickPanel;
        private ComboBox comboBox1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private RadioButton screenAreaRadioButton;
        private RadioButton mouseCursorRadioButton;
        private Panel panel1;
        private Button startButton;
        private PictureBox delayedStartHint;
        private Button stopButton;
        private Label labelDelayedStart;
        private Label label3;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private CustomModules.NumericTextBox delayAfterCLick;
        private CustomModules.NumericTextBox randomHoldButtonTime;
        private CustomModules.NumericTextBox holdButtonTime;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label6;
        private ComboBox comboBox2;
        private Label label10;
        private CustomModules.NumericTextBox randomDelayAfterClick;
        private Label label12;
        private Label label11;
        private Label label13;
        private CustomModules.MobileCheckBox delayedStartCheckBox;
        private CustomModules.NumericTextBox delayedStartTextBox;
    }
}
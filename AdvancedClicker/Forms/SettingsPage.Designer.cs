namespace AdvancedClicker.Forms
{
    partial class SettingsPage
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
            languageLabel = new Label();
            languageComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            languageLabel.ForeColor = SystemColors.Control;
            languageLabel.Location = new Point(36, 17);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(37, 17);
            languageLabel.TabIndex = 0;
            languageLabel.Text = "Язык";
            // 
            // languageComboBox
            // 
            languageComboBox.BackColor = Color.DimGray;
            languageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languageComboBox.FlatStyle = FlatStyle.Flat;
            languageComboBox.Font = new Font("Segoe UI", 9.75F);
            languageComboBox.ForeColor = Color.White;
            languageComboBox.FormattingEnabled = true;
            languageComboBox.Items.AddRange(new object[] { "Русский", "English" });
            languageComboBox.Location = new Point(183, 14);
            languageComboBox.Name = "languageComboBox";
            languageComboBox.Size = new Size(93, 25);
            languageComboBox.TabIndex = 3;
            languageComboBox.SelectedIndexChanged += languageCombobox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._9042463_language_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(37, 53);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 0;
            label1.Text = "Старт";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._8664826_keyboard_computer_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(9, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 0;
            label2.Text = "Стоп";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources._8664826_keyboard_computer_icon1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(9, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.DimGray;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 9.75F);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Mouse4", "Mouse5", "Numpad0", "Numpad1", "Numpad2", "Numpad3", "Numpad4", "Numpad5", "Numpad6", "Numpad7", "Numpad8", "Numpad9" });
            comboBox2.Location = new Point(183, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(93, 25);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.DimGray;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 9.75F);
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Mouse4", "Mouse5", "Numpad0", "Numpad1", "Numpad2", "Numpad3", "Numpad4", "Numpad5", "Numpad6", "Numpad7", "Numpad8", "Numpad9" });
            comboBox3.Location = new Point(183, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(93, 25);
            comboBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DimGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9.75F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "Ctrl", "Alt", "Shift" });
            comboBox1.Location = new Point(93, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 25);
            comboBox1.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.DimGray;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.Font = new Font("Segoe UI", 9.75F);
            comboBox4.ForeColor = Color.White;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "-", "Ctrl", "Alt", "Shift" });
            comboBox4.Location = new Point(93, 87);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(67, 25);
            comboBox4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(163, 55);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 0;
            label3.Text = "+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(163, 90);
            label4.Name = "label4";
            label4.Size = new Size(17, 17);
            label4.TabIndex = 0;
            label4.Text = "+";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(684, 441);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(languageComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(languageLabel);
            Name = "SettingsPage";
            Text = "1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label languageLabel;
        private ComboBox languageComboBox;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private Label label3;
        private Label label4;
    }
}
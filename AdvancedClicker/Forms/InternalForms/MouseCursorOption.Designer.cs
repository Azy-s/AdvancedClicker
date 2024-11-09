namespace AdvancedClicker.Forms.InternalForms
{
    partial class MouseCursorOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseCursorOption));
            chooseRadiusButton = new Button();
            smoothnessLabel = new Label();
            roundTrackBar1 = new RoundTrackBar();
            smoothnessValue = new Label();
            aimModeCheckbox = new CustomModules.MobileCheckBox();
            label1 = new Label();
            label2 = new Label();
            isColorInCenterCheckBox = new CustomModules.MobileCheckBox();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // chooseRadiusButton
            // 
            chooseRadiusButton.BackColor = Color.FromArgb(82, 82, 82);
            chooseRadiusButton.FlatAppearance.BorderColor = Color.Silver;
            chooseRadiusButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 65, 71);
            chooseRadiusButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            chooseRadiusButton.FlatStyle = FlatStyle.Flat;
            chooseRadiusButton.ForeColor = SystemColors.Control;
            chooseRadiusButton.Image = Properties.Resources.pick_radius_icon;
            chooseRadiusButton.ImageAlign = ContentAlignment.MiddleLeft;
            chooseRadiusButton.Location = new Point(12, 12);
            chooseRadiusButton.Name = "chooseRadiusButton";
            chooseRadiusButton.Size = new Size(183, 42);
            chooseRadiusButton.TabIndex = 22;
            chooseRadiusButton.Text = "  Выбрать радиус";
            chooseRadiusButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            chooseRadiusButton.UseVisualStyleBackColor = false;
            chooseRadiusButton.Click += chooseRadiusButton_Click;
            // 
            // smoothnessLabel
            // 
            smoothnessLabel.AutoSize = true;
            smoothnessLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            smoothnessLabel.ForeColor = SystemColors.Control;
            smoothnessLabel.Location = new Point(205, 73);
            smoothnessLabel.Name = "smoothnessLabel";
            smoothnessLabel.Size = new Size(83, 20);
            smoothnessLabel.TabIndex = 23;
            smoothnessLabel.Text = "Плавность";
            // 
            // roundTrackBar1
            // 
            roundTrackBar1.ElipseColor = Color.FromArgb(202, 62, 71);
            roundTrackBar1.ElipseRadius = 10;
            roundTrackBar1.EndColor = Color.DarkGray;
            roundTrackBar1.Location = new Point(294, 61);
            roundTrackBar1.Maximum = 100;
            roundTrackBar1.Minimum = 10;
            roundTrackBar1.Name = "roundTrackBar1";
            roundTrackBar1.Size = new Size(126, 45);
            roundTrackBar1.StartColor = Color.DarkGray;
            roundTrackBar1.TabIndex = 24;
            roundTrackBar1.Value = 10;
            roundTrackBar1.Scroll += roundTrackBar1_Scroll;
            roundTrackBar1.EnabledChanged += roundTrackBar1_EnabledChanged;
            // 
            // smoothnessValue
            // 
            smoothnessValue.AutoSize = true;
            smoothnessValue.ForeColor = SystemColors.Control;
            smoothnessValue.Location = new Point(425, 77);
            smoothnessValue.Name = "smoothnessValue";
            smoothnessValue.Size = new Size(22, 15);
            smoothnessValue.TabIndex = 25;
            smoothnessValue.Text = "1.0";
            // 
            // aimModeCheckbox
            // 
            aimModeCheckbox.Appearance = Appearance.Button;
            aimModeCheckbox.AutoSize = true;
            aimModeCheckbox.BackgroundImageLayout = ImageLayout.Stretch;
            aimModeCheckbox.Checked = true;
            aimModeCheckbox.CheckState = CheckState.Checked;
            aimModeCheckbox.FlatAppearance.BorderSize = 0;
            aimModeCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            aimModeCheckbox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            aimModeCheckbox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            aimModeCheckbox.FlatStyle = FlatStyle.Flat;
            aimModeCheckbox.ForeColor = Color.White;
            aimModeCheckbox.Image = (Image)resources.GetObject("aimModeCheckbox.Image");
            aimModeCheckbox.Location = new Point(388, 2);
            aimModeCheckbox.Name = "aimModeCheckbox";
            aimModeCheckbox.Size = new Size(50, 28);
            aimModeCheckbox.TabIndex = 9;
            aimModeCheckbox.UseVisualStyleBackColor = true;
            aimModeCheckbox.CheckedChanged += mobileCheckBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(205, 5);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 23;
            label1.Text = "Аим режим";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(205, 39);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 23;
            label2.Text = "Проверка цвета в центре";
            // 
            // isColorInCenterCheckBox
            // 
            isColorInCenterCheckBox.Appearance = Appearance.Button;
            isColorInCenterCheckBox.AutoSize = true;
            isColorInCenterCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            isColorInCenterCheckBox.Checked = true;
            isColorInCenterCheckBox.CheckState = CheckState.Checked;
            isColorInCenterCheckBox.FlatAppearance.BorderSize = 0;
            isColorInCenterCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            isColorInCenterCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            isColorInCenterCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            isColorInCenterCheckBox.FlatStyle = FlatStyle.Flat;
            isColorInCenterCheckBox.ForeColor = Color.White;
            isColorInCenterCheckBox.Image = (Image)resources.GetObject("isColorInCenterCheckBox.Image");
            isColorInCenterCheckBox.Location = new Point(388, 36);
            isColorInCenterCheckBox.Name = "isColorInCenterCheckBox";
            isColorInCenterCheckBox.Size = new Size(50, 28);
            isColorInCenterCheckBox.TabIndex = 9;
            isColorInCenterCheckBox.UseVisualStyleBackColor = true;
            isColorInCenterCheckBox.CheckedChanged += mobileCheckBox1_CheckedChanged;
            // 
            // MouseCursorOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(450, 110);
            ControlBox = false;
            Controls.Add(isColorInCenterCheckBox);
            Controls.Add(aimModeCheckbox);
            Controls.Add(smoothnessValue);
            Controls.Add(label2);
            Controls.Add(roundTrackBar1);
            Controls.Add(label1);
            Controls.Add(smoothnessLabel);
            Controls.Add(chooseRadiusButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MouseCursorOption";
            Text = "MouseCursorOption";
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button chooseRadiusButton;
        private Label smoothnessLabel;
        private RoundTrackBar roundTrackBar1;
        private Label smoothnessValue;
        private CustomModules.MobileCheckBox aimModeCheckbox;
        private Label label1;
        private Label label2;
        private CustomModules.MobileCheckBox isColorInCenterCheckBox;
    }
}
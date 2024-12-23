namespace AdvancedClicker.Forms.InternalForms
{
    partial class ScreenAreaOption
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
            yPositionTextBox = new TextBox();
            ChooseAreaButton = new Button();
            xPositionTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            labelYCoord = new Label();
            labelXCoord = new Label();
            ChooseDPIButton = new Button();
            label1 = new Label();
            pointsCountLabel = new Label();
            widthTextBox = new CustomModules.NumericTextBox();
            heightTextBox = new CustomModules.NumericTextBox();
            SuspendLayout();
            // 
            // yPositionTextBox
            // 
            yPositionTextBox.BackColor = Color.FromArgb(68, 68, 68);
            yPositionTextBox.BorderStyle = BorderStyle.FixedSingle;
            yPositionTextBox.Cursor = Cursors.IBeam;
            yPositionTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            yPositionTextBox.ForeColor = Color.White;
            yPositionTextBox.Location = new Point(171, 5);
            yPositionTextBox.MaxLength = 4;
            yPositionTextBox.Name = "yPositionTextBox";
            yPositionTextBox.Size = new Size(56, 27);
            yPositionTextBox.TabIndex = 13;
            yPositionTextBox.Text = "0";
            yPositionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ChooseAreaButton
            // 
            ChooseAreaButton.FlatAppearance.BorderColor = Color.Silver;
            ChooseAreaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 65, 71);
            ChooseAreaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            ChooseAreaButton.FlatStyle = FlatStyle.Flat;
            ChooseAreaButton.ForeColor = SystemColors.Control;
            ChooseAreaButton.Image = Properties.Resources.capture_area_icon;
            ChooseAreaButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChooseAreaButton.Location = new Point(10, 60);
            ChooseAreaButton.Name = "ChooseAreaButton";
            ChooseAreaButton.Size = new Size(217, 42);
            ChooseAreaButton.TabIndex = 21;
            ChooseAreaButton.Text = "  Выбрать зону";
            ChooseAreaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChooseAreaButton.UseVisualStyleBackColor = true;
            ChooseAreaButton.Click += ChooseAreaButton_Click;
            // 
            // xPositionTextBox
            // 
            xPositionTextBox.BackColor = Color.FromArgb(68, 68, 68);
            xPositionTextBox.BorderStyle = BorderStyle.FixedSingle;
            xPositionTextBox.Cursor = Cursors.IBeam;
            xPositionTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            xPositionTextBox.ForeColor = Color.White;
            xPositionTextBox.Location = new Point(61, 5);
            xPositionTextBox.MaxLength = 4;
            xPositionTextBox.Name = "xPositionTextBox";
            xPositionTextBox.Size = new Size(56, 27);
            xPositionTextBox.TabIndex = 14;
            xPositionTextBox.Text = "0";
            xPositionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(123, 39);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 19;
            label5.Text = "Высота";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(10, 39);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 20;
            label4.Text = "Ширина";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelYCoord
            // 
            labelYCoord.AutoSize = true;
            labelYCoord.ForeColor = SystemColors.Control;
            labelYCoord.Location = new Point(151, 11);
            labelYCoord.Name = "labelYCoord";
            labelYCoord.Size = new Size(14, 15);
            labelYCoord.TabIndex = 17;
            labelYCoord.Text = "Y";
            // 
            // labelXCoord
            // 
            labelXCoord.AutoSize = true;
            labelXCoord.ForeColor = SystemColors.Control;
            labelXCoord.Location = new Point(41, 11);
            labelXCoord.Name = "labelXCoord";
            labelXCoord.Size = new Size(14, 15);
            labelXCoord.TabIndex = 18;
            labelXCoord.Text = "X";
            // 
            // ChooseDPIButton
            // 
            ChooseDPIButton.FlatAppearance.BorderColor = Color.Silver;
            ChooseDPIButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 65, 71);
            ChooseDPIButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            ChooseDPIButton.FlatStyle = FlatStyle.Flat;
            ChooseDPIButton.ForeColor = SystemColors.Control;
            ChooseDPIButton.Image = Properties.Resources.dpi_red_icon;
            ChooseDPIButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChooseDPIButton.Location = new Point(248, 60);
            ChooseDPIButton.Name = "ChooseDPIButton";
            ChooseDPIButton.Size = new Size(193, 42);
            ChooseDPIButton.TabIndex = 21;
            ChooseDPIButton.Text = "  Указать точки";
            ChooseDPIButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChooseDPIButton.UseVisualStyleBackColor = true;
            ChooseDPIButton.Click += ChooseDPIButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(248, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 22;
            label1.Text = "Точек для мониторинга:";
            // 
            // pointsCountLabel
            // 
            pointsCountLabel.AutoSize = true;
            pointsCountLabel.ForeColor = Color.Red;
            pointsCountLabel.Location = new Point(411, 33);
            pointsCountLabel.Name = "pointsCountLabel";
            pointsCountLabel.Size = new Size(13, 15);
            pointsCountLabel.TabIndex = 22;
            pointsCountLabel.Text = "0";
            // 
            // widthTextBox
            // 
            widthTextBox.BackColor = Color.FromArgb(68, 68, 68);
            widthTextBox.BorderStyle = BorderStyle.FixedSingle;
            widthTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            widthTextBox.ForeColor = Color.White;
            widthTextBox.Location = new Point(61, 33);
            widthTextBox.MaxLength = 4;
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(56, 27);
            widthTextBox.TabIndex = 23;
            widthTextBox.Text = "100";
            widthTextBox.TextAlign = HorizontalAlignment.Center;
            widthTextBox.TextChanged += AreaTextBox_TextChanged;
            // 
            // heightTextBox
            // 
            heightTextBox.BackColor = Color.FromArgb(68, 68, 68);
            heightTextBox.BorderStyle = BorderStyle.FixedSingle;
            heightTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            heightTextBox.ForeColor = Color.White;
            heightTextBox.Location = new Point(171, 33);
            heightTextBox.MaxLength = 4;
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(56, 27);
            heightTextBox.TabIndex = 24;
            heightTextBox.Text = "100";
            heightTextBox.TextAlign = HorizontalAlignment.Center;
            heightTextBox.TextChanged += AreaTextBox_TextChanged;
            // 
            // ScreenAreaOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(450, 110);
            Controls.Add(heightTextBox);
            Controls.Add(widthTextBox);
            Controls.Add(pointsCountLabel);
            Controls.Add(label1);
            Controls.Add(yPositionTextBox);
            Controls.Add(ChooseDPIButton);
            Controls.Add(ChooseAreaButton);
            Controls.Add(xPositionTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelYCoord);
            Controls.Add(labelXCoord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenAreaOption";
            Text = "ScreenAreaOption";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox yPositionTextBox;
        private Button ChooseAreaButton;
        private TextBox xPositionTextBox;
        private Label label5;
        private Label label4;
        private Label labelYCoord;
        private Label labelXCoord;
        private Button ChooseDPIButton;
        private Label label1;
        private Label pointsCountLabel;
        private CustomModules.NumericTextBox widthTextBox;
        private CustomModules.NumericTextBox heightTextBox;
    }
}
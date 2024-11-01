namespace AdvancedClicker.Forms.InternalForms
{
    partial class MouseRadiusSelector
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            radiusTrackbar = new RoundTrackBar();
            label1 = new Label();
            pointsTrackbar = new RoundTrackBar();
            label2 = new Label();
            chooseColorButton = new Button();
            radiusTextBox = new CustomModules.NumericTextBox();
            pointsTextBox = new CustomModules.NumericTextBox();
            okButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radiusTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointsTrackbar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(82, 82, 82);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 494);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 486);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.DragEnter += pictureBox1_DragEnter;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // radiusTrackbar
            // 
            radiusTrackbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radiusTrackbar.ElipseColor = Color.FromArgb(202, 62, 71);
            radiusTrackbar.ElipseRadius = 10;
            radiusTrackbar.EndColor = Color.Red;
            radiusTrackbar.Location = new Point(564, 46);
            radiusTrackbar.Maximum = 720;
            radiusTrackbar.Minimum = 1;
            radiusTrackbar.Name = "radiusTrackbar";
            radiusTrackbar.Size = new Size(224, 45);
            radiusTrackbar.StartColor = Color.Lime;
            radiusTrackbar.TabIndex = 7;
            radiusTrackbar.Value = 50;
            radiusTrackbar.Scroll += radiusTrackbar_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(675, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 8;
            label1.Text = "Радиус";
            // 
            // pointsTrackbar
            // 
            pointsTrackbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pointsTrackbar.ElipseColor = Color.FromArgb(202, 62, 71);
            pointsTrackbar.ElipseRadius = 10;
            pointsTrackbar.EndColor = Color.Red;
            pointsTrackbar.Location = new Point(564, 110);
            pointsTrackbar.Maximum = 1000;
            pointsTrackbar.Minimum = 1;
            pointsTrackbar.Name = "pointsTrackbar";
            pointsTrackbar.Size = new Size(224, 45);
            pointsTrackbar.StartColor = Color.Lime;
            pointsTrackbar.TabIndex = 7;
            pointsTrackbar.Value = 50;
            pointsTrackbar.Scroll += pointsTrackbar_Scroll;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(675, 90);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 8;
            label2.Text = "Точки";
            // 
            // chooseColorButton
            // 
            chooseColorButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseColorButton.BackColor = Color.Red;
            chooseColorButton.BackgroundImage = Properties.Resources.colorpicker_white_icon;
            chooseColorButton.BackgroundImageLayout = ImageLayout.Stretch;
            chooseColorButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            chooseColorButton.FlatStyle = FlatStyle.Flat;
            chooseColorButton.Location = new Point(564, 175);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(32, 32);
            chooseColorButton.TabIndex = 13;
            chooseColorButton.UseVisualStyleBackColor = false;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // radiusTextBox
            // 
            radiusTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radiusTextBox.BackColor = Color.FromArgb(68, 68, 68);
            radiusTextBox.BorderStyle = BorderStyle.FixedSingle;
            radiusTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            radiusTextBox.ForeColor = Color.White;
            radiusTextBox.Location = new Point(794, 55);
            radiusTextBox.MaxLength = 4;
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(51, 27);
            radiusTextBox.TabIndex = 14;
            radiusTextBox.Text = "50";
            radiusTextBox.TextAlign = HorizontalAlignment.Center;
            radiusTextBox.TextChanged += radiusTextBox_TextChanged;
            // 
            // pointsTextBox
            // 
            pointsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pointsTextBox.BackColor = Color.FromArgb(68, 68, 68);
            pointsTextBox.BorderStyle = BorderStyle.FixedSingle;
            pointsTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            pointsTextBox.ForeColor = Color.White;
            pointsTextBox.Location = new Point(794, 119);
            pointsTextBox.MaxLength = 4;
            pointsTextBox.Name = "pointsTextBox";
            pointsTextBox.Size = new Size(51, 27);
            pointsTextBox.TabIndex = 14;
            pointsTextBox.Text = "50";
            pointsTextBox.TextAlign = HorizontalAlignment.Center;
            pointsTextBox.TextChanged += pointsTextBox_TextChanged;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.BackColor = Color.FromArgb(65, 65, 65);
            okButton.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            okButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            okButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.ForeColor = SystemColors.Control;
            okButton.Location = new Point(561, 450);
            okButton.Name = "okButton";
            okButton.Size = new Size(284, 41);
            okButton.TabIndex = 15;
            okButton.Text = "Сохранить";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // MouseRadiusSelector
            // 
            AcceptButton = okButton;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(857, 503);
            Controls.Add(okButton);
            Controls.Add(pointsTextBox);
            Controls.Add(radiusTextBox);
            Controls.Add(chooseColorButton);
            Controls.Add(label2);
            Controls.Add(pointsTrackbar);
            Controls.Add(label1);
            Controls.Add(radiusTrackbar);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "MouseRadiusSelector";
            ShowIcon = false;
            Text = "MouseRadiusSelector";
            FormClosed += MouseRadiusSelector_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radiusTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointsTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private RoundTrackBar radiusTrackbar;
        private Label label1;
        private RoundTrackBar pointsTrackbar;
        private Label label2;
        private Button chooseColorButton;
        private CustomModules.NumericTextBox radiusTextBox;
        private CustomModules.NumericTextBox pointsTextBox;
        private Button okButton;
    }
}
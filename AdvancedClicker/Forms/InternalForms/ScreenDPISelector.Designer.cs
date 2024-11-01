namespace AdvancedClicker.Forms.InternalForms
{
    partial class ScreenDPISelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenDPISelector));
            DPITrackBarX = new RoundTrackBar();
            label1 = new Label();
            DPITrackBarY = new RoundTrackBar();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            acceptButton = new Button();
            customPointsCheckbox = new CustomModules.MobileCheckBox();
            customPointsLabel = new Label();
            listBox1 = new ListBox();
            chooseColorButton = new Button();
            toolTip1 = new ToolTip(components);
            customDotsHint = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DPITrackBarX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DPITrackBarY).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customDotsHint).BeginInit();
            SuspendLayout();
            // 
            // DPITrackBarX
            // 
            DPITrackBarX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DPITrackBarX.ElipseColor = Color.Gainsboro;
            DPITrackBarX.ElipseRadius = 10;
            DPITrackBarX.EndColor = Color.Red;
            DPITrackBarX.LargeChange = 1;
            DPITrackBarX.Location = new Point(507, 33);
            DPITrackBarX.Maximum = 100;
            DPITrackBarX.Minimum = 1;
            DPITrackBarX.Name = "DPITrackBarX";
            DPITrackBarX.Size = new Size(283, 45);
            DPITrackBarX.StartColor = Color.Lime;
            DPITrackBarX.TabIndex = 1;
            DPITrackBarX.Value = 10;
            DPITrackBarX.Scroll += DPITrackBarX_Scroll;
            DPITrackBarX.EnabledChanged += DPITrackBar_EnabledChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(552, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 2;
            label1.Text = "Плотность пикселей";
            // 
            // DPITrackBarY
            // 
            DPITrackBarY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DPITrackBarY.ElipseColor = Color.Gainsboro;
            DPITrackBarY.ElipseRadius = 10;
            DPITrackBarY.EndColor = Color.Red;
            DPITrackBarY.LargeChange = 1;
            DPITrackBarY.Location = new Point(507, 84);
            DPITrackBarY.Maximum = 100;
            DPITrackBarY.Minimum = 1;
            DPITrackBarY.Name = "DPITrackBarY";
            DPITrackBarY.Size = new Size(283, 45);
            DPITrackBarY.StartColor = Color.Lime;
            DPITrackBarY.TabIndex = 1;
            DPITrackBarY.Value = 10;
            DPITrackBarY.Scroll += DPITrackBarY_Scroll;
            DPITrackBarY.EnabledChanged += DPITrackBar_EnabledChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 419);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(487, 48);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 6;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(487, 99);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 6;
            label6.Text = "Y";
            // 
            // acceptButton
            // 
            acceptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            acceptButton.BackColor = Color.FromArgb(64, 64, 64);
            acceptButton.FlatAppearance.BorderColor = Color.Silver;
            acceptButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.ForeColor = SystemColors.Control;
            acceptButton.Location = new Point(697, 383);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(91, 31);
            acceptButton.TabIndex = 7;
            acceptButton.Text = "Ok";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // customPointsCheckbox
            // 
            customPointsCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPointsCheckbox.Appearance = Appearance.Button;
            customPointsCheckbox.AutoSize = true;
            customPointsCheckbox.BackgroundImageLayout = ImageLayout.Stretch;
            customPointsCheckbox.FlatAppearance.BorderSize = 0;
            customPointsCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 82, 82);
            customPointsCheckbox.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 82);
            customPointsCheckbox.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 82, 82);
            customPointsCheckbox.FlatStyle = FlatStyle.Flat;
            customPointsCheckbox.ForeColor = Color.White;
            customPointsCheckbox.Image = (Image)resources.GetObject("customPointsCheckbox.Image");
            customPointsCheckbox.Location = new Point(514, 184);
            customPointsCheckbox.Name = "customPointsCheckbox";
            customPointsCheckbox.Size = new Size(50, 28);
            customPointsCheckbox.TabIndex = 9;
            customPointsCheckbox.UseVisualStyleBackColor = true;
            customPointsCheckbox.CheckedChanged += mobileCheckBox1_CheckedChanged;
            // 
            // customPointsLabel
            // 
            customPointsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPointsLabel.AutoSize = true;
            customPointsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customPointsLabel.ForeColor = SystemColors.Control;
            customPointsLabel.Location = new Point(570, 189);
            customPointsLabel.Name = "customPointsLabel";
            customPointsLabel.Size = new Size(146, 17);
            customPointsLabel.TabIndex = 10;
            customPointsLabel.Text = "Указать точки вручную";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBox1.BackColor = Color.FromArgb(71, 71, 71);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Enabled = false;
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(487, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(110, 182);
            listBox1.TabIndex = 11;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // chooseColorButton
            // 
            chooseColorButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseColorButton.BackColor = Color.Red;
            chooseColorButton.BackgroundImage = Properties.Resources.colorpicker_white_icon;
            chooseColorButton.BackgroundImageLayout = ImageLayout.Stretch;
            chooseColorButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            chooseColorButton.FlatStyle = FlatStyle.Flat;
            chooseColorButton.Location = new Point(488, 141);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(32, 32);
            chooseColorButton.TabIndex = 12;
            chooseColorButton.UseVisualStyleBackColor = false;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 480;
            toolTip1.ReshowDelay = 96;
            // 
            // customDotsHint
            // 
            customDotsHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customDotsHint.BackgroundImage = Properties.Resources.hint_icon;
            customDotsHint.BackgroundImageLayout = ImageLayout.Stretch;
            customDotsHint.Cursor = Cursors.Help;
            customDotsHint.Location = new Point(488, 189);
            customDotsHint.Name = "customDotsHint";
            customDotsHint.Size = new Size(20, 20);
            customDotsHint.TabIndex = 13;
            customDotsHint.TabStop = false;
            toolTip1.SetToolTip(customDotsHint, "ПКМ на изображение что бы добавить точку.\r\nCTRL + Z что бы убрать последнюю точку.\r\nДвойной клик по координатам точки, что бы\r\nубрать конкретную точку.");
            // 
            // ScreenDPISelector
            // 
            AcceptButton = acceptButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(800, 426);
            Controls.Add(customDotsHint);
            Controls.Add(chooseColorButton);
            Controls.Add(listBox1);
            Controls.Add(customPointsLabel);
            Controls.Add(customPointsCheckbox);
            Controls.Add(acceptButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(DPITrackBarY);
            Controls.Add(DPITrackBarX);
            DoubleBuffered = true;
            Name = "ScreenDPISelector";
            Text = "ScreenDPISelector";
            KeyDown += ScreenDPISelector_KeyDown;
            Resize += ScreenDPISelector_Resize;
            ((System.ComponentModel.ISupportInitialize)DPITrackBarX).EndInit();
            ((System.ComponentModel.ISupportInitialize)DPITrackBarY).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customDotsHint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundTrackBar DPITrackBarX;
        private Label label1;
        private RoundTrackBar DPITrackBarY;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button acceptButton;
        private CustomModules.MobileCheckBox customPointsCheckbox;
        private Label customPointsLabel;
        private ListBox listBox1;
        private Button chooseColorButton;
        private ToolTip toolTip1;
        private PictureBox customDotsHint;
    }
}
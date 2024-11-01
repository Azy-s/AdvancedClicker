namespace AdvancedClicker.Forms.InternalForms
{
    partial class PickGradienColor
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
            colorFromImageButton2 = new Button();
            colorFromImageButton1 = new Button();
            pickGradientButton2 = new Button();
            pickGradientButton1 = new Button();
            pictureBox1 = new PictureBox();
            labelGradient = new Label();
            toolTip1 = new ToolTip(components);
            roundTrackBar1 = new RoundTrackBar();
            label1 = new Label();
            label2 = new Label();
            numericTextBox1 = new CustomModules.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // colorFromImageButton2
            // 
            colorFromImageButton2.BackColor = Color.FromArgb(64, 64, 64);
            colorFromImageButton2.BackgroundImage = Properties.Resources.image_icon;
            colorFromImageButton2.BackgroundImageLayout = ImageLayout.Stretch;
            colorFromImageButton2.FlatAppearance.BorderColor = Color.Gray;
            colorFromImageButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            colorFromImageButton2.FlatStyle = FlatStyle.Flat;
            colorFromImageButton2.ForeColor = Color.White;
            colorFromImageButton2.Location = new Point(400, 32);
            colorFromImageButton2.Name = "colorFromImageButton2";
            colorFromImageButton2.Size = new Size(32, 32);
            colorFromImageButton2.TabIndex = 8;
            toolTip1.SetToolTip(colorFromImageButton2, "Выбрать цвет с изображения");
            colorFromImageButton2.UseVisualStyleBackColor = false;
            colorFromImageButton2.Click += colorFromImageButton2_Click;
            // 
            // colorFromImageButton1
            // 
            colorFromImageButton1.BackColor = Color.FromArgb(64, 64, 64);
            colorFromImageButton1.BackgroundImage = Properties.Resources.image_icon;
            colorFromImageButton1.BackgroundImageLayout = ImageLayout.Stretch;
            colorFromImageButton1.FlatAppearance.BorderColor = Color.Gray;
            colorFromImageButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            colorFromImageButton1.FlatStyle = FlatStyle.Flat;
            colorFromImageButton1.ForeColor = Color.White;
            colorFromImageButton1.Location = new Point(17, 32);
            colorFromImageButton1.Name = "colorFromImageButton1";
            colorFromImageButton1.Size = new Size(32, 32);
            colorFromImageButton1.TabIndex = 9;
            toolTip1.SetToolTip(colorFromImageButton1, "Выбрать цвет с изображения");
            colorFromImageButton1.UseVisualStyleBackColor = false;
            colorFromImageButton1.Click += colorFromImageButton1_Click;
            // 
            // pickGradientButton2
            // 
            pickGradientButton2.BackColor = Color.FromArgb(75, 75, 75);
            pickGradientButton2.BackgroundImage = Properties.Resources.colorpicker_white_icon;
            pickGradientButton2.BackgroundImageLayout = ImageLayout.Stretch;
            pickGradientButton2.FlatAppearance.BorderColor = Color.Gray;
            pickGradientButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            pickGradientButton2.FlatAppearance.MouseOverBackColor = Color.DimGray;
            pickGradientButton2.FlatStyle = FlatStyle.Flat;
            pickGradientButton2.ForeColor = Color.White;
            pickGradientButton2.Location = new Point(362, 32);
            pickGradientButton2.Name = "pickGradientButton2";
            pickGradientButton2.Size = new Size(32, 32);
            pickGradientButton2.TabIndex = 6;
            toolTip1.SetToolTip(pickGradientButton2, "Выбрать цвет из палитры");
            pickGradientButton2.UseVisualStyleBackColor = false;
            pickGradientButton2.Click += pickGradientButton2_Click;
            // 
            // pickGradientButton1
            // 
            pickGradientButton1.BackColor = Color.FromArgb(75, 75, 75);
            pickGradientButton1.BackgroundImage = Properties.Resources.colorpicker_white_icon;
            pickGradientButton1.BackgroundImageLayout = ImageLayout.Stretch;
            pickGradientButton1.FlatAppearance.BorderColor = Color.Gray;
            pickGradientButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 62, 71);
            pickGradientButton1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            pickGradientButton1.FlatStyle = FlatStyle.Flat;
            pickGradientButton1.ForeColor = Color.White;
            pickGradientButton1.Location = new Point(55, 32);
            pickGradientButton1.Name = "pickGradientButton1";
            pickGradientButton1.Size = new Size(32, 32);
            pickGradientButton1.TabIndex = 7;
            toolTip1.SetToolTip(pickGradientButton1, "Выбрать цвет из палитры");
            pickGradientButton1.UseVisualStyleBackColor = false;
            pickGradientButton1.Click += pickGradientButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(95, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 32);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // labelGradient
            // 
            labelGradient.AutoSize = true;
            labelGradient.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelGradient.ForeColor = Color.White;
            labelGradient.Location = new Point(190, 9);
            labelGradient.Name = "labelGradient";
            labelGradient.Size = new Size(73, 20);
            labelGradient.TabIndex = 4;
            labelGradient.Text = "Градиент";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(65, 65, 65);
            toolTip1.ForeColor = Color.White;
            // 
            // roundTrackBar1
            // 
            roundTrackBar1.ElipseColor = Color.FromArgb(202, 62, 71);
            roundTrackBar1.ElipseRadius = 10;
            roundTrackBar1.EndColor = Color.DarkGray;
            roundTrackBar1.Location = new Point(95, 143);
            roundTrackBar1.Maximum = 100;
            roundTrackBar1.Name = "roundTrackBar1";
            roundTrackBar1.Size = new Size(261, 45);
            roundTrackBar1.StartColor = Color.DarkGray;
            roundTrackBar1.TabIndex = 10;
            roundTrackBar1.Value = 95;
            roundTrackBar1.Scroll += roundTrackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(415, 153);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 12;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 120);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 4;
            label2.Text = "Процент совпадения";
            // 
            // numericTextBox1
            // 
            numericTextBox1.BackColor = Color.FromArgb(68, 68, 68);
            numericTextBox1.BorderStyle = BorderStyle.FixedSingle;
            numericTextBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            numericTextBox1.ForeColor = Color.White;
            numericTextBox1.Location = new Point(358, 152);
            numericTextBox1.MaxLength = 4;
            numericTextBox1.Name = "numericTextBox1";
            numericTextBox1.Size = new Size(51, 27);
            numericTextBox1.TabIndex = 13;
            numericTextBox1.Text = "95";
            numericTextBox1.TextAlign = HorizontalAlignment.Center;
            numericTextBox1.TextChanged += numericTextBox1_TextChanged;
            // 
            // PickGradienColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(450, 200);
            ControlBox = false;
            Controls.Add(numericTextBox1);
            Controls.Add(label1);
            Controls.Add(roundTrackBar1);
            Controls.Add(colorFromImageButton2);
            Controls.Add(colorFromImageButton1);
            Controls.Add(pickGradientButton2);
            Controls.Add(pickGradientButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(labelGradient);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PickGradienColor";
            ShowIcon = false;
            Text = "PickGradienColor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button colorFromImageButton2;
        private Button colorFromImageButton1;
        private Button pickGradientButton2;
        private Button pickGradientButton1;
        private PictureBox pictureBox1;
        private Label labelGradient;
        private ToolTip toolTip1;
        private RoundTrackBar roundTrackBar1;
        private Label label1;
        private Label label2;
        private CustomModules.NumericTextBox numericTextBox1;
    }
}
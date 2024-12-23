namespace AdvancedClicker.Forms.InternalForms
{
    partial class PickSolidColor
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            addColorButton = new Button();
            roundTrackBar1 = new RoundTrackBar();
            label1 = new Label();
            label2 = new Label();
            colorOffsetTextBox = new CustomModules.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 213);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addColorButton
            // 
            addColorButton.BackColor = Color.FromArgb(64, 64, 64);
            addColorButton.FlatAppearance.BorderColor = Color.Gray;
            addColorButton.FlatStyle = FlatStyle.Flat;
            addColorButton.Location = new Point(206, 3);
            addColorButton.Name = "addColorButton";
            addColorButton.Size = new Size(238, 29);
            addColorButton.TabIndex = 1;
            addColorButton.Text = "Добавить";
            addColorButton.UseVisualStyleBackColor = false;
            addColorButton.Click += AddColorButton_Click;
            // 
            // roundTrackBar1
            // 
            roundTrackBar1.ElipseColor = Color.FromArgb(202, 65, 71);
            roundTrackBar1.ElipseRadius = 10;
            roundTrackBar1.EndColor = Color.DarkGray;
            roundTrackBar1.Location = new Point(206, 158);
            roundTrackBar1.Maximum = 100;
            roundTrackBar1.Name = "roundTrackBar1";
            roundTrackBar1.Size = new Size(238, 45);
            roundTrackBar1.StartColor = Color.DarkGray;
            roundTrackBar1.TabIndex = 2;
            roundTrackBar1.Value = 95;
            roundTrackBar1.Scroll += roundTrackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 131);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 4;
            label1.Text = "Процент совпадения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(421, 128);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 5;
            label2.Text = "%";
            // 
            // colorOffsetTextBox
            // 
            colorOffsetTextBox.BackColor = Color.FromArgb(68, 68, 68);
            colorOffsetTextBox.BorderStyle = BorderStyle.FixedSingle;
            colorOffsetTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            colorOffsetTextBox.ForeColor = Color.White;
            colorOffsetTextBox.Location = new Point(370, 127);
            colorOffsetTextBox.MaxLength = 3;
            colorOffsetTextBox.Name = "colorOffsetTextBox";
            colorOffsetTextBox.Size = new Size(45, 27);
            colorOffsetTextBox.TabIndex = 6;
            colorOffsetTextBox.Text = "95";
            colorOffsetTextBox.TextAlign = HorizontalAlignment.Center;
            colorOffsetTextBox.TextChanged += colorOffsetTextBox_TextChanged;
            // 
            // PickSolidColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(450, 215);
            Controls.Add(colorOffsetTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundTrackBar1);
            Controls.Add(addColorButton);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PickSolidColor";
            Text = "PickSolidColor";
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button addColorButton;
        private RoundTrackBar roundTrackBar1;
        private Label label1;
        private Label label2;
        private CustomModules.NumericTextBox colorOffsetTextBox;
    }
}
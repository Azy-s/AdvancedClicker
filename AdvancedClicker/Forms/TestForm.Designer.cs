namespace AdvancedClicker.Forms
{
    partial class TestForm
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            roundTrackBar1 = new RoundTrackBar();
            roundTrackBar2 = new RoundTrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.checkbox_off_darkicon;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(713, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(475, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(148, 79);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(598, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // roundTrackBar1
            // 
            roundTrackBar1.ElipseColor = Color.FromArgb(202, 65, 71);
            roundTrackBar1.ElipseRadius = 10;
            roundTrackBar1.EndColor = Color.Gray;
            roundTrackBar1.Location = new Point(475, 154);
            roundTrackBar1.Maximum = 400;
            roundTrackBar1.Name = "roundTrackBar1";
            roundTrackBar1.Size = new Size(313, 45);
            roundTrackBar1.StartColor = Color.Gray;
            roundTrackBar1.TabIndex = 4;
            roundTrackBar1.Value = 100;
            roundTrackBar1.Scroll += roundTrackBar1_Scroll;
            // 
            // roundTrackBar2
            // 
            roundTrackBar2.ElipseColor = Color.CadetBlue;
            roundTrackBar2.ElipseRadius = 10;
            roundTrackBar2.EndColor = Color.Gray;
            roundTrackBar2.Location = new Point(475, 205);
            roundTrackBar2.Maximum = 150;
            roundTrackBar2.Name = "roundTrackBar2";
            roundTrackBar2.Size = new Size(313, 45);
            roundTrackBar2.StartColor = Color.Gray;
            roundTrackBar2.TabIndex = 5;
            roundTrackBar2.Scroll += roundTrackBar2_Scroll;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(roundTrackBar2);
            Controls.Add(roundTrackBar1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "TestForm";
            Text = "TestForm";
            TransparencyKey = Color.Gray;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundTrackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private RoundTrackBar roundTrackBar1;
        private RoundTrackBar roundTrackBar2;
    }
}
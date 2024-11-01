namespace AdvancedClicker.Forms
{
    partial class DebugOverlay
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
            colorPanel = new Panel();
            RValue = new Label();
            GValue = new Label();
            BValue = new Label();
            mouseLocation = new Label();
            closeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // colorPanel
            // 
            colorPanel.Location = new Point(12, 44);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(32, 32);
            colorPanel.TabIndex = 0;
            // 
            // RValue
            // 
            RValue.AutoSize = true;
            RValue.ForeColor = Color.Red;
            RValue.Location = new Point(12, 79);
            RValue.Name = "RValue";
            RValue.Size = new Size(38, 15);
            RValue.TabIndex = 1;
            RValue.Text = "label1";
            // 
            // GValue
            // 
            GValue.AutoSize = true;
            GValue.ForeColor = Color.Lime;
            GValue.Location = new Point(12, 94);
            GValue.Name = "GValue";
            GValue.Size = new Size(38, 15);
            GValue.TabIndex = 1;
            GValue.Text = "label1";
            // 
            // BValue
            // 
            BValue.AutoSize = true;
            BValue.ForeColor = Color.Blue;
            BValue.Location = new Point(12, 109);
            BValue.Name = "BValue";
            BValue.Size = new Size(38, 15);
            BValue.TabIndex = 1;
            BValue.Text = "label1";
            // 
            // mouseLocation
            // 
            mouseLocation.AutoSize = true;
            mouseLocation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mouseLocation.ForeColor = Color.White;
            mouseLocation.Location = new Point(12, 9);
            mouseLocation.Name = "mouseLocation";
            mouseLocation.Size = new Size(122, 21);
            mouseLocation.TabIndex = 2;
            mouseLocation.Text = "mouseLocation";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImage = Properties.Resources.close_window_red_icon;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderColor = Color.Gray;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(159, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(32, 32);
            closeButton.TabIndex = 3;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(140, 109);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 4;
            label1.Text = "Fps";
            // 
            // DebugOverlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(197, 144);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(mouseLocation);
            Controls.Add(BValue);
            Controls.Add(GValue);
            Controls.Add(RValue);
            Controls.Add(colorPanel);
            Name = "DebugOverlay";
            Opacity = 0.8D;
            ShowIcon = false;
            FormClosing += DebugOverlay_FormClosing;
            MouseDown += DebugOverlay_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colorPanel;
        private Label RValue;
        private Label GValue;
        private Label BValue;
        private Label mouseLocation;
        private Button closeButton;
        private Label label1;
    }
}
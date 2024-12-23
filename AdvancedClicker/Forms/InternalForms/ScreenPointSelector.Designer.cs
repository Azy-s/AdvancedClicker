namespace AdvancedClicker.Forms.InternalForms
{
    partial class ScreenPointSelector
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
            SuspendLayout();
            // 
            // ScreenPointSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            ControlBox = false;
            Cursor = Cursors.Cross;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ScreenPointSelector";
            Opacity = 0.02D;
            ShowIcon = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;
            Click += ScreenPointSelector_Click;
            ResumeLayout(false);
        }

        #endregion
    }
}
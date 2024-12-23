namespace AdvancedClicker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            closeFormButton = new Button();
            minimizeFormButton = new Button();
            panelMenu = new Panel();
            settingsPageButton = new Button();
            trigerPageButton = new Button();
            colorDetectorPageButton = new Button();
            clickerPageButton = new Button();
            panelLogo = new Panel();
            title = new Label();
            logoPictureBox = new PictureBox();
            panel1 = new Panel();
            pinnFormButton = new Button();
            mainPanel = new Panel();
            toolTip1 = new ToolTip(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeFormButton
            // 
            closeFormButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeFormButton.BackgroundImage = Properties.Resources.close_window_white_icon;
            closeFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeFormButton.FlatAppearance.BorderSize = 0;
            closeFormButton.FlatAppearance.MouseOverBackColor = Color.Crimson;
            closeFormButton.FlatStyle = FlatStyle.Flat;
            closeFormButton.Location = new Point(659, 0);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(41, 41);
            closeFormButton.TabIndex = 2;
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += button1_Click;
            closeFormButton.MouseEnter += button1_MouseEnter;
            closeFormButton.MouseLeave += button1_MouseLeave;
            // 
            // minimizeFormButton
            // 
            minimizeFormButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeFormButton.BackgroundImage = Properties.Resources.minimize_window_white_icon;
            minimizeFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeFormButton.FlatAppearance.BorderSize = 0;
            minimizeFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            minimizeFormButton.FlatStyle = FlatStyle.Flat;
            minimizeFormButton.Location = new Point(618, 0);
            minimizeFormButton.Name = "minimizeFormButton";
            minimizeFormButton.Size = new Size(41, 41);
            minimizeFormButton.TabIndex = 2;
            minimizeFormButton.UseVisualStyleBackColor = true;
            minimizeFormButton.Click += button3_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(65, 65, 65);
            panelMenu.Controls.Add(settingsPageButton);
            panelMenu.Controls.Add(trigerPageButton);
            panelMenu.Controls.Add(colorDetectorPageButton);
            panelMenu.Controls.Add(clickerPageButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(204, 521);
            panelMenu.TabIndex = 5;
            // 
            // settingsPageButton
            // 
            settingsPageButton.Dock = DockStyle.Bottom;
            settingsPageButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            settingsPageButton.FlatStyle = FlatStyle.Flat;
            settingsPageButton.Font = new Font("Segoe UI", 11.25F);
            settingsPageButton.ForeColor = SystemColors.ControlLightLight;
            settingsPageButton.Image = Properties.Resources.setting_page_icon32;
            settingsPageButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsPageButton.Location = new Point(0, 471);
            settingsPageButton.Name = "settingsPageButton";
            settingsPageButton.Padding = new Padding(10, 0, 0, 0);
            settingsPageButton.Size = new Size(204, 50);
            settingsPageButton.TabIndex = 4;
            settingsPageButton.Text = "Настройки";
            settingsPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsPageButton.UseVisualStyleBackColor = true;
            settingsPageButton.Click += settingsPageButton_Click;
            // 
            // trigerPageButton
            // 
            trigerPageButton.Dock = DockStyle.Top;
            trigerPageButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            trigerPageButton.FlatStyle = FlatStyle.Flat;
            trigerPageButton.Font = new Font("Segoe UI", 11.25F);
            trigerPageButton.ForeColor = SystemColors.ControlLightLight;
            trigerPageButton.Image = Properties.Resources.triger_page_icon32;
            trigerPageButton.ImageAlign = ContentAlignment.MiddleLeft;
            trigerPageButton.Location = new Point(0, 141);
            trigerPageButton.Name = "trigerPageButton";
            trigerPageButton.Padding = new Padding(10, 0, 0, 0);
            trigerPageButton.Size = new Size(204, 50);
            trigerPageButton.TabIndex = 3;
            trigerPageButton.Text = "Тригер";
            trigerPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            trigerPageButton.UseVisualStyleBackColor = true;
            trigerPageButton.Click += trigerPageButton_Click;
            // 
            // colorDetectorPageButton
            // 
            colorDetectorPageButton.Dock = DockStyle.Top;
            colorDetectorPageButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            colorDetectorPageButton.FlatStyle = FlatStyle.Flat;
            colorDetectorPageButton.Font = new Font("Segoe UI", 11.25F);
            colorDetectorPageButton.ForeColor = SystemColors.ControlLightLight;
            colorDetectorPageButton.Image = Properties.Resources.color_page_icon32;
            colorDetectorPageButton.ImageAlign = ContentAlignment.MiddleLeft;
            colorDetectorPageButton.Location = new Point(0, 91);
            colorDetectorPageButton.Name = "colorDetectorPageButton";
            colorDetectorPageButton.Padding = new Padding(10, 0, 0, 0);
            colorDetectorPageButton.Size = new Size(204, 50);
            colorDetectorPageButton.TabIndex = 2;
            colorDetectorPageButton.Text = "Детектор цвета";
            colorDetectorPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            colorDetectorPageButton.UseVisualStyleBackColor = true;
            colorDetectorPageButton.Click += colorDetectorPageButton_Click;
            // 
            // clickerPageButton
            // 
            clickerPageButton.Dock = DockStyle.Top;
            clickerPageButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            clickerPageButton.FlatStyle = FlatStyle.Flat;
            clickerPageButton.Font = new Font("Segoe UI", 11.25F);
            clickerPageButton.ForeColor = SystemColors.ControlLightLight;
            clickerPageButton.Image = Properties.Resources.clicker_page_icon32;
            clickerPageButton.ImageAlign = ContentAlignment.MiddleLeft;
            clickerPageButton.Location = new Point(0, 41);
            clickerPageButton.Name = "clickerPageButton";
            clickerPageButton.Padding = new Padding(10, 0, 0, 0);
            clickerPageButton.Size = new Size(204, 50);
            clickerPageButton.TabIndex = 1;
            clickerPageButton.Text = "Кликер";
            clickerPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clickerPageButton.UseVisualStyleBackColor = true;
            clickerPageButton.Click += clickerPageButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(49, 49, 49);
            panelLogo.Controls.Add(title);
            panelLogo.Controls.Add(logoPictureBox);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(204, 41);
            panelLogo.TabIndex = 0;
            panelLogo.MouseDown += Form1_MouseDown;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 11F);
            title.ForeColor = Color.White;
            title.Location = new Point(47, 13);
            title.Name = "title";
            title.Size = new Size(119, 20);
            title.TabIndex = 1;
            title.Text = "AdvancedClicker";
            title.MouseDown += Form1_MouseDown;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackgroundImage = Properties.Resources.newlogobg;
            logoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            logoPictureBox.Location = new Point(8, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(33, 33);
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            logoPictureBox.MouseDown += Form1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 49);
            panel1.Controls.Add(closeFormButton);
            panel1.Controls.Add(pinnFormButton);
            panel1.Controls.Add(minimizeFormButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(204, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 41);
            panel1.TabIndex = 6;
            panel1.MouseDown += Form1_MouseDown;
            // 
            // pinnFormButton
            // 
            pinnFormButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pinnFormButton.BackgroundImage = Properties.Resources.form_not_pinned_icon;
            pinnFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            pinnFormButton.FlatAppearance.BorderSize = 0;
            pinnFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            pinnFormButton.FlatStyle = FlatStyle.Flat;
            pinnFormButton.Location = new Point(553, 5);
            pinnFormButton.Name = "pinnFormButton";
            pinnFormButton.Size = new Size(32, 32);
            pinnFormButton.TabIndex = 2;
            toolTip1.SetToolTip(pinnFormButton, "Закрепить окно поверх\r\nвсех других окон");
            pinnFormButton.UseVisualStyleBackColor = true;
            pinnFormButton.Click += pinnFormButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(204, 41);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(700, 480);
            mainPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(904, 521);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Advanced Clicker";
            MouseDown += Form1_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button closeFormButton;
        private Button minimizeFormButton;
        private Panel panelMenu;
        private Button clickerPageButton;
        private Panel panelLogo;
        private Button trigerPageButton;
        private Button colorDetectorPageButton;
        private Button settingsPageButton;
        private Panel panel1;
        private Panel mainPanel;
        private PictureBox logoPictureBox;
        private Label title;
        private Button pinnFormButton;
        private ToolTip toolTip1;
    }
}

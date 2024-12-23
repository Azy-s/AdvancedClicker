namespace AdvancedClicker.Forms.InternalForms
{
    partial class EditPoint
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
            numericTextBox1 = new CustomModules.NumericTextBox();
            numericTextBox2 = new CustomModules.NumericTextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            delayAfterClick = new Label();
            numericTextBox3 = new CustomModules.NumericTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // numericTextBox1
            // 
            numericTextBox1.BackColor = Color.FromArgb(65, 65, 65);
            numericTextBox1.BorderStyle = BorderStyle.FixedSingle;
            numericTextBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            numericTextBox1.ForeColor = Color.White;
            numericTextBox1.Location = new Point(24, 35);
            numericTextBox1.MaxLength = 4;
            numericTextBox1.Name = "numericTextBox1";
            numericTextBox1.Size = new Size(51, 27);
            numericTextBox1.TabIndex = 0;
            numericTextBox1.Text = "0";
            numericTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // numericTextBox2
            // 
            numericTextBox2.BackColor = Color.FromArgb(65, 65, 65);
            numericTextBox2.BorderStyle = BorderStyle.FixedSingle;
            numericTextBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            numericTextBox2.ForeColor = Color.White;
            numericTextBox2.Location = new Point(103, 35);
            numericTextBox2.MaxLength = 4;
            numericTextBox2.Name = "numericTextBox2";
            numericTextBox2.Size = new Size(51, 27);
            numericTextBox2.TabIndex = 1;
            numericTextBox2.Text = "0";
            numericTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(8, 40);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(87, 40);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 2;
            label2.Text = "Y";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(65, 65, 65);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.ForeColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Left", "Right", "Middle" });
            comboBox1.Location = new Point(173, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 25);
            comboBox1.TabIndex = 3;
            // 
            // delayAfterClick
            // 
            delayAfterClick.AutoSize = true;
            delayAfterClick.ForeColor = SystemColors.Control;
            delayAfterClick.Location = new Point(23, 75);
            delayAfterClick.Name = "delayAfterClick";
            delayAfterClick.Size = new Size(131, 15);
            delayAfterClick.TabIndex = 2;
            delayAfterClick.Text = "Задержка после клика";
            // 
            // numericTextBox3
            // 
            numericTextBox3.BackColor = Color.FromArgb(65, 65, 65);
            numericTextBox3.BorderStyle = BorderStyle.FixedSingle;
            numericTextBox3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            numericTextBox3.ForeColor = Color.White;
            numericTextBox3.Location = new Point(24, 93);
            numericTextBox3.MaxLength = 9;
            numericTextBox3.Name = "numericTextBox3";
            numericTextBox3.Size = new Size(130, 27);
            numericTextBox3.TabIndex = 4;
            numericTextBox3.Text = "0";
            numericTextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(157, 99);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 2;
            label3.Text = "мс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(24, 9);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 5;
            label4.Text = "Координаты мыши";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(173, 9);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 5;
            label5.Text = "Кнопка мыши";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 65, 65);
            button1.DialogResult = DialogResult.OK;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(188, 94);
            button1.Name = "button1";
            button1.Size = new Size(93, 25);
            button1.TabIndex = 6;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 82);
            ClientSize = new Size(297, 137);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericTextBox3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(delayAfterClick);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericTextBox2);
            Controls.Add(numericTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditPoint";
            Text = "EditPoint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomModules.NumericTextBox numericTextBox1;
        private CustomModules.NumericTextBox numericTextBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label delayAfterClick;
        private CustomModules.NumericTextBox numericTextBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
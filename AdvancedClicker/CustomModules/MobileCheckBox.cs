using AdvancedClicker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedClicker.CustomModules
{
    [DesignerCategory("Code")]
    [ToolboxBitmap(typeof(MobileCheckBox), "MobileCheckBox.bmp")]
    internal class MobileCheckBox : CheckBox
    {
        private Color _backColor = Color.FromArgb(82, 82, 82);

        [Category("Appearance")]
        [Description("The background color of the control.")]
        public Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; Invalidate(); }
        }

        public MobileCheckBox() 
        {
            this.Appearance = Appearance.Button;
            this.AutoSize = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.CheckedBackColor = BackColor;
            this.FlatAppearance.MouseDownBackColor = BackColor;
            this.FlatAppearance.MouseOverBackColor = BackColor;
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.White;
            this.Image = Properties.Resources.checkbox_off_darkicon;
            this.Location = new Point(28, 175);
            this.Size = new Size(50, 28);
            this.TabIndex = 9;
            this.UseVisualStyleBackColor = true;
            this.Text = "";
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked)
                this.Image = Resources.checkbox_on_darkicon;
            else
                this.Image = Resources.checkbox_off_darkicon;

            base.OnCheckedChanged(e);
        }
    }
}

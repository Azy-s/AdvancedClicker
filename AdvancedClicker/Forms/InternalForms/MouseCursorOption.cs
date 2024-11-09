using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class MouseCursorOption : Form
    {
        private ColorDetectorPage _mainForm;
        public MouseCursorOption(ColorDetectorPage mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public bool IsAimMode()
        {
            return aimModeCheckbox.Checked;
        }

        public bool IsColorInCenter()
        {
            return isColorInCenterCheckBox.Checked;
        }

        private void chooseRadiusButton_Click(object sender, EventArgs e)
        {
            using (MouseRadiusSelector mouseRadiusSelector = new MouseRadiusSelector())
            {
                var result = mouseRadiusSelector.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _mainForm.PointsToSearch = mouseRadiusSelector.GetPoints();
                    _mainForm.ScreenArea = mouseRadiusSelector.GetArea();
                    mouseRadiusSelector.Dispose();
                }
            }
        }

        private void roundTrackBar1_Scroll(object sender, EventArgs e)
        {
            smoothnessValue.Text = (roundTrackBar1.Value / 10.0f).ToString();
            _mainForm.Smoothness = roundTrackBar1.Value / 10.0f;
        }

        private void mobileCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            roundTrackBar1.Enabled = aimModeCheckbox.Checked;
            smoothnessLabel.Enabled = aimModeCheckbox.Checked;
            smoothnessValue.Enabled = aimModeCheckbox.Checked;
        }

        private void roundTrackBar1_EnabledChanged(object sender, EventArgs e)
        {
            if (roundTrackBar1.Enabled)
                roundTrackBar1.ElipseColor = ThemeColors.AccentColor;
            else
                roundTrackBar1.ElipseColor = Color.Gray;
        }
    }
}

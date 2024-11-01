using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClicker.Forms
{
    public partial class PickColorFromImage : Form
    {
        public Color Result { get; private set; }
        private float _zoomFactor = 1.0f;
        private float oldZoomFactor = 1.0f;
        private Point _mouseDownLocation;
        private Point mousePos;
        public PickColorFromImage()
        {
            InitializeComponent();
            Result = Color.FromArgb(0, 0, 0);
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите изображение";
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                // Показываем диалоговое окно и проверяем, что пользователь выбрал файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем изображение в PictureBox
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    _zoomFactor = Math.Min((float)(pictureBox1.Width) / pictureBox1.Image.Width, (float)(pictureBox1.Height) / pictureBox1.Image.Height);
                }
                openFileDialog.Dispose();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus(); // Ensure the PictureBox has focus to receive mouse wheel events
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.Delta > 0)
                {

                    oldZoomFactor = _zoomFactor;
                    _zoomFactor += 0.1f;
                }
                else if (e.Delta < 0)
                {
                    oldZoomFactor = _zoomFactor;
                    _zoomFactor = Math.Max(0.1f, _zoomFactor - 0.1f);
                }
                pictureBox1.Width = (int)(_zoomFactor * pictureBox1.Image.Width);
                pictureBox1.Height = (int)(_zoomFactor * pictureBox1.Image.Height);

                pictureBox1.Left = (int)(mousePos.X - (_zoomFactor / oldZoomFactor) * (mousePos.X - pictureBox1.Left));
                pictureBox1.Top = (int)(mousePos.Y - (_zoomFactor / oldZoomFactor) * (mousePos.Y - pictureBox1.Top));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Left += e.X - _mouseDownLocation.X;
                pictureBox1.Top += e.Y - _mouseDownLocation.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = ScreenCapture.GetPixel(MouseControl.GetPosition());
            Result = panel2.BackColor;
        }

        private void PickColorFromImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Dispose();
            this.Dispose();
        }
    }
}

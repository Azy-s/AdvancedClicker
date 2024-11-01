using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class ScreenAreaSelector : Form
    {
        private Bitmap _screen;
        private Bitmap _filteredScreen;
        private Bitmap _editedImage;
        private Point _currentMousePos;
        private DateTime _lastMouseMoveTime;
        private int _interval = 30;
        public Rectangle ResultData { get; private set; }

        private int _topLeftX = 0;
        private int _topLeftY = 0;
        public ScreenAreaSelector(Bitmap bitmap)
        {
            InitializeComponent();
            _screen = new Bitmap(bitmap);

            _filteredScreen = ApplyColorFilter(bitmap, Color.White, 0.4f);
            _editedImage = new Bitmap(_filteredScreen);
            pictureBox1.Image = _editedImage;
            pictureBox2.Image = _filteredScreen;
            pictureBox1.BackColor = Color.Orange;
            pictureBox2.BackColor = Color.Black;
            this.AllowTransparency = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public static Bitmap ApplyColorFilter(Bitmap image, Color filterColor, float overlayAmount)
        {
            // Проверка значения overlayAmount
            overlayAmount = Math.Max(0, Math.Min(1, overlayAmount));

            // Создаем матрицу коррекции цвета
            float[][] colorMatrixElements = {
            new float[] {1 - overlayAmount, 0, 0, 0, 0},
            new float[] {0, 1 - overlayAmount, 0, 0, 0},
            new float[] {0, 0, 1 - overlayAmount, 0, 0},
            new float[] {overlayAmount * filterColor.R / 255f, overlayAmount * filterColor.G / 255f, overlayAmount * filterColor.B / 255f, 1, 0},
            new float[] {0, 0, 0, 0, 1}
        };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            // Создаем объект ImageAttributes и устанавливаем для него матрицу коррекции цвета
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Создаем новое изображение с такими же размерами, как оригинал
            Bitmap filteredBitmap = new Bitmap(image.Width, image.Height);

            // Используем Graphics для отрисовки изображения с применением матрицы коррекции цвета
            using (Graphics g = Graphics.FromImage(filteredBitmap))
            {
                g.DrawImage(
                    image,
                    new Rectangle(0, 0, image.Width, image.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes
                );
            }

            return filteredBitmap;
        }
        private bool mouseDown = false;
        private Point mouseFirstPos = new Point();
        private async void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseFirstPos = new Point(e.X, e.Y);
            _lastMouseMoveTime = DateTime.Now;
            await Task.Delay(0);
        }

        private async void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
                return;
            if (e.X - mouseFirstPos.X == 0 || e.Y - mouseFirstPos.Y == 0)
                return;
            if ((DateTime.Now - _lastMouseMoveTime).TotalMilliseconds < _interval)
            {
                return;
            }
            _lastMouseMoveTime = DateTime.Now;

            if (e.X < mouseFirstPos.X)
                _topLeftX = e.X;
            else
                _topLeftX = mouseFirstPos.X;

            if (e.Y < mouseFirstPos.Y)
                _topLeftY = e.Y;
            else
                _topLeftY = mouseFirstPos.Y;

            using (Graphics g = Graphics.FromImage(_editedImage))
            {
                g.DrawImage(_filteredScreen, 0, 0);
                Rectangle selectionRect = new Rectangle(_topLeftX, _topLeftY, Math.Abs(e.X - mouseFirstPos.X), Math.Abs(e.Y - mouseFirstPos.Y));
                g.DrawImage(_screen, selectionRect, selectionRect, GraphicsUnit.Pixel);
                //g.DrawImage(filteredScreen, new Rectangle(mouseFirstPos.X, e.Y, selectionRect.Width+10, 10), new Rectangle(mouseFirstPos.X, e.Y, selectionRect.Width+10, 10), GraphicsUnit.Pixel);
                //g.DrawImage(filteredScreen, new Rectangle(e.X, mouseFirstPos.Y, 10, selectionRect.Height), new Rectangle(e.X, mouseFirstPos.Y, 10, selectionRect.Height), GraphicsUnit.Pixel);
                using (Pen redPen = new Pen(Color.Red))
                {
                    g.DrawRectangle(redPen, selectionRect);
                }
                pictureBox1.Invalidate();
            }
            await Task.Delay(1);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.ResultData = new Rectangle(_topLeftX, _topLeftY, Math.Abs(e.X - mouseFirstPos.X), Math.Abs(e.Y - mouseFirstPos.Y));
            this.DialogResult = DialogResult.OK;
        }

        private void ScreenAreaSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            _screen.Dispose();
            _filteredScreen.Dispose();
            _editedImage.Dispose();
            pictureBox1.Image.Dispose();
            pictureBox2.Image.Dispose();
        }
    }
}

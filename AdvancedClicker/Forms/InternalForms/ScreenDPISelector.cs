using AdvancedClicker.Properties;
using System.Data;
using System.Media;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class ScreenDPISelector : Form
    {
        public List<Point> Points = new List<Point>();
        private Point _density = new Point(10, 10);
        private PointF _scaleRatio;
        private float _zoomFactor = 1.0f;
        private float _oldZoomFactor = 1.0f;
        private Point _mouseDownLocation;
        private Point _mousePos;
        private Bitmap _image;
        private double _densityY = 0.1;
        private double _densityX = 0.1;
        private DateTime _lastMouseMoveTime;
        private int _interval = 30;

        public ScreenDPISelector(Bitmap bitmapImage)
        {
            InitializeComponent();
            this.KeyPreview = true;
            _image = bitmapImage;
            pictureBox1.Image = new Bitmap(bitmapImage);
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            //bmp.SetPixel((int)(e.X * (_image.Width / (double)pictureBox1.Width)), (int)(e.Y * (_image.Height / (double)pictureBox1.Height)), Color.Red);

            _scaleRatio.X = _image.Width / (float)pictureBox1.Width;
            _scaleRatio.Y = _image.Height / (float)pictureBox1.Height;
            _zoomFactor = 1.0f / Math.Max(_scaleRatio.X, _scaleRatio.Y);
            pictureBox1.Width = (int)(_zoomFactor * pictureBox1.Image.Width);
            pictureBox1.Height = (int)(_zoomFactor * pictureBox1.Image.Height);
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.Delta > 0)
                {

                    _oldZoomFactor = _zoomFactor;
                    _zoomFactor += 0.1f;
                }
                else if (e.Delta < 0)
                {
                    _oldZoomFactor = _zoomFactor;
                    _zoomFactor = Math.Max(0.1f, _zoomFactor - 0.1f);
                }
                pictureBox1.Width = (int)(_zoomFactor * pictureBox1.Image.Width);
                pictureBox1.Height = (int)(_zoomFactor * pictureBox1.Image.Height);

                pictureBox1.Left = (int)(_mousePos.X - (_zoomFactor / _oldZoomFactor) * (_mousePos.X - pictureBox1.Left));
                pictureBox1.Top = (int)(_mousePos.Y - (_zoomFactor / _oldZoomFactor) * (_mousePos.Y - pictureBox1.Top));
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
            if ((DateTime.Now - _lastMouseMoveTime).TotalMilliseconds < _interval)
            {
                return;
            }
            _lastMouseMoveTime = DateTime.Now;

            _mousePos = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Left += e.X - _mouseDownLocation.X;
                pictureBox1.Top += e.Y - _mouseDownLocation.Y;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus(); // Ensure the PictureBox has focus to receive mouse wheel events
        }

        private async void DPITrackBarX_Scroll(object sender, EventArgs e)
        {
            _density.X = DPITrackBarX.Value;
            _densityX = DPITrackBarX.Value / 100.0;

            GeneratePointsSquare(Points, _image.Width, _image.Height, _densityX, _densityY);
            DrawPointsOnScreen(_image, Points);
            await Task.Delay(1);
        }

        private async void DPITrackBarY_Scroll(object sender, EventArgs e)
        {
            _density.X = DPITrackBarY.Value;
            _densityY = DPITrackBarY.Value / 100.0;
            // Получаем точки
            
            GeneratePointsSquare(Points, _image.Width, _image.Height, _densityX, _densityY);
            DrawPointsOnScreen(_image, Points);

            await Task.Delay(1);
        }

        private void DrawPointsOnScreen(Bitmap image, List<Point> points)
        {
            //pictureBox1.Image.Dispose();
            int dotFickness = 2;
            if (_densityX > 0.5 || _densityY > 0.5)
                dotFickness = 1;


            Bitmap bmp = (Bitmap)image.Clone();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Brush brush = new SolidBrush(chooseColorButton.BackColor);
                foreach (Point point in points)
                {
                    g.FillRectangle(brush, point.X, point.Y, dotFickness, dotFickness);
                }
            }
            pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp;
        }

        public static void GeneratePointsSquare(List<Point> points, double width, double height, double densityX, double densityY)
        {
            // Рассчитываем количество точек по горизонтали и вертикали
            int numPointsX = (int)(width * densityX);
            int numPointsY = (int)(height * densityY);

            if (points.Count > numPointsX*numPointsY)
            {
                points.RemoveRange(numPointsX * numPointsY, points.Count - numPointsX * numPointsY);
            }

            // Рассчитываем шаг между точками
            double stepX = numPointsX > 1 ? ((width - 1) / (numPointsX - 1)) : width - 1;
            double stepY = numPointsY > 1 ? ((height - 1) / (numPointsY - 1)) : height - 1;

            // Генерируем точки
            for (int i = 0; i < numPointsX; i++)
            {
                for (int j = 0; j < numPointsY; j++)
                {
                    int pointX = (int)(i * stepX);
                    int pointY = (int)(j * stepY);
                    
                    if (i * numPointsY + j < points.Count)
                    {
                        points[i * numPointsY + j] = new Point(pointX, pointY);
                    }
                    else
                    {
                        points.Add(new Point(pointX, pointY));
                    }
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right != e.Button)
                return;
            if (!customPointsCheckbox.Checked)
                return;

            _scaleRatio.X = _image.Width / (float)pictureBox1.Width;
            _scaleRatio.Y = _image.Height / (float)pictureBox1.Height;

            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            pictureBox1.Image.Dispose();
            bmp.SetPixel((int)(e.X * _scaleRatio.X), (int)(e.Y * _scaleRatio.Y), chooseColorButton.BackColor);
            pictureBox1.Image = bmp;

            Points.Add(new Point((int)(e.X * _scaleRatio.X), (int)(e.Y * _scaleRatio.Y)));
            listBox1.Items.Add("(" + Points.Last().X + ";" + Points.Last().Y + ")");

        }

        private void mobileCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = customPointsCheckbox.Checked;
            DPITrackBarX.Enabled = !customPointsCheckbox.Checked;
            DPITrackBarY.Enabled = !customPointsCheckbox.Checked;
            listBox1.Items.Clear();
            Points.Clear();
            pictureBox1.Image = new Bitmap(_image);
            toolTip1.Show("aaaaa", this, customPointsCheckbox.Location);
        }

        private void ScreenDPISelector_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = (int)(_zoomFactor * pictureBox1.Image.Width);
            pictureBox1.Height = (int)(_zoomFactor * pictureBox1.Image.Height);

            //pictureBox1.Invalidate();
        }

        private void DPITrackBar_EnabledChanged(object sender, EventArgs e)
        {
            RoundTrackBar roundTrackBar = (RoundTrackBar)sender;
            if (roundTrackBar.Enabled)
            {
                roundTrackBar.StartColor = Color.Lime;
                roundTrackBar.EndColor = Color.Red;
                roundTrackBar.ElipseColor = Color.Gainsboro;
            }
            else
            {
                roundTrackBar.StartColor = Color.DimGray;
                roundTrackBar.EndColor = Color.DimGray;
                roundTrackBar.ElipseColor = Color.DarkGray;
            }
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Установка начального цвета
                colorDialog.FullOpen = true;
                colorDialog.Color = ((Button)sender).BackColor;
                // Открытие диалога и проверка результата
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((Button)sender).BackColor = colorDialog.Color;
                    if (colorDialog.Color.R + colorDialog.Color.G + colorDialog.Color.B > 350)
                        ((Button)sender).BackgroundImage = Resources.colorpicker_black_icon;
                    else
                        ((Button)sender).BackgroundImage = Resources.colorpicker_white_icon;

                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Загружаем изображение
            Image img = pictureBox1.Image;

            if (img != null)
            {
                // Отключаем интерполяцию и сглаживание
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

                // Выводим изображение без сглаживания
                e.Graphics.DrawImage(img, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            }
        }

        private void ScreenDPISelector_KeyDown(object sender, KeyEventArgs e)
        {
            //Проверяем, нажаты ли CTRL и Z одновременно
            if (e.Control && e.KeyCode == Keys.Z)
            {
                // Удаляем последний добавленный пиксель
                if (Points.Count > 0)
                {
                    Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
                    bmp.SetPixel(Points[Points.Count - 1].X, Points[Points.Count - 1].Y,
                        _image.GetPixel(Points[Points.Count - 1].X, Points[Points.Count - 1].Y));
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = bmp;
                    Points.RemoveAt(Points.Count - 1);
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            bmp.SetPixel(Points[listBox1.SelectedIndex].X, Points[listBox1.SelectedIndex].Y,
                _image.GetPixel(Points[listBox1.SelectedIndex].X, Points[listBox1.SelectedIndex].Y));
            pictureBox1.Image = bmp;
            Points.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}

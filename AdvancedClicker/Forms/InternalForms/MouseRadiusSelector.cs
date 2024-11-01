using AdvancedClicker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClicker.Forms.InternalForms
{
    public partial class MouseRadiusSelector : Form
    {
        private List<Point> _points = new List<Point>();
        private Bitmap _screen;
        private Point _screenArea;
        private PointF _scaleRatio;
        private float _zoomFactor = 1.0f;
        private float _oldZoomFactor = 1.0f;
        private Point _mouseDownLocation;
        private Point _mousePos;
        private DateTime _lastPointsGenerated;
        private int _interval = 30;
        private int _radius = 30;
        private int _pointsCount = 10;

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20; // Значение атрибута для темного режима (в Windows 10 1809 и выше)

        [DllImport("dwmapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        public MouseRadiusSelector()
        {
            InitializeComponent();
            ApplyDarkModeToWindow(Handle);

            Screen screen = Screen.FromControl(this);

            _screen = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
            _screenArea.X = _screen.Width;
            _screenArea.Y = _screen.Height;
            using (Graphics g = Graphics.FromImage(_screen))
                g.Clear(Color.FromArgb(65, 65, 65));

            DrawMesureLines(_screen);
            pictureBox1.Image = (Bitmap)_screen.Clone();

            _scaleRatio.X = _screen.Width / (float)pictureBox1.Width;
            _scaleRatio.Y = _screen.Height / (float)pictureBox1.Height;
            _zoomFactor = 1.0f / Math.Max(_scaleRatio.X, _scaleRatio.Y);
            pictureBox1.Width = (int)(_zoomFactor * pictureBox1.Image.Width);
            pictureBox1.Height = (int)(_zoomFactor * pictureBox1.Image.Height);

            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            pictureBox1.AllowDrop = true;

            radiusTrackbar.Maximum = Math.Min(_screen.Width, _screen.Height) / 2 - 1;
        }

        public List<Point> GetPoints()
        {
            for (int i = 0; i < _points.Count; i++)
            {
                Point p = _points[i];
                _points[i] = new Point(p.X - _screenArea.X/2, p.Y - _screenArea.Y/2); //transform coordinates to mouse offset
            }
            return _points;
        }

        public Point GetArea()
        {
            return new Point(_radius * 2, _radius * 2);
        }

        private void DrawMesureLines(Bitmap image)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                Pen p = new Pen(Color.FromArgb(200, 200, 200));
                g.DrawLine(p, image.Width / 2.0f, 0, image.Width / 2.0f, image.Height - 1);
                g.DrawLine(p, 0, image.Height / 2.0f, image.Width - 1, image.Height / 2.0f);
                for (int i = image.Width / 2 + 100; i < image.Width; i += 100)
                {
                    g.DrawLine(p, i, image.Height / 2 - 15, i, image.Height / 2 + 15);
                    g.DrawString((i - (image.Width / 2)).ToString(), new Font("Segoe UI", 11F), new SolidBrush(Color.LightGray), new Point(i - 15, image.Height / 2 + 20));
                }
                for (int i = image.Width / 2 - 100; i > 0; i -= 100)
                {
                    g.DrawLine(p, i, image.Height / 2 - 15, i, image.Height / 2 + 15);
                    g.DrawString(Math.Abs((i - (image.Width / 2))).ToString(), new Font("Segoe UI", 11F), new SolidBrush(Color.LightGray), new Point(i - 15, image.Height / 2 + 20));
                }
                for (int i = image.Height / 2 + 100; i < image.Height; i += 100)
                {
                    g.DrawLine(p, image.Width / 2 - 15, i, image.Width / 2 + 15, i);
                    g.DrawString((i - (image.Height / 2)).ToString(), new Font("Segoe UI", 11F), new SolidBrush(Color.LightGray), new Point(image.Width / 2 + 20, i - 10));
                }
                for (int i = image.Height / 2 - 100; i > 0; i -= 100)
                {
                    g.DrawLine(p, image.Width / 2 - 15, i, image.Width / 2 + 15, i);
                    g.DrawString(Math.Abs(i - (image.Height / 2)).ToString(), new Font("Segoe UI", 11F), new SolidBrush(Color.LightGray), new Point(image.Width / 2 + 20, i - 10));
                }
            }
        }

        private void ApplyDarkModeToWindow(IntPtr handle)
        {
            if (IsWindows10OrGreater(17763)) // Проверка версии Windows 10 (1809)
            {
                int isDarkMode = 1; // Включение темного режима
                DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref isDarkMode, sizeof(int));
            }
        }

        private bool IsWindows10OrGreater(int build = -1)
        {
            Version version = Environment.OSVersion.Version;
            return version.Major >= 10 && version.Build >= build;
        }

        private void radiusTrackbar_Scroll(object sender, EventArgs e)
        {
            if ((DateTime.Now - _lastPointsGenerated).TotalMilliseconds < _interval)
            {
                return;
            }
            _lastPointsGenerated = DateTime.Now;

            radiusTextBox.Text = radiusTrackbar.Value.ToString();
            //_radius = radiusTrackbar.Value;

            //GeneratePointsInCircle(Points, new Point(_screen.Width / 2, _screen.Height / 2), _radius, _pointsCount);

            //DrawPointsOnScreen(_screen, Points);
        }

        private void pointsTrackbar_Scroll(object sender, EventArgs e)
        {
            if ((DateTime.Now - _lastPointsGenerated).TotalMilliseconds < _interval)
            {
                return;
            }
            _lastPointsGenerated = DateTime.Now;

            pointsTextBox.Text = pointsTrackbar.Value.ToString();
            //_pointsCount = pointsTrackbar.Value;
            //GeneratePointsInCircle(Points, new Point(_screen.Width / 2, _screen.Height / 2), _radius, _pointsCount);

            //DrawPointsOnScreen(_screen, Points);
        }

        private void GeneratePointsInCircle(List<Point> points, Point center, int radius, int pointCount)
        {
            if (points.Count > pointCount)
            {
                points.RemoveRange(pointCount, points.Count - pointCount);
            }

            double goldenRatio = (1 + Math.Sqrt(5)) / 2;
            double angleIncrement = 2 * Math.PI / goldenRatio;

            for (int i = 0; i < pointCount; i++)
            {
                double r = radius * Math.Sqrt((double)i / pointCount);
                double theta = angleIncrement * i;

                int x = (int)(center.X + r * Math.Cos(theta));
                int y = (int)(center.Y + r * Math.Sin(theta));

                if (i < points.Count)
                {
                    points[i] = new Point(x, y);
                }
                else
                {
                    points.Add(new Point(x, y));
                }
            }
        }

        private void DrawPointsOnScreen(Bitmap image, List<Point> points)
        {
            int dotFickness = 3;

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
            if ((DateTime.Now - _lastPointsGenerated).TotalMilliseconds < _interval)
            {
                return;
            }
            _lastPointsGenerated = DateTime.Now;

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
                    DrawPointsOnScreen(_screen, _points);
                }
            }
        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            radiusTrackbar.Value = (radiusTextBox.GetNumber() > radiusTrackbar.Maximum) ? radiusTrackbar.Maximum :
                (radiusTextBox.GetNumber() < radiusTrackbar.Minimum) ? radiusTrackbar.Minimum : radiusTextBox.GetNumber();
            _radius = radiusTextBox.GetNumber();

            GeneratePointsInCircle(_points, new Point(_screen.Width / 2, _screen.Height / 2), _radius, _pointsCount);

            DrawPointsOnScreen(_screen, _points);

            switch (_radius)
            {
                case int n when n <= 150:
                    radiusTextBox.ForeColor = Color.White;
                    break;
                case int n when n > 150 && n <= 600:
                    radiusTextBox.ForeColor = Utilities.ColorOperations.InterpolateHSL(Color.Yellow, Color.Red, (float)(radiusTrackbar.Value - 150) / (600 - 150));
                    break;
                case int n when n > 600:
                    radiusTextBox.ForeColor = Color.Red;
                    break;
            }

        }

        private void pointsTextBox_TextChanged(object sender, EventArgs e)
        {
            pointsTrackbar.Value = (pointsTextBox.GetNumber() > pointsTrackbar.Maximum) ? pointsTrackbar.Maximum :
                (pointsTextBox.GetNumber() < pointsTrackbar.Minimum) ? pointsTrackbar.Minimum : pointsTextBox.GetNumber();
            _pointsCount = pointsTextBox.GetNumber();

            GeneratePointsInCircle(_points, new Point(_screen.Width / 2, _screen.Height / 2), _radius, _pointsCount);

            DrawPointsOnScreen(_screen, _points);

            if (_pointsCount > 250)
            {
                pointsTextBox.ForeColor = Utilities.ColorOperations.InterpolateHSL(Color.Yellow, Color.Red, (float)(pointsTrackbar.Value-250) / (pointsTrackbar.Maximum-250));
            }

            switch (_pointsCount)
            {
                case int n when n < 250:
                    pointsTextBox.ForeColor = Color.White;
                    break;
                case int n when n > 250 && n < pointsTrackbar.Maximum:
                    pointsTextBox.ForeColor = Utilities.ColorOperations.InterpolateHSL(Color.Yellow, Color.Red, (float)(pointsTrackbar.Value - 250) / (pointsTrackbar.Maximum - 250));
                    break;
                case int n when n > pointsTrackbar.Maximum:
                    pointsTextBox.ForeColor = Color.Red;
                    break;
            }
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем пути к файлам
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                try
                {
                    _screen = new Bitmap(Image.FromFile(files[0]));
                    _screenArea.X = _screen.Width;
                    _screenArea.Y = _screen.Height;
                    pictureBox1.Image = Image.FromFile(files[0]);
                    radiusTrackbar.Maximum = Math.Min(_screen.Width, _screen.Height) / 2;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскиваемый объект — это файл
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Устанавливаем эффект "Копирование"
            }
            else
            {
                e.Effect = DragDropEffects.None; // Запрещаем перетаскивание
            }
        }

        private void MouseRadiusSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            _screen.Dispose();
            pictureBox1.Image.Dispose();
        }
    }
}

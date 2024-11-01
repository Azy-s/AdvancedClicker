using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClicker.Forms
{
    public partial class TestForm : Form
    {
        
        public TestForm()
        {
            InitializeComponent();
            this.AllowTransparency = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            // Радиус круга
            int radius = 120;
            // Количество точек
            int pointCount = int.Parse(textBox1.Text);
            // Центр круга
            Point center = new Point(120, 120); // Вы можете задать свои координаты центра

            // Получаем точки
            List<Point> points = GeneratePointsInCircle2(center, radius, pointCount);
            List<Point> sortedPoints = SortPointsByDistanceFromCenter(points, center);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // Выводим точки
            Graphics g = Graphics.FromImage(bmp);
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            foreach (Point point in points)
            {
                g.FillRectangle(brush, point.X, point.Y, 3, 3);
                richTextBox1.Text += "new Point(" + point.X + ", " + point.Y + "),\n";
            }
            pictureBox1.BackgroundImage = bmp;

        }

        public static List<Point> GeneratePointsInCircle2(Point center, int radius, int pointCount)
        {
            List<Point> points = new List<Point>();

            double goldenRatio = (1 + Math.Sqrt(5)) / 2;
            double angleIncrement = 2 * Math.PI / goldenRatio;

            for (int i = 0; i < pointCount; i++)
            {
                double r = radius * Math.Sqrt((double)i / pointCount);
                double theta = angleIncrement * i;

                int x = (int)(center.X + r * Math.Cos(theta));
                int y = (int)(center.Y + r * Math.Sin(theta));

                points.Add(new Point(x, y));
            }

            return points;
        }

            public static List<Point> GeneratePointsSquare(double width, double height, double density)
            {
                List<Point> points = new List<Point>();

                // Рассчитываем количество точек по горизонтали и вертикали
                int numPointsX = (int)(width * density);
                int numPointsY = (int)(height * density);

                // Рассчитываем шаг между точками
                double stepX = numPointsX > 1 ? width / (numPointsX - 1) : width;
                double stepY = numPointsY > 1 ? height / (numPointsY - 1) : height;

                // Генерируем точки
                for (int i = 0; i < numPointsX; i++)
                {
                    for (int j = 0; j < numPointsY; j++)
                    {
                        int pointX = (int)(i * stepX);
                        int pointY = (int)(j * stepY);
                        points.Add(new Point(pointX, pointY));
                    }
                }

                return points;
            }

        public static List<Point> SortPointsByDistanceFromCenter(List<Point> points, Point center)
        {
            return points.OrderBy(p => CalculateDistance(center, p)).ToList();
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        int radius = 80;
        private async void roundTrackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            // Радиус круга
            radius = int.Parse(roundTrackBar2.Value.ToString());
            // Количество точек
            int pointCount = int.Parse(roundTrackBar1.Value.ToString());
            // Центр круга
            Point center = new Point(200, 200); // Вы можете задать свои координаты центра

            // Получаем точки
            //List<Point> points = GeneratePointsInCircle2(center, radius, pointCount);
            List<Point> points = GeneratePointsSquare(radius*2, radius*2, pointCount / 1600.0);
            List<Point> sortedPoints = SortPointsByDistanceFromCenter(points, center);
            sortedPoints = points;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // Выводим точки
            Graphics g = Graphics.FromImage(bmp);
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            foreach (Point point in points)
            {
                g.FillRectangle(brush,radius + point.X,radius + point.Y, 3, 3);
                //richTextBox1.Text += "new Point(" + point.X + ", " + point.Y + "),\n";
            }
            pictureBox1.BackgroundImage = bmp;
            await Task.Delay(0);
        }

        private async void roundTrackBar2_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            // Радиус круга
            radius = int.Parse(roundTrackBar2.Value.ToString());
            // Количество точек
            int pointCount = int.Parse(roundTrackBar1.Value.ToString());
            // Центр круга
            Point center = new Point(200, 200); // Вы можете задать свои координаты центра

            // Получаем точки
            List<Point> points = GeneratePointsInCircle2(center, radius, pointCount);
            List<Point> sortedPoints = SortPointsByDistanceFromCenter(points, center);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // Выводим точки
            Graphics g = Graphics.FromImage(bmp);
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            foreach (Point point in points)
            {
                g.FillRectangle(brush, point.X, point.Y, 3, 3);
                //richTextBox1.Text += "new Point(" + point.X + ", " + point.Y + "),\n";
            }
            pictureBox1.BackgroundImage = bmp;
            await Task.Delay(0);
        }
    }
}

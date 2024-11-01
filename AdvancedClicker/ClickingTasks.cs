using AdvancedClicker.Data;
using AdvancedClicker.Forms;
using AdvancedClicker.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowsInput;

namespace AdvancedClicker
{
    public class ClickingTasks
    {
        //standart windows timer is ~15ms, so it's imposible to make 1-14ms delay, only 0, 15, 30 and so on
        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", ExactSpelling = true)]
        private static extern uint TimeBeginPeriod(uint uPeriod);

        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", ExactSpelling = true)]
        private static extern uint TimeEndPeriod(uint uPeriod);



        private delegate void ClickMouse(Point coords);
        public static async Task MouseClicker(CancellationToken cancellationToken, Data.ClickData clickData)
        {
            ClickMouse clickMouse = MouseControl.LeftClick;

            switch (((int)clickData.MouseButton))
            {
                case 0:
                    clickMouse = MouseControl.LeftClick;
                    break;
                case 1:
                    clickMouse = MouseControl.RightClick;
                    break;
                case 2:
                    clickMouse = MouseControl.MiddleClick;
                    break;
            }

            //sets windows timer to 1ms
            TimeBeginPeriod(1);
            int clickCounter = 0;
            Random random = new Random(DateTime.Today.Millisecond);

            while (!cancellationToken.IsCancellationRequested)
            {
                if (!clickData.IsMouseCoordEnabled) 
                    clickData.MouseCoords = MouseControl.GetPosition();

                clickMouse(clickData.MouseCoords);

                if (clickData.IsClickLimitEnabled)
                {
                    clickCounter++;
                    if (clickCounter > clickData.ClickCountLimit)
                        break;
                }


                await Task.Delay(clickData.ClickDelay);
                if (clickData.IsRandomEnabled)
                    await Task.Delay(random.Next(clickData.ClickRandomDelay));
            }
            TimeEndPeriod(1);
        }

        public static async void ColorDetectionTask(CancellationToken cancellationToken, Data.ColorDetectData data)
        {
            ClickMouse clickMouse = MouseControl.LeftClick;

            switch (((int)data.MouseButton))
            {
                case 0:
                    clickMouse = MouseControl.LeftClick;
                    break;
                case 1:
                    clickMouse = MouseControl.RightClick;
                    break;
                case 2:
                    clickMouse = MouseControl.MiddleClick;
                    break;
            }
            TimeBeginPeriod(1);

            if (!data.FolowMouseCursor)
            {
                Bitmap screen = new Bitmap(data.AreaWidth, data.AreaHeight);

                while (!cancellationToken.IsCancellationRequested)
                {
                    screen = ScreenCapture.CaptureScreenArea(data.ScreenPosX, data.ScreenPosY, data.AreaWidth, data.AreaHeight);
                    bool colorFound = false;
                    foreach (Point point in data.Points)
                    {
                        if (data.IsSolidColor)
                            colorFound = ColorOperations.IsColorInRange(screen.GetPixel(point.X, point.Y), data.SolidColors, data.Offset);
                        else
                            colorFound = ColorOperations.IsColorInGradientRange(screen.GetPixel(point.X, point.Y), data.ColorGradient1, data.ColorGradient2, data.Offset);

                        if (colorFound)
                        {
                            MouseControl.SetPosition(data.ScreenPosX + point.X, data.ScreenPosY + point.Y);
                            Task.Delay(1);
                            clickMouse(new Point(data.ScreenPosX + point.X, data.ScreenPosY + point.Y));
                            break;
                        }
                    }
                    screen.Dispose();
                }
            }
            else
            {
                Bitmap screen = new Bitmap(data.AreaWidth, data.AreaHeight);
                Point mouseCords = new Point();
                InputSimulator simulator = new InputSimulator();

                while (!cancellationToken.IsCancellationRequested)
                {
                    mouseCords = MouseControl.GetPosition();
                    screen = ScreenCapture.CaptureScreenArea(mouseCords.X - data.AreaWidth/2, mouseCords.Y - data.AreaHeight / 2, data.AreaWidth, data.AreaHeight);
                    bool colorFound = false;
                    foreach (Point point in data.Points)
                    {
                        if (data.IsSolidColor)
                            colorFound = ColorOperations.IsColorInRange(screen.GetPixel(screen.Width/2 + point.X, screen.Height/2 + point.Y), data.SolidColors, data.Offset);
                        else
                            colorFound = ColorOperations.IsColorInGradientRange(screen.GetPixel(screen.Width/2 + point.X, screen.Height/2 + point.Y), data.ColorGradient1, data.ColorGradient2, data.Offset);

                        if (colorFound)
                        {
                            simulator.Mouse.MoveMouseBy((int)Math.Round(point.X / data.Smoothness), (int)Math.Round(point.Y / data.Smoothness));
                            Task.Delay(1);
                            //simulator.Mouse.LeftButtonClick();
                            //Task.Delay(5);
                            if (point.X == 0 && point.Y == 0)
                                simulator.Mouse.LeftButtonClick();
                            break;
                        }
                    }
                    screen.Dispose();
                }
            }
            
            TimeEndPeriod(1);
        }
    }
}

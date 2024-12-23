using AdvancedClicker.Data;
using AdvancedClicker.Forms;
using AdvancedClicker.Utilities;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.UserDataAccounts.SystemAccess;
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

        private delegate void ClickMouse(Point p);
        private delegate void ButtonDown();
        private delegate void ButtonUp();
        private static void nullAction() { }
        private static void nullActionPoint(Point point) 
        {
            MouseControl.SetPosition(point);
        }

        private delegate void ClickMouseCords(Point coords);
        public static async Task MouseClicker(CancellationToken cancellationToken, Data.ClickData clickData)
        {
            ClickMouse clickMouse = MouseControl.LeftClick;

            clickMouse =
                            ((int)MouseButtons.Left == (int)clickData.MouseButton) ? MouseControl.LeftClick :
                            ((int)MouseButtons.Right == (int)clickData.MouseButton) ? MouseControl.RightClick :
                            ((int)MouseButtons.Middle == (int)clickData.MouseButton) ? MouseControl.MiddleClick :
                            nullActionPoint;

            //sets windows timer to 1ms
            TimeBeginPeriod(1);
            int clickCounter = 0;
            Random random = new Random(DateTime.Today.Millisecond);

            while (!cancellationToken.IsCancellationRequested)
            {
                if (clickData.IsMouseCoordEnabled)
                {
                    foreach (ClickPoint point in clickData.ClickPoints)
                    {
                        if (cancellationToken.IsCancellationRequested)
                            break;

                        clickMouse =
                            ((int)MouseButtons.Left == (int)point.MouseButton) ? MouseControl.LeftClick :
                            ((int)MouseButtons.Right == (int)point.MouseButton) ? MouseControl.RightClick :
                            ((int)MouseButtons.Middle == (int)point.MouseButton) ? MouseControl.MiddleClick :
                            nullActionPoint;

                        clickMouse(point.MouseCoords);

                        if (clickData.IsClickLimitEnabled)
                        {
                            clickCounter++;
                            if (clickCounter > clickData.ClickCountLimit)
                                break;
                        }

                        await Task.Delay(clickData.ClickDelay);
                        if (clickData.IsRandomEnabled)
                            await Task.Delay(random.Next(clickData.ClickRandomDelay));
                        await Task.Delay(point.DelayAfterClick);
                    }
                }
                else
                {
                    clickMouse(MouseControl.GetPosition());

                    await Task.Delay(clickData.ClickDelay);
                    if (clickData.IsRandomEnabled)
                        await Task.Delay(random.Next(clickData.ClickRandomDelay));

                    if (clickData.IsClickLimitEnabled)
                    {
                        clickCounter++;
                        if (clickCounter > clickData.ClickCountLimit)
                            break;
                    }
                }
            }
            TimeEndPeriod(1);
        }

        public static async void ColorDetectionTask(CancellationToken cancellationToken, Data.ColorDetectData data)
        {
            
            InputSimulator simulator = new InputSimulator();
            ButtonDown buttonDown = MouseControl.LeftDown;
            ButtonUp buttonUp = MouseControl.LeftUp;
            Random random = new Random(DateTime.Today.Millisecond);
            
            switch (((int)data.MouseButton))
            {
                case 0:
                    buttonDown = nullAction;
                    buttonUp = nullAction;
                    break;
                case 0x00100000:
                    buttonDown = MouseControl.LeftDown;
                    buttonUp = MouseControl.LeftUp;
                    break;
                case 0x00200000:
                    buttonDown = MouseControl.RightDown;
                    buttonUp = MouseControl.RightUp;
                    break;
                case 0x00400000:
                    buttonDown = MouseControl.MiddleDown;
                    buttonUp = MouseControl.MiddleUp;
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
                            colorFound = ColorOperations.IsColorInRange(screen.GetPixel(point.X, point.Y), data.SolidColors, data.ColorOffset);
                        else
                            colorFound = ColorOperations.IsColorInGradientRange(screen.GetPixel(point.X, point.Y), data.ColorGradient1, data.ColorGradient2, data.ColorOffset);

                        if (colorFound)
                        {
                            MouseControl.SetPosition(data.ScreenPosX + point.X, data.ScreenPosY + point.Y);

                            buttonDown();

                            if (data.HoldButtonTime + data.RandomHoldButtonTime > 0)
                                Thread.Sleep(data.HoldButtonTime + random.Next(data.RandomHoldButtonTime));

                            buttonUp();

                            if (data.RandomDelayAfterCLick + data.DelayAfterClick > 0)
                                Thread.Sleep(data.DelayAfterClick + random.Next(data.RandomDelayAfterCLick));
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

                while (!cancellationToken.IsCancellationRequested)
                {
                    mouseCords = MouseControl.GetPosition();
                    screen = ScreenCapture.CaptureScreenArea(mouseCords.X - data.AreaWidth/2, mouseCords.Y - data.AreaHeight / 2, data.AreaWidth, data.AreaHeight);
                    bool colorFound = false;
                    foreach (Point point in data.Points)
                    {
                        if (data.IsSolidColor)
                            colorFound = ColorOperations.IsColorInRange(screen.GetPixel(screen.Width/2 + point.X, screen.Height/2 + point.Y), data.SolidColors, data.ColorOffset);
                        else
                            colorFound = ColorOperations.IsColorInGradientRange(screen.GetPixel(screen.Width/2 + point.X, screen.Height/2 + point.Y), data.ColorGradient1, data.ColorGradient2, data.ColorOffset);

                        if (colorFound)
                        {
                            if (data.IsAimMode)
                            {
                                simulator.Mouse.MoveMouseBy((int)Math.Round(point.X / data.Smoothness), (int)Math.Round(point.Y / data.Smoothness));
                            }
                            //simulator.Mouse.LeftButtonClick();
                            //Task.Delay(5);
                            if (!(point.X == 0 && point.Y == 0) && data.IsColorInCenter)
                                break;
                            
                            buttonDown();

                            if (data.HoldButtonTime + data.RandomHoldButtonTime > 0)
                                Thread.Sleep(data.HoldButtonTime + random.Next(data.RandomHoldButtonTime));
                            
                            buttonUp();
                            if (data.RandomDelayAfterCLick + data.DelayAfterClick > 0)
                                Thread.Sleep(data.DelayAfterClick + random.Next(data.RandomDelayAfterCLick));
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

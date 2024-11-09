using System.Runtime.InteropServices;

namespace AdvancedClicker
{
    public class MouseControl
    {
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        // Константы для mouse_event
        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const uint MOUSEEVENTF_ABSOLUTE = 0x8000;

        public static Point GetPosition()
        {
            Point point;
            GetCursorPos(out point);
            return point;
        }

        public static void SetPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetPosition(Point position)
        {
            SetCursorPos(position.X, position.Y);
        }

        public static void LeftClick()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)point.X, (uint)point.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void LeftClick(Point position)
        {
            SetCursorPos(position.X, position.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)position.X, (uint)position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)position.X, (uint)position.Y, 0, 0);
        }

        public static void LeftDown()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void LeftUp()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void RightClick()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)point.X, (uint)point.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void RightClick(Point position)
        {
            SetCursorPos(position.X, position.Y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)position.X, (uint)position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, (uint)position.X, (uint)position.Y, 0, 0);
        }

        public static void RightDown()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void RightUp()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_RIGHTUP, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void MiddleClick()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, (uint)point.X, (uint)point.Y, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void MiddleClick(Point position)
        {
            SetCursorPos(position.X, position.Y);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, (uint)position.X, (uint)position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, (uint)position.X, (uint)position.Y, 0, 0);
        }

        public static void MiddleDown()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, (uint)point.X, (uint)point.Y, 0, 0);
        }

        public static void MiddleUp()
        {
            Point point = GetPosition();
            mouse_event(MOUSEEVENTF_MIDDLEUP, (uint)point.X, (uint)point.Y, 0, 0);
        }
    }
}

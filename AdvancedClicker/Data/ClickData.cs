namespace AdvancedClicker.Data
{
    public enum MouseButton
    {
        Left,
        Right,
        Middle
    }

    public struct ClickData
    {
        public int ClickDelay { get; set; }        // ms

        public bool IsRandomEnabled { get; set; }
        public int ClickRandomDelay { get; set; }  // ms

        public bool IsClickLimitEnabled { get; set; }
        public int ClickCountLimit { get; set; }

        public MouseButton MouseButton { get; set; }

        public bool IsMouseCoordEnabled { get; set; }
        public Point MouseCoords { get; set; }


        public ClickData(int clickDelay = 5, bool isRandomEnabled = false, int clickRandomDelay = 0, bool isClickLimitEnabled = false, int clickCountLimit = 0, MouseButton mouseButton = MouseButton.Left, bool isMouseCoordEnabled = false, Point mouseCoords = new Point())
        {
            ClickDelay = clickDelay;
            IsRandomEnabled = isRandomEnabled;
            ClickRandomDelay = clickRandomDelay;
            IsClickLimitEnabled = isClickLimitEnabled;
            ClickCountLimit = clickCountLimit;
            MouseButton = mouseButton;
            IsMouseCoordEnabled = isMouseCoordEnabled;
            MouseCoords = mouseCoords;
        }
    }
}

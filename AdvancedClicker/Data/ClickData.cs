namespace AdvancedClicker.Data
{
    public struct ClickPoint
    {
        public Point MouseCoords { get; set; }
        public MouseButtons MouseButton { get; set; }
        public int DelayAfterClick { get; set; }
    }
    public struct ClickData
    {
        public int ClickDelay { get; set; }        // ms

        public bool IsRandomEnabled { get; set; }
        public int ClickRandomDelay { get; set; }  // ms

        public bool IsClickLimitEnabled { get; set; }
        public int ClickCountLimit { get; set; }

        public MouseButtons MouseButton { get; set; }

        public bool IsMouseCoordEnabled { get; set; }
        public Point MouseCoords { get; set; }

        public List<ClickPoint> ClickPoints { get; set; }


        public ClickData(List<ClickPoint> clickPoints, int clickDelay = 5, bool isRandomEnabled = false, int clickRandomDelay = 0, bool isClickLimitEnabled = false, int clickCountLimit = 0, MouseButtons mouseButton = MouseButtons.Left, bool isMouseCoordEnabled = false, Point mouseCoords = new Point())
        {
            this.ClickPoints = clickPoints;
            this.ClickDelay = clickDelay;
            this.IsRandomEnabled = isRandomEnabled;
            this.ClickRandomDelay = clickRandomDelay;
            this.IsClickLimitEnabled = isClickLimitEnabled;
            this.ClickCountLimit = clickCountLimit;
            this.MouseButton = mouseButton;
            this.IsMouseCoordEnabled = isMouseCoordEnabled;
            this.MouseCoords = mouseCoords;
        }
    }
}

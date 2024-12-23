namespace AdvancedClicker.Data
{
    public struct ColorDetectData
    {
        public Color ColorGradient1 { get; set; }
        public Color ColorGradient2 { get; set; }
        public List<Color> SolidColors { get; set; }
        public int ColorOffset { get; set; }  

        public bool IsGradient { get; set; }
        public bool IsSolidColor { get; set; }

        public List<Point> Points { get; set; }

        public MouseButtons MouseButton { get; set; }
        public bool FolowMouseCursor { get; set; }
        public float Smoothness { get; set; }
        public int ScreenPosX { get; set; }
        public int ScreenPosY { get; set; }
        public int AreaWidth { get; set; }
        public int AreaHeight { get; set; }
        public bool IsAimMode {  get; set; }
        public bool IsColorInCenter { get; set; }
        public int DelayAfterClick { get; set; }
        public int RandomDelayAfterCLick { get; set; }
        public int HoldButtonTime { get; set; }
        public int RandomHoldButtonTime { get; set; }


        public ColorDetectData(Color colorGradient1, Color colorGradient2, List<Color> solidColors, List<Point> points, int offset = 0, bool isGradient = false, bool isSolidColor = false,
            MouseButtons button = MouseButtons.Left, bool folowMouseCursor = false,
            int screenPosX = 0, int screenPosY = 0, int areaWidth = 0, int areaheight = 0, float smooothness = 1,
            bool isAimMode = true, int delayAfterClick = 0, int randomDelayAfterClick = 0, int holdButtonTime = 0, int randomHoldButtonTIme = 0, bool isColorInCenter = true)
        {
            this.ColorGradient1 = colorGradient1;
            this.ColorGradient2 = colorGradient2;
            this.SolidColors = solidColors;
            this.ColorOffset = offset;
            this.IsGradient = isGradient;
            this.IsSolidColor = isSolidColor;
            this.MouseButton = button;
            this.Points = points;
            this.FolowMouseCursor = folowMouseCursor;
            this.ScreenPosX = screenPosX;
            this.ScreenPosY = screenPosY;
            this.AreaWidth = areaWidth;
            this.AreaHeight = areaheight;
            this.Smoothness = smooothness;
            this.IsAimMode = isAimMode;
            this.DelayAfterClick = delayAfterClick;
            this.RandomDelayAfterCLick = randomDelayAfterClick;
            this.HoldButtonTime = holdButtonTime;
            this.RandomHoldButtonTime = randomHoldButtonTIme;
            this.IsColorInCenter = isColorInCenter;
        }

    }
}

namespace AdvancedClicker.Data
{
    public struct ColorDetectData
    {
        public Color ColorGradient1 { get; set; }
        public Color ColorGradient2 { get; set; }
        public List<Color> SolidColors { get; set; }
        public int Offset { get; set; }  

        public bool IsGradient { get; set; }
        public bool IsSolidColor { get; set; }

        public List<Point> Points { get; set; }

        public MouseButton MouseButton { get; set; }
        public bool FolowMouseCursor { get; set; }
        public float Smoothness { get; set; }
        public int ScreenPosX { get; set; }
        public int ScreenPosY { get; set; }
        public int AreaWidth { get; set; }
        public int AreaHeight { get; set; }

        public ColorDetectData(Color colorGradient1, Color colorGradient2, List<Color> solidColors = null, int offset = 0, bool isGradient = false, bool isSolidColor = false,
            MouseButton button = MouseButton.Left, List<Point> points = null, bool folowMouseCursor = false,
            int screenPosX = 0, int screenPosY = 0, int areaWidth = 0, int areaheight = 0, float smooothness = 1)
        {
            ColorGradient1 = colorGradient1;
            ColorGradient2 = colorGradient2;
            SolidColors = solidColors;
            Offset = offset;
            IsGradient = isGradient;
            IsSolidColor = isSolidColor;
            MouseButton = button;
            Points = points;
            FolowMouseCursor = folowMouseCursor;
            ScreenPosX = screenPosX;
            ScreenPosY = screenPosY;
            AreaWidth = areaWidth;
            AreaHeight = areaheight;
            Smoothness = smooothness;
        }

    }
}

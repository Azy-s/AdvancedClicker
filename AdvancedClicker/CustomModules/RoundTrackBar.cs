using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace AdvancedClicker
{
    [DesignerCategory("Code")]
    [ToolboxBitmap(typeof(RoundTrackBar), "RoundTrackBar.bmp")]
    public class RoundTrackBar : TrackBar
    {
        private bool _mouseDown = false;
        private Color _startColor = Color.DarkGray;
        private Color _middleColor;
        private Color _endColor = Color.DarkGray;
        private Color _elipseColor = ThemeColors.AccentColor;
        private int _elipseRadius = 10;
        public RoundTrackBar()
        {
            // Установка стилей для пользовательского рисования
            SetStyle(ControlStyles.UserPaint |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer, true);
            
        }
        [Category("Appearance")]
        [Description("The starting color of the gradient for the thumb.")]
        public Color StartColor
        {
            get { return _startColor; }
            set { _startColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The ending color of the gradient for the thumb.")]
        public Color EndColor
        {
            get { return _endColor; }
            set { _endColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The color for elipse")]
        public Color ElipseColor
        {
            get { return _elipseColor; }
            set { _elipseColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Elipse radius")]
        public int ElipseRadius
        {
            get { return _elipseRadius; }
            set { _elipseRadius = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Настраиваем графику
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Рисуем канал
            _middleColor = Utilities.ColorOperations.InterpolateHSL(_startColor, _endColor, 0.5f);
            Rectangle channelRect = new Rectangle(_elipseRadius, ClientSize.Height / 2 - 2, (ClientSize.Width) / 2, 4);
            Brush gradienBrush = new LinearGradientBrush(channelRect, _startColor, _middleColor, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(gradienBrush, channelRect);

            channelRect = new Rectangle((ClientSize.Width) / 2 + _elipseRadius/2 + 4, ClientSize.Height / 2 - 2, (ClientSize.Width / 2 - (_elipseRadius * 2)), 4);
            gradienBrush = new LinearGradientBrush(channelRect, _middleColor, _endColor, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(gradienBrush, channelRect);

            // Размеры и положение ползунка
            int trackX = (int)Math.Round(((float)(Value - Minimum) / (Maximum - Minimum)) * (ClientSize.Width - _elipseRadius * 2));
            Rectangle thumbRect = new Rectangle(trackX, ClientSize.Height / 2 - (_elipseRadius), _elipseRadius*2, _elipseRadius*2);

            Brush brush = new SolidBrush(_elipseColor);
            // Рисуем ползунок (круг)
            e.Graphics.FillEllipse(brush, thumbRect);
        }

        protected override void OnScroll(EventArgs e)
        {
            base.OnScroll(e);
            this.Invalidate(); // Перерисовка после скроллинга
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _mouseDown = true;
            UpdateValue(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_mouseDown)
            {
                UpdateValue(e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _mouseDown = false;
        }

        private void UpdateValue(MouseEventArgs e)
        {
            int newValue = Minimum + (int)Math.Round(((float)(Maximum - Minimum) * (e.X - _elipseRadius)) / (ClientSize.Width - _elipseRadius * 2));
            if (newValue < Minimum)
            {
                newValue = Minimum;
            }
            if (newValue > Maximum)
            {
                newValue = Maximum;
            }
            if (newValue != Value)
            {
                Value = newValue;
                OnScroll(EventArgs.Empty); // Вызываем событие Scroll
            }
            
            Invalidate(); // Перерисовываем контрол
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Перерисовываем контрол при изменении размера
        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            Invalidate();
        }

    }
}

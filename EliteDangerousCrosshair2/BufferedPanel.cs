using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EliteDangerousCrosshair2
{
    internal sealed class BufferedPanel : Panel
    {
        private static Rectangle _rEllipse;
        private static Pen _outline = new Pen(Color.Red);
        private int _yDraw;
        private int _yScreen;
        private int _circleDim;
        private bool _programFocus;
        private int _xDraw;
        private int _xScreen;
        private Graphics _g;

        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            CircleDim = 50;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }

        public void SetColor(Color color)
        {
            _outline.Color = color;
            Invalidate();
        }

        public int CircleDim
        {
            get { return _circleDim; }
            set
            {
                if (_circleDim != value)
                {
                    _circleDim = value;
                    Invalidate();
                }
            }
        }

        public int YDraw
        {
            get { return _yDraw; }
            set
            {
                if (_yDraw != value)
                {
                    _yDraw = value;
                    Invalidate();
                }
            }
        }

        public int XDraw
        {
            get { return _xDraw; }
            set
            {
                if (_xDraw != value)
                {
                    _xDraw = value;
                    Invalidate();
                }
            }
        }

        public int YScreen
        {
            get { return _yScreen; }
            set
            {
                if (_yScreen != value)
                {
                    _yScreen = value;
                    Invalidate();
                }
            }
        }

        public int XScreen
        {
            get { return _xScreen; }
            set
            {
                if (_xScreen != value)
                {
                    _xScreen = value;
                    Invalidate();
                }
            }
        }

        public bool ProgramFocus
        {
            get { return _programFocus; }
            set
            {
                if (_programFocus != value)
                {
                    _programFocus = value;
                    Invalidate();
                }
            }
        }

        public bool Activate { get; set; }

        public void SetLineThickness(int i)
        {
            _outline.Width = i;
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            if (!ProgramFocus || !Activate) return;
            _g = e.Graphics;
            _rEllipse = new Rectangle {Width = CircleDim, Height = CircleDim};
            Width = XScreen;
            Height = YScreen;
            _rEllipse.X = (XScreen/2) - (_rEllipse.Width/2);
            _rEllipse.Y = (YScreen/2) - (_rEllipse.Height/2);


            _g.DrawEllipse(_outline, _rEllipse);

            base.OnPaint(e);
            Thread.Sleep(300);
        }

    }
}
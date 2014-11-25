using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EliteDangerousCrosshair2
{
    public partial class InvisibleForm : Form
    {
        private readonly BackgroundWorker _locationUpdate;
        private IntPtr _gameId;
        private bool _showScreen;
        private WindowLocation _windowLocation;
        private int _lineThickness;

        public InvisibleForm()
        {
            InitializeComponent();


            CircleDem = 50;
            _locationUpdate = new BackgroundWorker();
            _locationUpdate.DoWork += _DoWork;
        }

        public void SetOpacity(double d)
        {
            Opacity = d;
        }

        public WindowLocation GameWindowLocation
        {
            get { return _windowLocation; }
            set
            {
                if (_windowLocation == null)
                {
                    _windowLocation = value;
                    Invoke(new MethodInvoker(ChangeLocation));
                }
                if (!_windowLocation.Equals(value))
                {
                    _windowLocation = value;
                    Invoke(new MethodInvoker(ChangeLocation));
                }
            }
        }

        public bool ShowScreen
        {
            get { return _showScreen; }
            set
            {
                if (_showScreen != value)
                {
                    _showScreen = value;
                    Invoke(value ? new MethodInvoker(Show) : Hide);
                }
            }
        }

        public void EnableNubs(bool b)
        {
            bufferedPanel1.NubsActivated = b;
        }

        public void SetLineThickness(int i)
        {
            _lineThickness = i;
            bufferedPanel1.SetLineThickness(_lineThickness);
        }


        private bool _programFocus;

        public bool ProgramFocus
        {
            get { return _programFocus;  }
            set
            {
                if (_programFocus != value)
                {
                    _programFocus = value;
                    bufferedPanel1.ProgramFocus = value;
                    if (_programFocus)
                    {
                        Invoke(new MethodInvoker(ChangeLocation));
                    }
                }
            }
        }

        public IntPtr GameId
        {
            get { return _gameId; }
            set
            {
                if (_gameId != value)
                {
                    _gameId = value;
                    if (ShowScreen)
                    {
                        Invoke(new MethodInvoker(Show));
                    }
                }
            }
        }

        private int _circleDem;

        public int CircleDem
        {
            get { return _circleDem;  }
            set
            {
                if (_circleDem != value)
                {
                    _circleDem = value;
                    bufferedPanel1.CircleDim = value;
                }
            }
        }

        //protected override bool ShowWithoutActivation
        //{
            //get { return true; }
        //}

        public void SetColor(Color color)
        {
            bufferedPanel1.SetColor(color);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80000 | 0x20;
                return cp;
            }
        }

        private void ChangeLocation()
        {
            if (!_locationUpdate.IsBusy) _locationUpdate.RunWorkerAsync(GameWindowLocation);
        }


        private void _DoWork(object sender, DoWorkEventArgs e)
        {
            var gwl = (WindowLocation) e.Argument;
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    DesktopLocation = gwl.TopPoint;
                    Width = gwl.Rect.Width;
                    Height = gwl.Rect.Height;
                    bufferedPanel1.XScreen = gwl.Rect.Width;
                    bufferedPanel1.YScreen = gwl.Rect.Height;
                    bufferedPanel1.XDraw = gwl.Rect.Width / 2;
                    bufferedPanel1.YDraw = gwl.Rect.Height / 2;
                }));
            }
            else
            {
                DesktopLocation = gwl.TopPoint;
                Width = gwl.Rect.Width;
                Height = gwl.Rect.Height;
            }
        }

        internal void SetActivate(bool activate)
        {
            Invoke(new MethodInvoker(delegate
            {

                bufferedPanel1.Activate = activate;
                if (ProgramFocus && !activate)
                {
                    bufferedPanel1.Invalidate();
                }
                else if (ProgramFocus && activate)
                {
                    Show();
                    ChangeLocation();
                    bufferedPanel1.Invalidate();
                }
            }));
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace EliteDangerousCrosshair2
{
    public sealed partial class MainForm : Form
    {
        private readonly InvisibleForm _invisibleForm;
        private readonly List<IntPtr> _thisId;
        private bool _activeGameUi;
        private IntPtr _currentId;
        private IntPtr _gameId;
        private WindowLocation _windowLocation;
        private readonly KeyboardHook _hook = new KeyboardHook();
        private bool _activate;

        public new bool Activate
        {
            get { return _activate; }
            set
            {
                if (_activate != value)
                {
                    _activate = value;
                    _invisibleForm.SetActivate(Activate);
                }
            }
        }


        public MainForm()
        {
            InitializeComponent();

            if (!IsHandleCreated) CreateHandle();

            _thisId = new List<IntPtr>();

            _invisibleForm = new InvisibleForm();

            AddThisId(_invisibleForm.Handle);
            Activate = true;


            var monitorFocus = new Thread(MonitorFocus) {IsBackground = true};
            monitorFocus.Start();

            var monitorGame = new Thread(MonitorGameStatus) {IsBackground = true};
            monitorGame.Start();
            
            AddThisId(Process.GetCurrentProcess().MainWindowHandle);
            AddThisId(Handle);


            _hook.KeyPressed +=
                hook_KeyPressed;
            // register the control + shift + F12 combination as hot key.
            _hook.RegisterHotKey((ModifierKeys)2 | (ModifierKeys)4, Keys.F1);

            InitComboBox();
        }

        private void InitComboBox()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxLineThickness.Items.Add(i.ToString());
            }

            comboBoxLineThickness.SelectedIndex = 1;
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            Activate = !Activate;
        }

        private WindowLocation GameWindowLocation
        {
            get { return _windowLocation; }
            set
            {
                if (_windowLocation == null || !_windowLocation.Equals(value))
                {
                    _windowLocation = value;
                    _invisibleForm.GameWindowLocation = GameWindowLocation;
                }
            }
        }

        public bool ActiveGameUi
        {
            get { return _activeGameUi; }
            set
            {
                if (_activeGameUi != value)
                {
                    _activeGameUi = value;
                    //Invoke(new MethodInvoker(delegate { label1.Text = value.ToString(); }));
                    _invisibleForm.ShowScreen = value;
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
                    Invoke(_gameId.ToInt32() == 0
                        ? new MethodInvoker(delegate
                        {
                            labelGameStatus.Text = "Game Not Found!";
                            labelGameStatus.ForeColor = ForeColor;
                        })
                        : delegate
                        {
                            labelGameStatus.Text = "Game Found!";
                            labelGameStatus.ForeColor = Color.Green;
                            _invisibleForm.Hide();
                        });
                }
            }
        }

        private IntPtr CurrentId
        {
            set
            {
                if (_currentId != value)
                {
                    _currentId = value;
                    
                    if (((value == GameId) || _thisId.Contains(value)) && GameId.ToInt32() != 0)
                    {
                        ActiveGameUi = true;
                        _invisibleForm.GameId = GameId;
                        _invisibleForm.ProgramFocus = true;
                    }
                    else
                    {
                        ActiveGameUi = false;
                        _invisibleForm.ProgramFocus = false;
                    }
                }
            }
        }

        private void AddThisId(IntPtr add)
        {
            if (!_thisId.Contains(add))
            {
                _thisId.Add(add);
            }
        }

        private void MonitorFocus()
        {
            while (true)
            {
                CurrentId = GameMonitor.GetForegroundWindow();
                Thread.Sleep(100);
            }
        }

        private void MonitorGameStatus()
        {
            while (true)
            {
                GameId = GameMonitor.GetSingleProcessByName("EliteDangerous32");
                if (GameId.ToInt32() != 0)
                {
                    var wl = new WindowLocation {Rect = GameMonitor.GetRect(GameId)};
                    GameMonitor.ClientToScreen(GameId, ref wl.TopPoint);
                    if (GameWindowLocation != null)
                    {
                        if (!wl.Equals(GameWindowLocation))
                        {
                            GameWindowLocation = wl;
                        }
                    }
                    else
                    {
                        GameWindowLocation = wl;
                    }
                }
                Thread.Sleep(25);
            }
        }

        public void MonitorGameWindow()
        {
            while (true)
            {
                if (!ActiveGameUi) continue;
                var wl = new WindowLocation {Rect = GameMonitor.GetRect(GameId)};
                GameMonitor.ClientToScreen(GameId, ref wl.TopPoint);
                if (GameWindowLocation != null)
                {
                    if (!wl.Equals(GameWindowLocation))
                    {
                        GameWindowLocation = wl;
                    }
                }
                else
                {
                    GameWindowLocation = wl;
                }
                Thread.Sleep(500);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int size = trackBar1.Value*5;
            label1.Text = "Reticle Size: " + size + "px";
            _invisibleForm.CircleDem = size;
        }

        private void linkUpdateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/RobCubed/EliteDangerousCrosshair/releases";
            try
            {
                Process.Start(url);
            }
            catch (Win32Exception)
            {
                Process.Start(url);
            }
        }

        private void comboBoxLineThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLineThickness.SelectedItem != null)
            {
                Console.WriteLine(comboBoxLineThickness.SelectedItem);
                _invisibleForm.SetLineThickness(Convert.ToInt32(comboBoxLineThickness.SelectedItem));
            }
        }

    }
}
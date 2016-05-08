using System;
using System.Drawing;
using System.Windows.Forms;

namespace HorseTrack.UserControls
{
    public partial class HorseTimer : UserControl
    {
        private const string MASK = @"hh\:mm\:ss";
        private const int TIMER_INTERVAL = 1000;
        private double _ticks = 0;
        private int _index = 0;

        public event EventHandler OnRemoveClicked;

        public event EventHandler OnResetClicked;

        public event EventHandler OnTimerTick;

        public int Ticks
        {
            get { return (int)_ticks; }
            set
            {
                _ticks = value;
                SetLabelText();
                timer1.Enabled = _ticks > 0 && _ticks < 7200;
                if (_ticks == 0 || _ticks >= 7200) return;
                timer1.Start();
            }
        }

        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                lblIndex.Text = _index.ToString();
                btnRemove.Enabled = !(_index == 1);
            }
        }

        public HorseTimer()
        {
            InitializeComponent();
            lblIndex.Text = _index.ToString();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void SetLabelText()
        {
            lblTime.Text = TimeSpan.FromSeconds(_ticks).ToString(MASK);
            if (_ticks < 6600)
            {
                lblTime.ForeColor = SystemColors.ControlText;
                lblTime.BackColor = SystemColors.Control;
            }
            else if (_ticks >= 6600 && _ticks <= 6900)
            {
                lblTime.ForeColor = Color.White;
                lblTime.BackColor = Color.Orange;
            }
            else if (_ticks > 6900)
            {
                lblTime.ForeColor = Color.White;
                lblTime.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            SetLabelText();
            if (_ticks == 7200)
            {
                timer1.Stop();
                return;
            }
            timer1.Start();
            if (OnTimerTick == null) return;
            OnTimerTick(this, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (OnRemoveClicked == null) return;
            OnRemoveClicked(this, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _ticks = 0;
            SetLabelText();
            timer1.Enabled = true;
            timer1.Start();
            if (OnResetClicked == null) return;
            OnResetClicked(this, e);
        }
    }
}
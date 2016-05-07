using System;
using System.Drawing;
using System.Windows.Forms;

namespace HorseTrack.UserControls
{
    public partial class ChannellTimer : UserControl
    {
        private const string MASK = @"hh\:mm\:ss";
        private const int TIMER_INTERVAL = 1000;
        private double _ticks = 0;
        public int Ticks
        {
            get { return (int)_ticks; }
            set
            {
                _ticks = value;
                SetLabelText(_ticks);
                timer1.Enabled = _ticks > 0 && _ticks< 7200;
                if (_ticks == 0 || _ticks >= 7200) return;
                timer1.Start();
            }
        }

        public string ChannelName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public event EventHandler OnTimerStarted;

        public int Index { get; set; }

        public ChannellTimer()
        {
            InitializeComponent();
            timer1.Interval = TIMER_INTERVAL;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Stop();
            lblTime.Text = "00:00:00";
            _ticks = 0;
            lblTime.ForeColor = SystemColors.ControlText;
            lblTime.BackColor = SystemColors.Control;
            timer1.Start();
            if (OnTimerStarted == null) return;
            OnTimerStarted(sender, e);
        }
        
        private void SetLabelText(double ticks)
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
            SetLabelText(_ticks);            
            if (_ticks == 7200)
            {
                timer1.Stop();
                return;
            }
            timer1.Start();
        }
    }
}
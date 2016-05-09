using HorseTrack.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HorseTrack.UserControls
{
    public partial class ChannellTimer : UserControl
    {
        private const string MASK = @"hh\:mm\:ss";
        private ChannelInformation _channelInformation = null;
        private List<HorseTimer> _horseTimers = new List<HorseTimer>();
        private bool _showControls = true;

        public ChannellTimer(ChannelInformation ChannelInfo, DateTime RefTime) : this()
        {
            _channelInformation = ChannelInfo;
            UpdateControl(RefTime);
        }

        public ChannellTimer()
        {
            InitializeComponent();
        }

        public void CollapseControl()
        {
            _showControls = false;
            if (_horseTimers.Count > 1)
            {
                for (int i = 1; i < _horseTimers.Count; i++)
                {
                    _horseTimers[i].Visible = false;
                }
            }
        }

        public event EventHandler OnTimerStarted;

        public event EventHandler OnExpandClicked;

        public event EventHandler OnTimerTick;

        public string ChannelName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public int HorseTimersCount
        {
            get { return _horseTimers.Count; }
        }

        public long[] HorseTimes
        {
            get
            {                
                if(_horseTimers.Count > 0)
                {
                    return _horseTimers.Select(s => s.Ticks).ToArray();
                }
                return new long[] { 0 };
            }            
        }

        public int Index { get; set; }

        private void AddTimer()
        {
            AddTimer(DateTime.MinValue, -1, -1);
        }

        private void AddTimer(DateTime RefTime, int index = -1, long Ticks = -1)
        {
            var horseTimer = new HorseTimer();
            _horseTimers.Add(horseTimer);
            horseTimer.OnRemoveClicked += HorseTimer_OnRemoveClicked;
            horseTimer.OnResetClicked += HorseTimer_OnResetClicked;
            horseTimer.OnTimerTick += HorseTimer_OnTimerTick;
            horseTimersContainer.Controls.Add(horseTimer);
            horseTimer.Index = index == -1 ? _horseTimers.Count : index + 1;
            if (Ticks > 0 && RefTime > DateTime.MinValue)
            {
                var startTime = RefTime.Subtract(TimeSpan.FromSeconds(Ticks));
                var timePassed = TimeSpan.FromTicks(DateTime.Now.Ticks - startTime.Ticks);
                horseTimer.Ticks = (long)timePassed.TotalSeconds;
            }
            ExpandControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_horseTimers.Count == 5)
            {
                MessageBox.Show("You cannot add more than 5 horse timers");
                return;
            }
            AddTimer();
            ChannellTimer_Load(sender, e);
            if (OnTimerStarted == null) return;
            OnTimerStarted(this, e);
        }

        private void ChannellTimer_Load(object sender, EventArgs e)
        {
            horseTimersContainer.Visible = _horseTimers.Count > 0;
        }

        private void ExpandControl()
        {
            _showControls = true;
            if (_horseTimers.Count > 1)
            {
                for (int i = 1; i < _horseTimers.Count; i++)
                {
                    _horseTimers[i].Visible = _showControls;
                }
            }
        }

        private void HorseTimer_OnRemoveClicked(object sender, EventArgs e)
        {
            var clickedControl = (HorseTimer)sender;
            horseTimersContainer.Controls.Remove(clickedControl);
            _horseTimers.Remove(clickedControl);
            for (int i = 0; i < _horseTimers.Count; i++)
            {
                _horseTimers[i].Index = i + 1;
            }
            if (_horseTimers.Count >= 1)
            {
                horseTimersContainer.Visible = true;
                _horseTimers[0].Visible = true;
            }
            else
            {
                horseTimersContainer.Visible = false;
                SetLabelText(0);
            }
        }

        private void HorseTimer_OnResetClicked(object sender, EventArgs e)
        {
            if (OnTimerStarted == null) return;
            OnTimerStarted(sender, e);
        }

        private void HorseTimer_OnTimerTick(object sender, EventArgs e)
        {
            if (_horseTimers.Count <= 0) return;
            SetLabelText(_horseTimers.Max(c => c.Ticks));
            if (OnTimerTick == null) return;
            OnTimerTick(this, e);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (_horseTimers.Count > 1)
            {
                _showControls = !_showControls;
                for (int i = 1; i < _horseTimers.Count; i++)
                {
                    _horseTimers[i].Visible = _showControls;
                }
            }
            OnExpandClicked?.Invoke(this, e);
        }

        private void SetLabelText(double ticks)
        {
            lblCurrentTime.Text = TimeSpan.FromSeconds(ticks).ToString(MASK);
            if (ticks < 6600)
            {
                lblCurrentTime.ForeColor = SystemColors.ControlText;
                lblCurrentTime.BackColor = SystemColors.Control;
            }
            else if (ticks >= 6600 && ticks <= 6900)
            {
                lblCurrentTime.ForeColor = Color.White;
                lblCurrentTime.BackColor = Color.Orange;
            }
            else if (ticks > 6900)
            {
                lblCurrentTime.ForeColor = Color.White;
                lblCurrentTime.BackColor = Color.Red;
            }
        }

        private void UpdateControl(DateTime RefTime)
        {
            if (_channelInformation == null) return;
            lblName.Text = _channelInformation.ChannelName;            
            for (int i = 0; i < _channelInformation.Times.Length; i++)
            {
                if (_channelInformation.Times[i] == 0) continue;
                AddTimer(RefTime, i, _channelInformation.Times[i]);
            }
        }

        private void lblName_MouseEnter(object sender, EventArgs e)
        {
            if (_horseTimers.Count > 1)
            {
                Cursor = Cursors.Hand;
            }
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
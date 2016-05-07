using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HorseTrack.UserControls
{
    public partial class HorseSpot : UserControl
    {
        public string Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public delegate void ClosClicked(object sender, CloseEventArgs e);

        public event ClosClicked OnCloseClicked;

        public event EventHandler OnStartClicked;
        public HorseSpot() : this(DateTime.MinValue, null)
        {

        }

        public HorseSpot(DateTime refTime, int[] timeValues = null)
        {
            InitializeComponent();
            if (timeValues == null) return;
            SetTimes(timeValues, refTime);
        }

        public int[] GetTimes()
        {
            var times = new int[12];
            foreach (ChannellTimer item in channelContainer.Controls)
            {
                times[item.Index] = item.Ticks;
            }
            return times;
        }

        private void SetTimes(int[] timeValues,DateTime refTime)
        {
            foreach (ChannellTimer item in channelContainer.Controls)
            {
                if (timeValues[item.Index] != 0)
                {
                    var startTime = refTime.Subtract(TimeSpan.FromSeconds(timeValues[item.Index]));
                    var timePassed = TimeSpan.FromTicks(DateTime.Now.Ticks - startTime.Ticks);
                    if (timePassed.TotalSeconds >= 7200)
                    {
                        item.Ticks = 7200;
                    }
                    else item.Ticks = (int)timePassed.TotalSeconds; 
                }
                else item.Ticks = timeValues[item.Index];
            }
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (OnCloseClicked == null) return;
            var arg = new CloseEventArgs(Caption);
            OnCloseClicked(this, arg);
        }

        private void ChannelTimerStarted(object sender, EventArgs e)
        {
            if (OnStartClicked == null) return;
            OnStartClicked(sender, e);
        }

    }

    public class CloseEventArgs : EventArgs
    {
        public string ControlName { get; private set; }

        public CloseEventArgs(string controlName)
        {
            ControlName = controlName;
        }
    }
}
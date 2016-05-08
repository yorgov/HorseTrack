using HorseTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HorseTrack.UserControls
{
    public partial class HorseSpot : UserControl
    {
        private List<ChannellTimer> _channels = new List<ChannellTimer>();


        public string Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public delegate void ClosClicked(object sender, CloseEventArgs e);

        public event ClosClicked OnCloseClicked;

        public event EventHandler OnStartClicked;
        public HorseSpot() : this(null)
        {

        }

        public HorseSpot(HorseSpotInformation info = null)
        {
            InitializeComponent();
            AddComponentsForRef();
            if (info == null) return;
            SetTimes(info);
        }

        private void AddComponentsForRef()
        {
            _channels.Add(channellTimer1);
            _channels.Add(channellTimer2);
            _channels.Add(channellTimer3);
            _channels.Add(channellTimer4);
            _channels.Add(channellTimer5);
            _channels.Add(channellTimer6);
            _channels.Add(channellTimer7);
            _channels.Add(channellTimer8);
            _channels.Add(channellTimer9);
            _channels.Add(channellTimer10);
            _channels.Add(channellTimer11);
            _channels.Add(channellTimer12);
        }

        public HorseSpotInformation GetSpotInfo()
        {
            return new HorseSpotInformation
            {
                Name = Caption,
                RefTime = DateTime.Now,
                Channels = _channels.Select(c => new ChannelInformation { ChannelName = c.ChannelName, Times = c.HorseTimes }).ToArray()
            };
        }

        private void SetTimes(HorseSpotInformation Info)
        {
            Caption = Info.Name;
            for (int i = 0; i < _channels.Count; i++)
            {
                _channels[i] = new ChannellTimer(Info.Channels.First(c => c.ChannelName == _channels[i].ChannelName), Info.RefTime);
                _channels[i].OnExpandClicked += channelTimer_OnExpandClicked;
                _channels[i].OnTimerStarted += ChannelTimerStarted;
            }

            //populating the right flowPanel
            tableLayoutPanel2.Controls[1].Controls.Clear();
            tableLayoutPanel2.Controls[1].Controls.AddRange(_channels.Take(6).ToArray());
            //populating the left flowPanel
            tableLayoutPanel2.Controls[0].Controls.Clear();
            tableLayoutPanel2.Controls[0].Controls.AddRange(_channels.Skip(6).Take(6).ToArray());

            //collaps all channel timers except the first
            UpdateChannelCollapse(_channels[0]);            
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (OnCloseClicked == null) return;
            var arg = new CloseEventArgs(Caption);
            OnCloseClicked(this, arg);
        }

        private void ChannelTimerStarted(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(HorseTimer))
            {
                UpdateChannelCollapse((ChannellTimer)sender);
            }
            if (OnStartClicked == null) return;
            OnStartClicked(sender, e);
        }

        private void UpdateChannelCollapse(ChannellTimer sender)
        {
            _channels.ForEach(c =>
            {
                if (!c.Equals(sender))
                {
                    c.CollapseControl();
                }
            });
        }

        private void channelTimer_OnExpandClicked(object sender, EventArgs e)
        {
            _channels.ForEach(c =>
            {
                if (!c.Equals(sender))
                {
                    c.CollapseControl();
                }
            });
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
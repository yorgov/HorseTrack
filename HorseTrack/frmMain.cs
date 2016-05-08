using HorseTrack.Models;
using HorseTrack.UserControls;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HorseTrack
{
    public partial class frmMain : Form
    {
        private static string _appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private const string FILENAME = "hrtt.json";
        private ApplicationInformation _appInfo;
        private string _jsonFile = Path.Combine(_appDataFolder, FILENAME);
        public frmMain()
        {
            InitializeComponent();
            Icon = Properties.Resources._1462723114_timer;

            if (File.Exists(_jsonFile))
            {
                var content = File.ReadAllText(_jsonFile);
                _appInfo =
                 JsonConvert.DeserializeObject<ApplicationInformation>(content);
                _appInfo.FromFile = true;
                textBox1.Text = _appInfo.HorseCount;
            }
            else
            {
                _appInfo = new ApplicationInformation();
                _appInfo.FromFile = false;
            }
            PopulateSpots();
        }

        private void PopulateSpots()
        {
            if (_appInfo.FromFile)
            {
                foreach (var item in _appInfo.SpotsInformation)
                {
                    addNewSpot(item);
                }
            }
        }

        private void addNewSpot(HorseSpotInformation item)
        {
            var newSpot = new HorseSpot(item);
            newSpot.Caption = item.Name;
            newSpot.BorderStyle = BorderStyle.FixedSingle;
            newSpot.OnCloseClicked += horseSpot_OnCloseClicked;
            newSpot.OnStartClicked += horseSpot_OnStartedClicked;

            flowLayoutPanel1.Controls.Add(newSpot);
        }

        private void addNewSpotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new dlgAddNewSpot();
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK)
            {
                addNewSpot(dialog.SpotName);
            }
        }

        private void addNewSpot(string spotName)
        {
            var newSpot = new HorseSpot();
            newSpot.Caption = spotName;
            newSpot.BorderStyle = BorderStyle.FixedSingle;
            newSpot.OnCloseClicked += horseSpot_OnCloseClicked;
            newSpot.OnStartClicked += horseSpot_OnStartedClicked;
            _appInfo.SpotsInformation.Add(new HorseSpotInformation
            {
                Name = spotName                
            });
            flowLayoutPanel1.Controls.Add(newSpot);
        }

        private void horseSpot_OnCloseClicked(object sender, CloseEventArgs e)
        {
            var closingControl = flowLayoutPanel1.Controls.Cast<HorseSpot>().Where(c => c.Caption == e.ControlName).FirstOrDefault();
            if (closingControl != null)
            {
                flowLayoutPanel1.Controls.Remove(closingControl);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void horseSpot_OnStartedClicked(object sender, EventArgs e)
        {
            IncrementTextBox();
        }

        private void IncrementTextBox()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "1";
                return;
            }
            var currenCount = Convert.ToInt64(textBox1.Text);
            textBox1.Text = (currenCount + 1).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)||e.KeyChar == (char)Keys.Back);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_appInfo == null) return;
            if (string.IsNullOrEmpty(_jsonFile)) return;
            try
            {
                _appInfo = new ApplicationInformation();
                _appInfo.HorseCount = textBox1.Text;
                foreach (HorseSpot spot in flowLayoutPanel1.Controls)
                {
                    _appInfo.SpotsInformation.Add(spot.GetSpotInfo());
                }
                File.WriteAllText(_jsonFile, JsonConvert.SerializeObject(_appInfo, Formatting.Indented));
            }
            catch (Exception) { e.Cancel = false; }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using(var about = new About())
            {
                about.ShowDialog(this);
            }
        }
    }
}
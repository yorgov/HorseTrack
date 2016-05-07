using System;
using System.Windows.Forms;

namespace HorseTrack
{
    public partial class dlgAddNewSpot : Form
    {
        public string SpotName
        {
            get;
            private set;
        }

        public dlgAddNewSpot()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("The Name cannot be empty", "Enter A Correct Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            SpotName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
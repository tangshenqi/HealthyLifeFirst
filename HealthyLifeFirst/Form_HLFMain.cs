using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyLifeFirst
{
    public partial class Form_HLFMain : Form
    {
        public Form_HLFMain()
        {
            InitializeComponent();
        }

        public void StatusUpdate(string m)
        {
            lbl_Status_Main.Text = m;
        }

        private void launchDataMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tool_DataMonitor frm = new Form_Tool_DataMonitor();
            frm.Show();
        }
    }
}

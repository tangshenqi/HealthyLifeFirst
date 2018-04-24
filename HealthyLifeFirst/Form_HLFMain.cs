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
            StatusUpdate("Please select an option from the menu to begin.");
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

        private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ItemManagement frm = new Form_ItemManagement(this);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

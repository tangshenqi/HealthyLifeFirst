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
    }
}

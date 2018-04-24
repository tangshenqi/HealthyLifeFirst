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
    public partial class Form_Template_MDIChild : Form
    {
        public Form_Template_MDIChild()
        {
            InitializeComponent();
        }

        #region "Class Methods"
        protected void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.LightSteelBlue);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);

            // Example Implementation
            // grp_Main.Paint += PaintBorderlessGroupBox;
        }
        #endregion
    }

    #region "Extension Classes"
    static class GetCollection
    {
        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TControl>() : Enumerable.Empty<TControl>();
            return children.SelectMany(c => GetChildControls<TControl>(c)).Concat(children);

            // Example Implementation
            // var txt_Coll = this.GetChildControls<TextBox>();
            // foreach (TextBox txt in txt_Coll)
            //     txt.Text = "";
        }
    }
    #endregion
}

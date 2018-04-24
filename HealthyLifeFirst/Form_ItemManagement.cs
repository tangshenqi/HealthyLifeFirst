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
    public partial class Form_ItemManagement : Form_Template_MDIChild
    {
        static Form parent;
        public Form_ItemManagement(Form_HLFMain parent)
        {
            InitializeComponent();

            gbx_SunlightSensitive.Paint += PaintBorderlessGroupBox;
            gbx_CauseDrowsiness.Paint += PaintBorderlessGroupBox;
            gbx_CauseGastric.Paint += PaintBorderlessGroupBox;
            gbx_ByCourse.Paint += PaintBorderlessGroupBox;

            cbx_ItemType.DataSource = new List<string>
                { "Pill", "Tablet", "Suspension", "Solution", 
                    "Drops", "Ointment", "Aerosol", "Inhaler", 
                    "Nebulizer", "Intradermal", "Intravenous", "Cream", 
                    "Gel", "Balm", "Lotion", "Transdermal", 
                    "Powder" };
            cbx_MainCategory.DataSource = new List<string>
                { "Chickenpox", "Cough", "Cold", "Infection",
                    "Diarrhoea", "Vomitting", "Painkiller", "Fever",
                    "Allergy", "Measles", "Mumps", "Constipation" };
            cbx_SubCategory.DataSource = new List<string>
                { "NA", "Ear", "Nose", "Throat",
                    "Eye", "Skin", "General", "Headache",
                    "Asthma", "Eczema", "Food" };
            cbx_DosageFrequency.DataSource = new List<string>
                { "1 TIME AT NIGHT", "1 TIME IN THE MORNING",
                    "2 TIMES A DAY, 8-HOURLY", "3 TIMES A DAY, 6-HOURLY",
                    "4 TIMES A DAY, 4-HOURLY", "5 TIMES A DAY, 4-HOURLY" };

            dgv_ItemManagement.DataSource = Class_Item.GetItemList();

            parent.StatusUpdate("Ready");
        }
    }
}

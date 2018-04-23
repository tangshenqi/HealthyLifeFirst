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
    public partial class Form_Tool_DataMonitor : Form
    {
        static HealthyLifeFirstEntities ctx;
        public Form_Tool_DataMonitor()
        {
            InitializeComponent();

            ctx = new HealthyLifeFirstEntities();

            List<string> TableList = new List<string>()
                { "Appointment", "Case", "Customer",
                    "Employee", "Inventory", "Item",
                    "Leave", "Order", "Prescription",
                    "PrescriptionSet", "Sourcing",
                    "Supplier" };

            cbx_TableSelector.DataSource = TableList;
        }

        private void btn_RefreshDGV_Click(object sender, EventArgs e)
        {
            switch (cbx_TableSelector.Text)
            {
                case "Appointment" : dgv_DisplayRecord.DataSource = ctx.Appointment.ToList(); dgv_DisplayRecord.Columns["Customer"].Visible = false; break;
                case "Case" : dgv_DisplayRecord.DataSource = ctx.Case.ToList(); dgv_DisplayRecord.Columns["Customer"].Visible = false; break;
                case "Customer": dgv_DisplayRecord.DataSource = ctx.Customer.ToList(); dgv_DisplayRecord.Columns["Appointment"].Visible = false; dgv_DisplayRecord.Columns["Case"].Visible = false; break;
                case "Employee": dgv_DisplayRecord.DataSource = ctx.Employee.ToList(); dgv_DisplayRecord.Columns["Leave"].Visible = false; break;
                case "Inventory": dgv_DisplayRecord.DataSource = ctx.Inventory.ToList(); dgv_DisplayRecord.Columns["Item"].Visible = false; break;
                case "Item": dgv_DisplayRecord.DataSource = ctx.Item.ToList(); dgv_DisplayRecord.Columns["Inventory"].Visible = false; dgv_DisplayRecord.Columns["Supplier"].Visible = false; dgv_DisplayRecord.Columns["Order"].Visible = false; dgv_DisplayRecord.Columns["Sourcing"].Visible = false; break;
                case "Leave": dgv_DisplayRecord.DataSource = ctx.Leave.ToList(); dgv_DisplayRecord.Columns["Employee"].Visible = false; break;
                case "Order": dgv_DisplayRecord.DataSource = ctx.Order.ToList(); dgv_DisplayRecord.Columns["Item"].Visible = false; dgv_DisplayRecord.Columns["Supplier"].Visible = false; break;
                case "Prescription": dgv_DisplayRecord.DataSource = ctx.Prescription.ToList(); break;
                case "PrescriptionSet": dgv_DisplayRecord.DataSource = ctx.PrescriptionSet.ToList(); break;
                case "Sourcing": dgv_DisplayRecord.DataSource = ctx.Sourcing.ToList(); dgv_DisplayRecord.Columns["Item"].Visible = false; dgv_DisplayRecord.Columns["Supplier"].Visible = false; break;
                case "Supplier": dgv_DisplayRecord.DataSource = ctx.Supplier.ToList(); dgv_DisplayRecord.Columns["Country"].Visible = false; dgv_DisplayRecord.Columns["Item"].Visible = false; dgv_DisplayRecord.Columns["Order"].Visible = false; dgv_DisplayRecord.Columns["Sourcing"].Visible = false; break;
            } 
        }
    }
}

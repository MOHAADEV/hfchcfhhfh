using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basket
{
    public partial class bil : Form
    {
        public bil()
        {
            InitializeComponent();
        }

        public void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("number", typeof(string));

          /*  while (Program.menu.gir.RowCount > 0)
            {
                dataTable1.Rows.Add(Program.menu.gir.CurrentRow.Cells[0].Value, Program.menu.gir.CurrentRow.Cells[1].Value);
                
            }*/
            // dataTable1.Rows.Add(Program.menu.gir.Rows.Add(), 123);
            dataTable1.Rows.Add("ramez", "192");
            dataTable1.Rows.Add("omar", "32");
            dataTable1.Rows.Add("radwan", "32");
            CrystalReport1 rep = new CrystalReport1();
            rep.Database.Tables["dataTable1"].SetDataSource(dataTable1);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}

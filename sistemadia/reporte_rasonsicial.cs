using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadia
{
    public partial class reporte_rasonsicial : Form
    {
        public reporte_rasonsicial()
        {
            InitializeComponent();
        }
        public List<bControl.reportefacutrclientes> datos = new List<bControl.reportefacutrclientes>();
        private void reporte_rasonsicial_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", datos));
            this.reportViewer1.RefreshReport();
        }
    }
}

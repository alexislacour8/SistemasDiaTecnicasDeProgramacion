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
    public partial class Frm_orden_compra : Form
    {
        public Frm_orden_compra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecion_ordendecompra com = new selecion_ordendecompra();
            int x = dataGridView1.Rows.Add();
            com.ShowDialog();
            foreach (DataGridViewRow item in com.dtView_proveedores.Rows)
            {
                
                if (x >= 0)
                {
                    if (com.DialogResult == DialogResult.OK)
                    {
                        dataGridView1.Rows[x].Cells[0].Value = com.dtView_proveedores.Rows[com.dtView_proveedores.CurrentRow.Index].Cells[0].Value.ToString();
                        dataGridView1.Rows[x].Cells[1].Value = com.dtView_proveedores.Rows[com.dtView_proveedores.CurrentRow.Index].Cells[1].Value.ToString();
                        dataGridView1.Rows[x].Cells[2].Value = com.dtView_proveedores.Rows[com.dtView_proveedores.CurrentRow.Index].Cells[4].Value.ToString();



                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }
    }
}

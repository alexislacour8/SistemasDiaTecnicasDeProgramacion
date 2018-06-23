using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bControl;

namespace sistemadia
{
    public partial class selecion_ordendecompra : Form
    {
        public selecion_ordendecompra()
        {
            InitializeComponent();
        }

        private void selecion_ordendecompra_Load(object sender, EventArgs e)
        {
            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.productostocks();
            dtView_proveedores.DataSource = ds;
            var columnaselecionar = new DataGridViewCheckBoxColumn();
            columnaselecionar.HeaderText = "selecionar";
            columnaselecionar.Name = "selecionar";
            columnaselecionar.ReadOnly = false;
            dtView_proveedores.Columns.AddRange(new DataGridViewColumn[] { columnaselecionar });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            if (dtView_proveedores.SelectedColumns.Count > 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dtView_proveedores_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dtView_proveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtView_proveedores.Columns[e.ColumnIndex].Name == "DISPONIBILIDAD")
            {
                if (Convert.ToInt32(e.Value) <= 800)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;
                    if (Convert.ToInt32(e.Value) <= 200)
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Yellow;
                        if (Convert.ToInt32(e.Value) <= 80)
                        {
                            e.CellStyle.ForeColor = Color.Black;
                            e.CellStyle.BackColor = Color.Red;

                        }

                    }
                }
            }
        }
    }
}

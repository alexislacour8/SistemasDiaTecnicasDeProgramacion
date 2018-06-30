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
    public partial class frm_detalleordencomprafaltante : Form
    {
        public frm_detalleordencomprafaltante(string id_ordencompra)
        {
            InitializeComponent();
            ordencompra = id_ordencompra;
        }
        string ordencompra;
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_relizarnuevaordencompra_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        bControl.OrdenDeCompra orden = new bControl.OrdenDeCompra();
        private void frm_detalleordencomprafaltante_Load(object sender, EventArgs e)
        {
            dtView_detallefaltante.DataSource = orden.obtenerdetalleordencompra(ordencompra);
            dtView_detallefaltante.Columns[0].Visible = false;
        }
        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_detallefaltante.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}

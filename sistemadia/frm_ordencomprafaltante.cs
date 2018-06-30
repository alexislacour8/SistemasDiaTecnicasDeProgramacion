using System;
using System.Windows.Forms;

namespace sistemadia
{
    public partial class frm_ordencomprafaltante : Form
    {
        public frm_ordencomprafaltante()
        {
            InitializeComponent();
        }
        bControl.OrdenDeCompra ordencompra = new bControl.OrdenDeCompra();
        private void frm_ordencomprafaltante_Load(object sender, EventArgs e)
        {
            dtView_ordenesdecomprafaltantes.DataSource = ordencompra.obtenerOrdenesFaltante();
            deshabilitarHeader();
        }
        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_ordenesdecomprafaltantes.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void funcionclick(object sender, DataGridViewCellEventArgs e)
        {
            frm_detalleordencomprafaltante com = new frm_detalleordencomprafaltante(dtView_ordenesdecomprafaltantes.Rows[e.RowIndex].Cells["ID_ORDENCOMPRA"].Value.ToString());

            com.ShowDialog();
            if(com.DialogResult == DialogResult.OK)
            {
                ordencompra.actualizarfaltante(dtView_ordenesdecomprafaltantes.Rows[e.RowIndex].Cells["ID_ORDENCOMPRA"].Value.ToString());
            }
            dtView_ordenesdecomprafaltantes.DataSource = ordencompra.obtenerOrdenesFaltante();
            deshabilitarHeader();

        }
    }
}

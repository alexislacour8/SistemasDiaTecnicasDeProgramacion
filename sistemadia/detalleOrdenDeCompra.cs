using bControl;
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
    public partial class detalleOrdenDeCompra : Form
    {
        public detalleOrdenDeCompra(string id_ordenDeCompra)
        {
            InitializeComponent();
            id_compra = id_ordenDeCompra;
        }
        public string id_compra;
        OrdenDeCompra ordencompra = new OrdenDeCompra();
        private void detalleOrdenDeCompra_Load(object sender, EventArgs e)
        {
            actualizartabla();
        }
        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_DetalleOrdenCompra.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        

        private void actualizartabla()
        {
            DataTable tabla = ordencompra.obtenerdetalleordencompra(id_compra);
            dtView_DetalleOrdenCompra.DataSource = tabla;
            deshabilitarHeader();
            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
            textboxColumn.HeaderText = "CANTIDAD REAL";
            textboxColumn.Name = "CANTIDADREAL";
            textboxColumn.ReadOnly = false;
            dtView_DetalleOrdenCompra.Columns[0].ReadOnly = true;
            dtView_DetalleOrdenCompra.Columns[0].Visible = false;
            dtView_DetalleOrdenCompra.Columns[1].ReadOnly = true;
            dtView_DetalleOrdenCompra.Columns[2].ReadOnly = true;
            dtView_DetalleOrdenCompra.Columns[3].ReadOnly = true;
            dtView_DetalleOrdenCompra.Columns.Add(textboxColumn);
        }

        private void comprobartabla(object sender, DataGridViewCellEventArgs e)
        {
            int trigger = 0 ;
            foreach (DataGridViewRow fila in dtView_DetalleOrdenCompra.Rows)
            {
                if (fila.Cells["CANTIDADREAL"].Value==null || fila.Cells["CANTIDADREAL"].Value.ToString()=="")
                {
                    trigger = trigger+1;
                    break;
                }
                
            }
            if (trigger>0)
            {
                btn_confirmar.Enabled = false;
            }
            else if(trigger==0)
            {
                btn_confirmar.Enabled = true;
            }
            
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            Close();
        }


        

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        
    }
}

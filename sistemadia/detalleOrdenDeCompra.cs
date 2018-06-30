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
            dtView_DetalleOrdenCompra.Columns[1].ReadOnly = true;
            dtView_DetalleOrdenCompra.Columns[2].ReadOnly = true;
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


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        private void dtView_DetalleOrdenCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtView_DetalleOrdenCompra.Columns[e.ColumnIndex].Name == "CANTIDAD")
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

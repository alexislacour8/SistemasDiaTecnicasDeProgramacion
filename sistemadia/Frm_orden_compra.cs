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
    public partial class Frm_orden_compra : Form
    {
        public Frm_orden_compra()
        {
            InitializeComponent();
        }
        bControl.Proveedor proveedor = new bControl.Proveedor();

        DataTable ordencompranuevadatatable = new DataTable();
        

        private void button1_Click(object sender, EventArgs e)
        {
            selecion_ordendecompra com = new selecion_ordendecompra(id_provedor);
           
            com.ShowDialog();
            if (com.DialogResult == DialogResult.OK)
            {
                if (dtView_ordendecompra.Columns.Contains("CANTIDAD")) { 
                    dtView_ordendecompra.Columns.Remove("CANTIDAD");
                }
                if (ordencompranuevadatatable.Columns.Contains("ID_PRODUCTO"))
                {
                    ordencompranuevadatatable.Columns.Clear();
                    ordencompranuevadatatable.Clear();
                }
                ordencompranuevadatatable.Columns.Add("COD_PRODUCTO");
                ordencompranuevadatatable.Columns.Add("PRODUCTO");
                ordencompranuevadatatable.Columns.Add("ID_PRODUCTO");
                ordencompranuevadatatable.Columns[0].ReadOnly = true;
                ordencompranuevadatatable.Columns[1].ReadOnly = true;
                ordencompranuevadatatable.Columns[2].ReadOnly = true;
                deshabilitarHeader();

                foreach (DataGridViewRow item in com.dtView_proveedores.Rows)
                {
                
                
                    
                        if (item.Cells["SELECCIONAR"].Value!=null && (bool)item.Cells["SELECCIONAR"].Value == true) {

                            DataRow[] foundproductoigual = ordencompranuevadatatable.Select("ID_PRODUCTO = '" + item.Cells[0].Value.ToString()+ "'");
                            if (foundproductoigual.Length == 0) { 
                                DataRow nuevoa = ordencompranuevadatatable.NewRow();
                                nuevoa["COD_PRODUCTO"] = item.Cells[4].Value.ToString();
                                nuevoa["PRODUCTO"] = item.Cells[1].Value.ToString();
                                nuevoa["ID_PRODUCTO"] = item.Cells[0].Value.ToString();
                                ordencompranuevadatatable.Rows.Add(nuevoa);
                             }

                        }


                    
                
                }
                dtView_ordendecompra.DataSource = ordencompranuevadatatable;
                dtView_ordendecompra.Columns[2].Visible = false;
                
                if (dtView_ordendecompra.Rows.Count > 0)
                {
                    eliminar.Enabled = true;
                    DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
                    textboxColumn.HeaderText = "CANTIDAD";
                    textboxColumn.Name = "CANTIDAD";
                    textboxColumn.ReadOnly = false;
                    dtView_ordendecompra.Columns.Add(textboxColumn);
                    btn_vender.Enabled = true;

                }
                else
                {
                    btn_vender.Enabled = false;
                    eliminar.Enabled = false;
                    ordencompranuevadatatable.Clear();
                    dtView_ordendecompra.Columns.Clear();
                }
                deshabilitarHeader();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }
        
        private void cmbox_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_provedor = cmbox_proveedores.SelectedValue.ToString();
            btn_agregaproducto.Enabled = true;
            dtView_ordendecompra.Enabled = true;
            dtView_ordendecompra.DataSource = null;
            dtView_ordendecompra.Columns.Clear();
            btn_vender.Enabled = false;
            eliminar.Enabled = false;
            ordencompranuevadatatable.Clear();

        }
        public string id_provedor;

        private void Frm_orden_compra_Load(object sender, EventArgs e)
        {
            cmbox_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbox_proveedores.DataSource = proveedor.obtener_Proveedores();
            cmbox_proveedores.DisplayMember = "NOMBRE";
            cmbox_proveedores.ValueMember = "ID_PROVEDOR";
            id_provedor = cmbox_proveedores.SelectedValue.ToString();
            
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            //falta esta funcionalidad

            dtView_ordendecompra.Rows.RemoveAt(dtView_ordendecompra.CurrentRow.Index);
            if (dtView_ordendecompra.Rows.Count == 0)
            {
                btn_vender.Enabled = false;
                eliminar.Enabled = false;

            }
            else
            {
                btn_vender.Enabled = true;
                eliminar.Enabled = true;
            }

        }

        bControl.OrdenDeCompra conexionordendecompra = new bControl.OrdenDeCompra();
        private void btn_vender_Click(object sender, EventArgs e)
        {
            DataTable tabladetalle=new DataTable();
            tabladetalle.Columns.Add("COD_PRODUCTO");
            tabladetalle.Columns.Add("PRODUCTO");
            tabladetalle.Columns.Add("ID_PRODUCTO");
            tabladetalle.Columns.Add("CANTIDAD");
            foreach (DataGridViewRow item in dtView_ordendecompra.Rows)
            {
                DataRow nuevoa = tabladetalle.NewRow();
                nuevoa["COD_PRODUCTO"] = item.Cells["COD_PRODUCTO"].Value.ToString();
                nuevoa["PRODUCTO"] = item.Cells["PRODUCTO"].Value.ToString();
                nuevoa["ID_PRODUCTO"] = item.Cells["ID_PRODUCTO"].Value.ToString();
                nuevoa["CANTIDAD"] = item.Cells["CANTIDAD"].Value;
                tabladetalle.Rows.Add(nuevoa);
            }
            if(conexionordendecompra.agregarordendecompra(id_provedor, DateTime.Now, tabladetalle))
            {
                MessageBox.Show("La orden de compra se ha agregado pendiente de revision");
                dtView_ordendecompra.DataSource = null;
                dtView_ordendecompra.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Debe indicar la cantidad de cada producto");
            }
        }

        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_ordendecompra.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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



    }
}

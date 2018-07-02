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
    public partial class frm_stock : Form
    {
        public frm_stock()
        {
            InitializeComponent();
        }

        
        Producto productoinstancia = new Producto();
        OrdenDeCompra ordenDeCompra = new OrdenDeCompra();
        private void frm_stock_Load(object sender, EventArgs e)
        {

            GridVw_ordenesSinRevisar.DataSource = ordenDeCompra.obtenerordenesdecomprasinrevisar();
            GridVw_ordenesSinRevisar.Columns[0].Visible = false;
            deshabilitarHeader();
            

        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (GridVw_ordenesSinRevisar.SelectedCells.Count > 0)
            {

                
            }
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {


                

            }
            catch (Exception erro)
            {
                MessageBox.Show("No se a podido modificar producto" + erro);
            }
        }

        private void GridVw_producto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.GridVw_ordenesSinRevisar.Columns[e.ColumnIndex].Name == "DISPONIBILIDAD")
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

        private void bnt_stock_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {


                

            }
            catch (Exception erro)
            {
                
            }
        }

        private void frm_stock_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9)
            {
                if (GridVw_ordenesSinRevisar.SelectedCells.Count > 0)
                {

                    
                }
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeroycomas(e);
        }

        private void disponibilidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        private void verdetalle(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0) { 
                string id_ordenDeCompra = GridVw_ordenesSinRevisar.Rows[e.RowIndex].Cells["ID_ORDENCOMPRA"].Value.ToString();
                detalleOrdenDeCompra detalle = new detalleOrdenDeCompra(id_ordenDeCompra);
                detalle.ShowDialog();
                if (detalle.DialogResult== DialogResult.OK)
                {
                    DataTable tablaconfirmada = new DataTable();
                    tablaconfirmada.Columns.Add("ID_PRODUCTO");
                    tablaconfirmada.Columns.Add("CANTIDADREAL");
                    tablaconfirmada.Columns.Add("CANTIDAD");
                    foreach (DataGridViewRow item in detalle.dtView_DetalleOrdenCompra.Rows)
                    {
                        string id_producto = item.Cells["ID_PRODUCTO"].Value.ToString();
                        string cantidadtextox = item.Cells["CANTIDADREAL"].Value.ToString();
                        DataRow nuevoa = tablaconfirmada.NewRow();
                        nuevoa["CANTIDADREAL"] = cantidadtextox;
                        nuevoa["ID_PRODUCTO"] = id_producto;
                        nuevoa["CANTIDAD"] = item.Cells["CANTIDAD"].Value.ToString();
                        tablaconfirmada.Rows.Add(nuevoa);

                    }
                    ordenDeCompra.confirmarordendecompra(id_ordenDeCompra,tablaconfirmada);
                    GridVw_ordenesSinRevisar.DataSource = ordenDeCompra.obtenerordenesdecomprasinrevisar();
                }
            }

        }

        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in GridVw_ordenesSinRevisar.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}

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

        private void GridVw_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_stock_Load(object sender, EventArgs e)
        {
            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.productolist();
            GridVw_producto.DataSource = ds;
            

        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (GridVw_producto.SelectedCells.Count > 0)
            {

                codigo_productotxt.Text = GridVw_producto.CurrentRow.Cells[0].Value.ToString();
                nombreproductotxt.Text = GridVw_producto.CurrentRow.Cells[1].Value.ToString();
                disponibilidadtxt.Text = GridVw_producto.CurrentRow.Cells[4].Value.ToString();
                preciotxt.Text = GridVw_producto.CurrentRow.Cells[2].Value.ToString();
                tipotxt.Text = GridVw_producto.CurrentRow.Cells[3].Value.ToString();
            }
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                bControl.Listaprod pro = new bControl.Listaprod();

                pro.actualizar(nombreproductotxt.Text, disponibilidadtxt.Text, preciotxt.Text, tipotxt.Text,codigo_productotxt.Text);


                MessageBox.Show("Se ha modicicado un nuevo producto");
                DataTable ds;
                Listaprod nombre = new Listaprod();
                ds = nombre.productolist();
                GridVw_producto.DataSource = ds;

            }
            catch (Exception erro)
            {
                MessageBox.Show("No se a podido modificar producto" + erro);
            }
        }

        private void GridVw_producto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.GridVw_producto.Columns[e.ColumnIndex].Name == "DISPONIBILIDAD")
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
            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.productostocks();
            GridVw_producto.DataSource = ds;
            MessageBox.Show("Productos bajos de stock reponer");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bControl.Listaprod pro = new bControl.Listaprod();

                pro.ELIMINAR(codigo_productotxt.Text);


                MessageBox.Show("Se ha ELIMINADO un nuevo producto");
                DataTable ds;
                Listaprod nombre = new Listaprod();
                ds = nombre.productolist();
                GridVw_producto.DataSource = ds;

            }
            catch (Exception erro)
            {
                MessageBox.Show("No se a podido ELIMINAR producto" + erro);
            }
        }

        private void frm_stock_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9)
            {
                if (GridVw_producto.SelectedCells.Count > 0)
                {

                    codigo_productotxt.Text = GridVw_producto.CurrentRow.Cells[0].Value.ToString();
                    nombreproductotxt.Text = GridVw_producto.CurrentRow.Cells[1].Value.ToString();
                    disponibilidadtxt.Text = GridVw_producto.CurrentRow.Cells[4].Value.ToString();
                    preciotxt.Text = GridVw_producto.CurrentRow.Cells[2].Value.ToString();
                    tipotxt.Text = GridVw_producto.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_OnValueChanged(object sender, EventArgs e)
        {
            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.buscarproducto(txt_buscar.Text);
            GridVw_producto.DataSource = ds;
        }

        private void preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeroycomas(e);
        }

        private void disponibilidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        private void codigo_productotxt_OnValueChanged(object sender, EventArgs e)
        {

           
        }
    }
}

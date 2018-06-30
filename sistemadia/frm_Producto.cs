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
using System.Data.SqlClient;
namespace sistemadia
{
    public partial class frm_Producto : Form
    {
        bControl.Producto producto = new bControl.Producto();
        public frm_Producto()
        {
            InitializeComponent();
        }
        
        private void Producto_Load(object sender, EventArgs e)
        {

            DataTable ds;
            
            ds = producto.productolist();
            GridVw_producto.DataSource = ds;
            codigo_productotxt.Focus();
            DataTable DD;
            
            DD = producto.CONTAR();
            label2.Text = DD.Rows[0][0].ToString();
            GridVw_producto.Columns[0].ReadOnly = true;
            GridVw_producto.Columns[1].ReadOnly = true;
            GridVw_producto.Columns[2].ReadOnly = true;
            GridVw_producto.Columns[3].ReadOnly = true;
            GridVw_producto.Columns[4].ReadOnly = true;




        }



        private void Guardar_Click(object sender, EventArgs e)
        {
            string codigo;
            string nombre1;
            string diponi;
            string precio;
           string tipo;
            string cod;
            codigo = codigo_productotxt.Text;
            nombre1 = nombreproductotxt.Text;
            diponi = disponibilidadtxt.Text;
            precio = preciotxt.Text;
            tipo = tipotxt.Text;
           
           
            if (string.IsNullOrEmpty(codigo) && string.IsNullOrEmpty(nombre1)  && string.IsNullOrEmpty(diponi) && string.IsNullOrEmpty(precio) && string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("ERROR  TEXTOS VACIOS","ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error);


            

                   
              
            }
            else
            {
                DataTable dt;
                dt = producto.produccodigo(codigo);
                cod = dt.Rows[0][0].ToString();
                if (cod == codigo_productotxt.Text.Trim())
                {
                    MessageBox.Show("este codigo ya exites");
                }
                else
                {
                    

                   if(producto.Agregar(nombreproductotxt.Text, disponibilidadtxt.Text, preciotxt.Text, tipotxt.Text, codigo_productotxt.Text))
                    {
                        DataTable DD;
                        DD = producto.CONTAR();
                        label2.Text = DD.Rows[0][0].ToString();

                        MessageBox.Show("Se ha creado un nuevo producto");
                        DataTable ds;
                        ds = producto.productolist();
                        GridVw_producto.DataSource = ds;
                        GridVw_producto.Columns[0].ReadOnly = true;
                        GridVw_producto.Columns[1].ReadOnly = true;
                        GridVw_producto.Columns[2].ReadOnly = true;
                        GridVw_producto.Columns[3].ReadOnly = true;
                        GridVw_producto.Columns[4].ReadOnly = true;
                        deshabilitarHeader();

                    }
                   
                }

            }
            codigo_productotxt.Text = string.Empty;
            nombreproductotxt.Text= string.Empty; ;
            disponibilidadtxt.Text= string.Empty; ;
            preciotxt.Text= string.Empty; ;
            tipotxt.Text= string.Empty; ;
            codigo_productotxt.Focus();
        }

      

        private void disponibilidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

       

        private void preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeroycomas(e);
        }
        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in GridVw_producto.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

    }
}

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
           
           
            if (codigo == "" && nombre1 == "" && diponi == "" && precio == "" && tipo == "")
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

                    }
                   
                }

            }
            codigo_productotxt.Text = "";
            nombreproductotxt.Text="";
            disponibilidadtxt.Text="";
            preciotxt.Text="";
            tipotxt.Text="";
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

       
    }
}

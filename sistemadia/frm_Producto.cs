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
        public frm_Producto()
        {
            InitializeComponent();
        }
        
        private void Producto_Load(object sender, EventArgs e)
        {

            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.productolist();
            GridVw_producto.DataSource = ds;
            codigo_productotxt.Focus();
            DataTable DD;
            Listaprod cont = new Listaprod();
            DD = cont.CONTAR();
            label2.Text = DD.Rows[0][0].ToString();



        }

        //TOMY 01-06: EN TEORIA ESTA CONEXION NO TIENE RELEVANCIA ,QUITAR

        SqlConnection con = new SqlConnection("Data Source=TCL;Initial Catalog=pruebasistema;Integrated Security=True");

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
                Listaprod list = new Listaprod();
                dt = list.produccodigo(codigo);
                cod = dt.Rows[0][0].ToString();
                if (cod == codigo_productotxt.Text.Trim())
                {
                    MessageBox.Show("este codigo ya exites");
                }
                else
                {
                    bControl.Listaprod pro = new bControl.Listaprod();

                   if(pro.Agregar(nombreproductotxt.Text, disponibilidadtxt.Text, preciotxt.Text, tipotxt.Text, codigo_productotxt.Text))
                    {
                        DataTable DD;
                        Listaprod cont = new Listaprod();
                        DD = cont.CONTAR();
                        label2.Text = DD.Rows[0][0].ToString();

                        MessageBox.Show("Se ha creado un nuevo producto");
                        DataTable ds;
                        Listaprod nombre = new Listaprod();
                        ds = nombre.productolist();
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

        private void GridVw_producto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            
        }

        private void disponibilidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        private void preciotxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeroycomas(e);
        }

        private void lbl_Nuevo_Producto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

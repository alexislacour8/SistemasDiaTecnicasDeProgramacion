using bControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadia
{
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            InitializeComponent();
            comboBox1.Items.Add("Administrativo");
            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Gerente");
            comboBox1.Items.Add("Control Stock");
            comboBox1.Items.Add("Cargado de productos");
            

        }

        private void empleados_Load(object sender, EventArgs e)
        {
            DataTable ds;
            Usuario user = frm_menuPrincipal.user;
            ds = user.listarusuarios();
            GridVw_usuariosregistrados.DataSource = ds;
            txtbox_newuserdni.Focus();
            txtbox_newuserpassword.isPassword = true;
            GridVw_usuariosregistrados.Columns[2].Visible = false;
            GridVw_usuariosregistrados.Columns[0].Visible = false;
            GridVw_usuariosregistrados.Columns[1].ReadOnly = true;
            GridVw_usuariosregistrados.Columns[3].ReadOnly = true;
            GridVw_usuariosregistrados.Columns[4].ReadOnly = true;
            GridVw_usuariosregistrados.Columns[5].ReadOnly = true;
        }

        public string dnio;
         private bool comprobarvacio(string nombre, string apellido, string email, string tipo)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(tipo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Usuario ur = new Usuario();

          
            

          if (comprobarvacio(txtbox_newuserdni.Text.ToString(), txtbox_newuserpassword.Text.ToString(), txtbox_newusernombre.Text.ToString(), txtbox_newuserapellido.Text.ToString()))
            {
                if (ur.crearnuevousuario(txtbox_newuserdni.Text, txtbox_newuserpassword.Text, txtbox_newusernombre.Text, txtbox_newuserapellido.Text, comboBox1.Text))
                {


                    MessageBox.Show("se creo un nuevo usuario");
                    DataTable ds;
                    Usuario user = frm_menuPrincipal.user;
                    ds = user.listarusuarios();
                    GridVw_usuariosregistrados.DataSource = ds;
                }
                else
                {
                    MessageBox.Show("No se puede crear el usuario, DNI no valido");
                }


            }

        

            else
            {

                MessageBox.Show("ERROR  TEXTOS VACIOS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               
                
          
          
        }

        private void txtbox_newuserdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
            
        }

        private void txtbox_newusernombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtbox_newuserapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtbox_newuserpassword_OnValueChanged(object sender, EventArgs e)
        {
            txtbox_newuserpassword.isPassword = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Blue;
           
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (GridVw_usuariosregistrados.SelectedCells.Count > 0)
            {

                txtbox_newuserdni.Text = GridVw_usuariosregistrados.CurrentRow.Cells[1].Value.ToString();
                txtbox_newusernombre.Text = GridVw_usuariosregistrados.CurrentRow.Cells[4].Value.ToString();
               txtbox_newuserapellido.Text = GridVw_usuariosregistrados.CurrentRow.Cells[5].Value.ToString();
               txtbox_newuserpassword.Text = GridVw_usuariosregistrados.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = GridVw_usuariosregistrados.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario urs = new Usuario();
                urs.modificanuevousuario12(txtbox_newuserdni.Text, txtbox_newuserpassword.Text, comboBox1.Text, txtbox_newusernombre.Text, txtbox_newuserapellido.Text);

                DataTable dd;
                Usuario useri = new Usuario();
                dd = useri.listarusuarios();
                GridVw_usuariosregistrados.DataSource = dd;
            }
            catch(Exception error)
            {
                MessageBox.Show("no se pudo modificar" + error);
            }
        }

        private void txtbox_newuserdni_OnValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}

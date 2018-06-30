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
        }

        

        private void Guardar_Click(object sender, EventArgs e)
        {
            
            if (frm_menuPrincipal.user.crearnuevousuario(txtbox_newuserdni.Text, txtbox_newuserpassword.Text, txtbox_newusernombre.Text, txtbox_newuserapellido.Text, comboBox1.Text.Trim()))
            {
                MessageBox.Show("Se ha creado un nuevo usuario satisfactoriamente");
            }
            else
            {
                MessageBox.Show("No se a podido crear usuario");
            }
            DataTable ds;
            Usuario user = frm_menuPrincipal.user;
            ds = user.listarusuarios();
            GridVw_usuariosregistrados.DataSource = ds;
            //No se como refrescar el gridview sin que sea medio tosco :(
        }
    }
}

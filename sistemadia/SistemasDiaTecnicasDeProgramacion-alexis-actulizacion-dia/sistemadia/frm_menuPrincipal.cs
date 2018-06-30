using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using bControl;

namespace sistemadia
{
    public partial class frm_menuPrincipal : Form
    {
        public frm_menuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         public static Listaprod nombre;
        public static Usuario user = frm_login.user;

        private void Abrirformhija(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Parent = this;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();

        }
        
        private void privilegio(string TIPO)
        {
            
            if (TIPO == "Vendedor")
            {
                btn_stock.Visible = false;
                btn_clientes.Visible = false;
                btn_ventas.Visible = false;
                btn_productos.Visible = false;
                btn_usuarios.Visible = false;

            }
            else if (TIPO == "Gerente")
            {
                btn_stock.Visible = false;
                btn_clientes.Visible = false;
                btn_facturas.Visible = false;
                btn_productos.Visible = false;
                btn_usuarios.Visible = false;

            }
            else if (TIPO== "Cargado de productos")
            {
                
                btn_clientes.Visible=false;
                btn_facturas.Visible = false;
                btn_usuarios.Visible = false;
                btn_ventas.Visible = false;

            }
            else if (TIPO == "Administrador")
            {
                
                btn_clientes.Visible = false;
                btn_facturas.Visible = false;
               
                btn_stock.Visible = false;
                btn_ventas.Visible = false;

            }
            else if (TIPO == "Control Stock")
            { 
                btn_clientes.Visible = false;
                btn_facturas.Visible = false;
                btn_productos.Visible = false;
                btn_usuarios.Visible = false;
                btn_ventas.Visible = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
            privilegio(user.Str_userpermiso);
            label_nombreusuario.Text = user.Str_nombre;
            label_tipousuario.Text = user.Str_userpermiso;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abrirformhija(new frm_empleados());
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Abrirformhija(new frm_Producto());
        }

        private void btn_facturas_Click(object sender, EventArgs e)
        {
            Abrirformhija(new frm_facturas());
        }

        private void bunifuGradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Abrirformhija(new frm_Proveedores());
        }
    }
}

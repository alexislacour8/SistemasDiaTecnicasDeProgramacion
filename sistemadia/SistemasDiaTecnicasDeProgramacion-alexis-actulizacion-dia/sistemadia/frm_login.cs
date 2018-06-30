using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using bControl;

namespace sistemadia
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        public static bControl.Usuario user = new bControl.Usuario();

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {


                if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                {

                    frm_menuPrincipal men = new frm_menuPrincipal();
                    men.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El login es incorrecto");
                }
            }
            catch (Exception ERR)
            {
                MessageBox.Show("error" + ERR);

            }
        }
        string useri = "";
        string pass = "";
        private void frm_login_Load(object sender, EventArgs e)
        {
            usertxt.Text = "Documento";
            contraseñatxt.Text = "Contraseña";
            contraseñatxt.isPassword = false;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void usertxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void usertxt_MouseEnter(object sender, EventArgs e)
        {
            
            usertxt.ForeColor = Color.Black;
        }

        private void usertxt_MouseLeave(object sender, EventArgs e)
        {
            useri = usertxt.Text;
            if (useri.Equals("Documento"))
            {
                usertxt.Text = "Documento";
                usertxt.ForeColor = Color.DimGray;

            }

            else
            {
                if (useri.Equals(""))
                {
                    usertxt.Text = "Documento";
                    usertxt.ForeColor = Color.DimGray;
                }
                else
                {
                    usertxt.Text = useri;
                    usertxt.ForeColor = Color.Black;
                }
            }
        }

        private void contraseñatxt_MouseEnter(object sender, EventArgs e)
        {
            contraseñatxt.Text = "";
            contraseñatxt.ForeColor = Color.Black;
            contraseñatxt.isPassword = true;
        }

        private void contraseñatxt_MouseLeave(object sender, EventArgs e)
        {
            pass = contraseñatxt.Text;
            if (pass.Equals("Contraseña"))
            {
                contraseñatxt.Text = "Contraseña";
                contraseñatxt.ForeColor = Color.DimGray;

            }

            else
            {
                if (pass.Equals(""))
                {
                    contraseñatxt.isPassword = false;
                    contraseñatxt.Text = "Contraseña";
                    contraseñatxt.ForeColor = Color.DimGray;
                }
                else
                {
                    contraseñatxt.isPassword = true;
                    contraseñatxt.Text = pass;
                    contraseñatxt.ForeColor = Color.Black;
                }
            }
        }

        private void bunifuThinButton21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {


                    if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                    {

                        frm_menuPrincipal men = new frm_menuPrincipal();
                        men.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El login es incorrecto");
                    }
                }
                catch (Exception ERR)
                {
                    MessageBox.Show("error" + ERR);

                }
            }
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {


                    if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                    {

                        frm_menuPrincipal men = new frm_menuPrincipal();
                        men.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El login es incorrecto");
                    }
                }
                catch (Exception ERR)
                {
                    MessageBox.Show("error" + ERR);

                }
            }
        }
    }
}


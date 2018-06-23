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
    public partial class frm_facturas : Form
    {
        public frm_facturas()
        {
            InitializeComponent();
        }
        public static Usuario user = frm_login.user;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechatxt.Text = DateTime.Now.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            txtnombre.Text = Convert.ToString(user.Int_iduser);
            autocompletar AU = new autocompletar();
            AU.AutoCompletar(productotxt);
            productotxt.Focus();
        }
        public static decimal totalidad;
        public static int cont_fila = 0;
        private void colocar_Click(object sender, EventArgs e)
        {
            totalidad = 0;
            bool existe = false;
            int num_fila = 0;

            if (cont_fila == 0)
            {

                dataGridView1.Rows.Add(codigoprotxt.Text, productotxt.Text, cantidadtxt.Text, preciotxt.Text, txtnombre.Text, clientetxt.Text,fechatxt.Text);
                decimal importe = Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[3].Value);
                dataGridView1.Rows[cont_fila].Cells[7].Value = importe;

                cont_fila++;
            }
            else
            {
                foreach (DataGridViewRow FILA in dataGridView1.Rows)
                {
                    if (FILA.Cells[0].Value.ToString() == codigoprotxt.Text)
                    {
                        existe = true;
                        num_fila = FILA.Index;
                    }
                }
                if (existe == true)
                {
                    dataGridView1.Rows[num_fila].Cells[2].Value = (Convert.ToDouble(cantidadtxt.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value)).ToString();
                    decimal importe = Convert.ToDecimal(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[num_fila].Cells[3].Value);
                    dataGridView1.Rows[num_fila].Cells[7].Value = importe;
                }
                else
                {
                    dataGridView1.Rows.Add(codigoprotxt.Text, productotxt.Text, cantidadtxt.Text, preciotxt.Text, txtnombre.Text, clientetxt.Text, fechatxt.Text);
                    decimal importe = Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[7].Value = importe;

                    cont_fila++;
                }

            }
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                totalidad += Convert.ToDecimal(fila.Cells[7].Value);



            }
            cantidadtxt.Text = "";
            productotxt.Text = "";
            cantidadtxt.Text = "";
            preciotxt.Text = "";
            clientetxt.Text = "";
            productotxt.Focus();


            resultadotxt.Text ="$"+ totalidad.ToString("N2");
        }

        // TOMY 01-06: ESTO HAY QUE CAMBIAR PORQUE ESTA EN CAPA 1, TRASLADARLO

        SqlConnection cmm = new SqlConnection("Data Source=TCL;Initial Catalog=pruebasistema;Integrated Security=True");
        private void productotxt_TextChanged(object sender, EventArgs e)
        {
            string sql = "select ID_PRODUCTO,PRECIO FROM PRODUCTO WHERE NOMBRE='" + productotxt.Text + " '";
            SqlCommand coman = new SqlCommand(sql, cmm);

            cmm.Open();
            SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read() == true)
            {
                codigoprotxt.Text = leer["ID_PRODUCTO"].ToString();
                preciotxt.Text = leer["PRECIO"].ToString();

            }
            else
            {
                codigoprotxt.Text = "";
                preciotxt.Text = "";
                productotxt.Focus();
            }

            cmm.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                totalidad = totalidad - (Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value));


                resultadotxt.Text ="$"+ totalidad.ToString("N2");


                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;
            }
        }
    }
}

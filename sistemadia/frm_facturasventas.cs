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
    public partial class frm_facturasventas : Form
    {
        public frm_facturasventas()
        {
            InitializeComponent();
        }
        public static Usuario user = frm_login.user;
        public static VENTASDETALLE vent = new VENTASDETALLE();
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
        public string factu;
        public string vendedor;
        private void Facturas_Load(object sender, EventArgs e)
        {
            vendedor = Convert.ToString(user.Int_iduser);
            DataTable ds;
           

            VENTASDETALLE vet = new VENTASDETALLE();
            ds = vet.ventamax();

            factu = ds.Rows[0][0].ToString();



            autocompletar AU = new autocompletar();
            AU.AutoCompletar(productotxt);
            productotxt.Focus();
        }
        public static decimal totalidad;
        public static int cont_fila = 0;
        private void colocar_Click(object sender, EventArgs e)
        {
          
            string nombre;
            string cantidad;
            string precio;

          
            nombre = productotxt.Text;
            cantidad = cantidadtxt.Text;
            precio = preciotxt.Text;
            if (nombre == "" && cantidad == "" && precio == "")
            {
                MessageBox.Show("error llenar todas la cajas de texto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalidad = 0;
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {

                    dataGridView1.Rows.Add(codigo, productotxt.Text, cantidadtxt.Text, preciotxt.Text);
                    decimal importe = Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

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
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(codigo, productotxt.Text, cantidadtxt.Text, preciotxt.Text);
                        decimal importe = Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }

                }
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    totalidad += Convert.ToDecimal(fila.Cells[4].Value);



                }
            }
            cantidadtxt.Text = "";
            productotxt.Text = "";
            cantidadtxt.Text = "";
            preciotxt.Text = "";
          
            productotxt.Focus();


            resultadotxt.Text ="$"+ totalidad.ToString("N2");
        }
        SqlConnection cmm = new SqlConnection("Data Source=TCL;Initial Catalog=sistemadia;Integrated Security=True");
        private void productotxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                totalidad = totalidad - (Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));


                resultadotxt.Text ="$"+ totalidad.ToString("N2");


                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        public void completar()
        {
            string sql = "select ID_CLIENTE FROM CLIENTE WHERE HABILITADO = 1 AND NOMBRE='" + completa + " '";
            SqlCommand coman = new SqlCommand(sql, cmm);

            cmm.Open();
            SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read() == true)
            {
                codigocliente = leer["ID_CLIENTE"].ToString();


            }
        }
        public string codigocliente;
        public string completa ="comsumidor final";
        private void clientetxt_TextChanged(object sender, EventArgs e)
        {
            
           
           

           
        }

        private void Facturas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                if (cont_fila > 0)
                {
                    totalidad = totalidad - (Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));


                    resultadotxt.Text = "$" + totalidad.ToString("N2");


                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    cont_fila--;
                }
            }
            if(e.KeyCode == Keys.End)
            {
                completar();
                VENTASDETALLE ventas = new VENTASDETALLE();
                ventas.Agregarventa(vendedor,codigocliente, fechatxt.Text);
                DataTable ds;
                VENTASDETALLE vet = new VENTASDETALLE();
                ds = vet.ventamax();
                factu = ds.Rows[0][0].ToString();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {

                    ventas.ventapro(factu, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value));
                }
                reporte_factura fer = new reporte_factura();


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    reportfactu c = new reportfactu();
                    c.nombre = (string)this.dataGridView1.Rows[i].Cells[1].Value;
                    c.cantidad = (string)this.dataGridView1.Rows[i].Cells[2].Value;
                    c.precio = (string)this.dataGridView1.Rows[i].Cells[3].Value;
                    c.importe = (decimal)this.dataGridView1.Rows[i].Cells[4].Value;
                    c.fecha = fechatxt.Text;
                    c.total = resultadotxt.Text;
                    fer.dato.Add(c);
                }
                fer.ShowDialog();
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            completar();
            VENTASDETALLE ventas = new VENTASDETALLE();
            ventas.Agregarventa(vendedor, codigocliente, fechatxt.Text);
            DataTable ds;
            VENTASDETALLE vet = new VENTASDETALLE();
            ds = vet.ventamax();
            factu = ds.Rows[0][0].ToString();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                ventas.ventapro(factu, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value));
            }
            reporte_factura fer = new reporte_factura();


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                reportfactu c = new reportfactu();
                c.nombre = (string)this.dataGridView1.Rows[i].Cells[1].Value;
                c.cantidad = (string)this.dataGridView1.Rows[i].Cells[2].Value;
                c.precio = (string)this.dataGridView1.Rows[i].Cells[3].Value;
                c.importe = (decimal)this.dataGridView1.Rows[i].Cells[4].Value;
                c.fecha = fechatxt.Text;
                c.total = resultadotxt.Text;
                fer.dato.Add(c);
            }
            fer.ShowDialog();
            dataGridView1.Rows.Clear();
            resultadotxt.Text = "";
            cont_fila = 0;
            totalidad = 0;
            productotxt.Focus();
        }

        private void label2_ventas_Click(object sender, EventArgs e)
        {
           
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productotxt_OnValueChanged(object sender, EventArgs e)
        {
           
        }
        public static string codigo;
        private void productotxt_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "select ID_PRODUCTO,PRECIO FROM PRODUCTO WHERE HABILITADO = 1 AND NOMBRE='" + productotxt.Text + " '";
            SqlCommand coman = new SqlCommand(sql, cmm);

            cmm.Open();
            SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read() == true)
            {
                codigo = leer["ID_PRODUCTO"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Clientes emple = new frm_Clientes();
            emple.Show();
        }
    }
}

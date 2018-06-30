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
        public static VentasDetalle venta = new VentasDetalle();
        

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
           

            
            ds = venta.ventamax();

            factu = ds.Rows[0][0].ToString();

            dataGridView1.Rows.Clear();
            resultadotxt.Text = "";
            cont_fila = 0;
            totalidad = 0;

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
            if ((nombre == ""|| string.IsNullOrEmpty(nombre) ) || (cantidad == "" || string.IsNullOrEmpty(cantidad)) || (precio == "" || string.IsNullOrEmpty(precio)))
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
                        if (FILA.Cells[0].Value.ToString() == codigo)
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
            cantidadtxt.Text = string.Empty;
            productotxt.Text = string.Empty;
            cantidadtxt.Text = string.Empty;
            preciotxt.Text = string.Empty;
          
            productotxt.Focus();


            resultadotxt.Text ="$"+ totalidad.ToString("N2");
            if (dataGridView1.Rows.Count==0)
            {
                btn_vender.Enabled = false ;
                button1.Enabled = false ;
                eliminar.Enabled = false;

            }
            else
            {
                btn_vender.Enabled = true;
                button1.Enabled = true;
                eliminar.Enabled = true;
            }
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
            if (dataGridView1.Rows.Count == 0)
            {
                btn_vender.Enabled = false;
                button1.Enabled = false;
                eliminar.Enabled = false;

            }
            else
            {
                btn_vender.Enabled = true;
                button1.Enabled = true;
                eliminar.Enabled = true;
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
        public string completa ="consumidor final";
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
                venta.Agregarventa(vendedor,codigocliente, fechatxt.Text);
                DataTable ds;
                ds = venta.ventamax();
                factu = ds.Rows[0][0].ToString();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {

                    venta.ventapro(factu, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value));
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
        }

        


        private void btn_vender_Click(object sender, EventArgs e)
        {
            completar();
            venta.Agregarventa(vendedor, codigocliente, fechatxt.Text);
            DataTable ds;
            ds = venta.ventamax();
            factu = ds.Rows[0][0].ToString();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                venta.ventapro(factu, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value));
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

        
        public static string codigo;

        bControl.Buscador buscador = new Buscador();

        private void productotxt_TextChanged_1(object sender, EventArgs e)
        {
            
            DataTable leer = buscador.buscarproducto(productotxt.Text.ToString());
            if (leer.Rows.Count > 0)
            {
                codigo = leer.Rows[0]["ID_PRODUCTO"].ToString();
                preciotxt.Text = leer.Rows[0]["PRECIO"].ToString();

            }
            else
            {
                codigoprotxt.Text = string.Empty;
                preciotxt.Text = string.Empty;
                productotxt.Focus();
            }

            
        }
        string clien;
        string tipo;
        private void button2_Click(object sender, EventArgs e)
        {
            cliente_factura com = new cliente_factura();
            com.ShowDialog();
           

               
                    if (com.DialogResult == DialogResult.OK)
                    {
                        clientes1.Text = com.dtView_cliente.Rows[com.dtView_cliente.CurrentRow.Index].Cells[0].Value.ToString();
                        tipo = com.dtView_cliente.Rows[com.dtView_cliente.CurrentRow.Index].Cells[1].Value.ToString();
                       


                    }
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            completar();
            venta.Agregarventa(vendedor, clientes1.Text, fechatxt.Text);
            DataTable ds;
            ds = venta.ventamax();
            factu = ds.Rows[0][0].ToString();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                venta.ventapro(factu, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value));
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            resultadotxt.Text = "";
        }
    }
}


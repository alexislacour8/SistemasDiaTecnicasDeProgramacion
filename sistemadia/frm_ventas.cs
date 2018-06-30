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
namespace sistemadia
{
    public partial class frm_ventas : Form
    {
        public frm_ventas()
        {
            InitializeComponent();
        }
        VentasDetalle venta = new VentasDetalle();
        private void frm_ventas_Load(object sender, EventArgs e)
        {
            
            GridVw_producto.DataSource= venta.listaven();
            DataTable ds;
            
            ds = venta.contarvent(dateTimePicker1.Text);
            label2.Text = ds.Rows[0][0].ToString();
            
            DataTable dd;
            dd = venta.montodiario(dateTimePicker1.Text);
            label3.Text = dd.Rows[0][0].ToString();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable ds;
           
            ds = venta.buscarventas(dateTimePicker1.Text,dateTimePicker2.Text);
            GridVw_producto.DataSource = ds;
        }
        decimal totalidad;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            totalidad = 0;
            foreach (DataGridViewRow fila in GridVw_producto.Rows)
            {
                totalidad += Convert.ToDecimal(fila.Cells[3].Value)* Convert.ToDecimal(fila.Cells[4].Value);



            }
            txtcalcular.Text = "$" + totalidad.ToString("N2");
        }

        

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            DataTable ds;
            
            ds = venta.buscarvendedor(dateTimePicker1.Text,dateTimePicker2.Text,buscartxt.Text);
            GridVw_producto.DataSource = ds;
           
        }

        
    }
}

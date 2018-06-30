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
    public partial class cliente_factura : Form
    {
        public cliente_factura()
        {
            InitializeComponent();
        }

        private void cliente_factura_Load(object sender, EventArgs e)
        {
            DataTable ds;
            Clientes cliente = new Clientes();
            ds = cliente.listar_Clientes();
            dtView_cliente.DataSource = ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtView_cliente.SelectedColumns.Count > 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable ds;
           Clientes nombre = new Clientes();
            ds = nombre.buscarcliente(textBox1.Text);
            dtView_cliente.DataSource = ds;
        }
    }
}

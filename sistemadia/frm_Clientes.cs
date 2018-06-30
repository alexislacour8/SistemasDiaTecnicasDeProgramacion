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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }

        bControl.Clientes conexioncliente = new bControl.Clientes();

        #region Funciones Miscelaneas
        private void cargarGridView()
        {
            
            dtView_Clientes.Columns[0].Visible = false;
            dtView_Clientes.Columns[0].ReadOnly = true;
            dtView_Clientes.Columns[1].ReadOnly = true;
            dtView_Clientes.Columns[2].ReadOnly = true;
            dtView_Clientes.Columns[3].ReadOnly = true;
            dtView_Clientes.Columns[4].ReadOnly = true;
            var columnaeliminar = new DataGridViewCheckBoxColumn();
            columnaeliminar.HeaderText = "Eliminar";
            columnaeliminar.Name = "Eliminar";
            columnaeliminar.ReadOnly = false;
            dtView_Clientes.Columns.AddRange(new DataGridViewColumn[] { columnaeliminar });
            deshabilitarHeader();
        }

        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_Clientes.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void descargartextbox()
        {
            txtbox_apellido.Text = String.Empty;
            txtbox_email.Text = String.Empty;
            txtbox_idCliente.Text = string.Empty;
            txtBox_nombre.Text = string.Empty;
            cmbox_tipo.SelectedIndex = cmbox_tipo.FindStringExact("Responsable Inscripto");
        }
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
        #endregion

        #region Eventos

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            cmbox_tipo.Items.Add("Responsable Inscripto");
            cmbox_tipo.Items.Add("Monotributista");
            cmbox_tipo.Items.Add("Iva Exento");
            dtView_Clientes.DataSource = conexioncliente.listar_Clientes();
            cargarGridView();
            descargartextbox();
            cmbox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBox_nombre.Focus();
            DataTable ds;
            Clientes cliente = new Clientes();
            ds=cliente.contar_Clientes();
            label2.Text = ds.Rows[0][0].ToString();
           
        }


        private void btn_nuevoUsuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbox_idCliente.Text.ToString()))
            {
                //crear
                if (comprobarvacio(txtBox_nombre.Text.ToString(),txtbox_apellido.Text.ToString(),txtbox_email.Text.ToString(),cmbox_tipo.SelectedItem.ToString()))
                {
                    if (conexioncliente.crear_Cliente(txtBox_nombre.Text.ToString(),txtbox_apellido.Text.ToString(),txtbox_email.Text.ToString(),cmbox_tipo.SelectedItem.ToString()))
                    {
                        dtView_Clientes.DataSource = conexioncliente.listar_Clientes();
                        DataTable ds;
                        Clientes cliente = new Clientes();
                        ds = cliente.contar_Clientes();
                        label2.Text = ds.Rows[0][0].ToString();
                        descargartextbox();
                        MessageBox.Show("Cliente creado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se puede crear cliente porque algunos campos superan el limite de caracteres");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede crear porque hay campos vacios o invalidos");
                }
            }
            else
            {
                //modificar
                if (comprobarvacio(txtBox_nombre.Text.ToString(),txtbox_apellido.Text.ToString(),txtbox_email.Text.ToString(),cmbox_tipo.SelectedItem.ToString()))
                {
                    if (conexioncliente.modificar_Cliente(txtbox_idCliente.Text.ToString(),txtBox_nombre.Text.ToString(),txtbox_apellido.Text.ToString(),txtbox_email.Text.ToString(),cmbox_tipo.SelectedItem.ToString()))
                    {
                        descargartextbox();
                        dtView_Clientes.DataSource = conexioncliente.listar_Clientes();
                        MessageBox.Show("Cliente modificado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar cliente porque algunos campos superan el limite de caracteres");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede crear porque hay campos vacios o invalidos");
                }
            }
        }


        private void terminaredit(object sender, DataGridViewCellEventArgs e)
        {
            dtView_Clientes.EndEdit();
        }

        

        private void DtView_Clientes_OnCambiodevalor(object sender, DataGridViewCellEventArgs e)
        {
            int chequiados = 0;
            foreach (DataGridViewRow row in dtView_Clientes.Rows)          //recorro todo el datagridview

            {

                if (row.Cells["Eliminar"].Value != null && (bool)row.Cells["Eliminar"].Value == true)      //cuento cuantos valores tienen el checkbox marcado

                {
                    chequiados = chequiados + 1;
                    break;              //rompo el loop para no tener que recorrer toda la lista (parece buena idea)
                }


            }
            if (chequiados >= 1)      //si los valores que conte son mas o iguales a uno activo el boton de eliminar
            {
                btn_eliminarCliente.Enabled = true;
            }
            else          //de modo contrario lo desactivo
            {
                btn_eliminarCliente.Enabled = false;

            }

           
        }

        

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            descargartextbox();
        }

       

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtView_Clientes.Rows)
            {
                if (row.Cells["Eliminar"].Value != null && (bool)row.Cells["Eliminar"].Value == true)

                {
                    
                    conexioncliente.eliminar_Cliente(row.Cells["ID_CLIENTE"].Value.ToString());
                }
            }
            MessageBox.Show("Se han eliminado clientes satisfactoriamente");
            dtView_Clientes.DataSource = conexioncliente.listar_Clientes();
        }

        private void OnCelldobleclick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                txtBox_nombre.Text = dtView_Clientes.Rows[x].Cells["NOMBRE"].Value.ToString();
                txtbox_apellido.Text = dtView_Clientes.Rows[x].Cells["APELLIDO"].Value.ToString();
                txtbox_email.Text = dtView_Clientes.Rows[x].Cells["EMAIL"].Value.ToString();
                txtbox_idCliente.Text = dtView_Clientes.Rows[x].Cells["ID_CLIENTE"].Value.ToString();

                string tipo = dtView_Clientes.Rows[x].Cells["TIPO"].Value.ToString();

                cmbox_tipo.SelectedIndex = cmbox_tipo.FindStringExact(tipo);
               
            }
        }

        #endregion


    }
}

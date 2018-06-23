using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using bControl;

namespace sistemadia
{
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        bControl.Proveedor proveedor = new bControl.Proveedor();  //instancia del objeto Proveedor de capa2
        

        #region Eventos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
           
            
            if (string.IsNullOrEmpty(txt_idproveedor.Text.ToString())) {
                

                //.Text trae el contenido y .ToString() lo transforma en string
                if (!string.IsNullOrEmpty(txtbox_Nombre.Text) && !string.IsNullOrEmpty(txtbox_Direccion.Text) && !string.IsNullOrEmpty(txtbox_Email.Text) && !string.IsNullOrEmpty(txtbox_Telefono.Text)) {

                    string mail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))";
                    if (Regex.IsMatch(txtbox_Email.Text, mail))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("email invalido ingrese una cuenta valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        errorProvider1.SetError(this.txtbox_Email, "error mail");
                        return;
                    }
                    if (proveedor.agregar_Proveedor(txtbox_Nombre.Text.ToString(),txtbox_Telefono.Text.ToString(),txtbox_Direccion.Text.ToString(),txtbox_Email.Text.ToString()))
                    {
                        dtView_proveedores.DataSource = proveedor.obtener_Proveedores();
                        descargarTextsBox();
                        MessageBox.Show("Proveedor fue creado correctamente"); //MessageBox es un objeto (formulario chiquitito)
                        
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no fue creado");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede crear el proveedor porque hay campos vacios","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtbox_Nombre.Text) && !string.IsNullOrEmpty(txtbox_Direccion.Text) && !string.IsNullOrEmpty(txtbox_Email.Text) && !string.IsNullOrEmpty(txtbox_Telefono.Text))
                {
                    
                    if (proveedor.modificar_Prooveedor(txt_idproveedor.Text.ToString(),txtbox_Nombre.Text.ToString(),txtbox_Telefono.Text.ToString(),txtbox_Direccion.Text.ToString(),txtbox_Email.Text.ToString()))
                    {

                        dtView_proveedores.DataSource =proveedor.obtener_Proveedores();
                        deshabilitarHeader();
                        descargarTextsBox();
                        
                        MessageBox.Show("Se ha modificado un proveedor exitosamente");
                        
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar un proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar porque hay un campo vacio");
                }
                
            }
            descargarTextsBox();
        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {

            dtView_proveedores.DataSource = proveedor.obtener_Proveedores();
            cargarGridView();

        }

        private void dtView_proveedores_OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                txtbox_Nombre.Text = dtView_proveedores.Rows[x].Cells["NOMBRE"].Value.ToString();
                txtbox_Direccion.Text = dtView_proveedores.Rows[x].Cells["DIRECCION"].Value.ToString();
                txtbox_Email.Text = dtView_proveedores.Rows[x].Cells["EMAIL"].Value.ToString();
                txtbox_Telefono.Text = dtView_proveedores.Rows[x].Cells["TELEFONO"].Value.ToString();
                txt_idproveedor.Text = dtView_proveedores.Rows[x].Cells["ID_PROVEDOR"].Value.ToString();
            }
        }

        private void btn_eliminarProveedores_Click(object sender, EventArgs e)         //esta es la funcion del boton de eliminar proveedores
        {
            foreach (DataGridViewRow row in dtView_proveedores.Rows)
            {
                if (row.Cells["Eliminar"].Value != null && (bool)row.Cells["Eliminar"].Value == true)

                {
                    int id_proveedor = Int32.Parse(row.Cells["ID_PROVEDOR"].Value.ToString());
                    proveedor.eliminar_Proveedor(id_proveedor);
                }
            }
            MessageBox.Show("Se han eliminado proveedores satisfactoriamente");
            dtView_proveedores.DataSource = proveedor.obtener_Proveedores();
        }

        private void btn_limipiar_Click(object sender, EventArgs e)
        {
            descargarTextsBox();
        }

        private void DtView_proveedores_OnCambiodevalor(object sender, DataGridViewCellEventArgs e)
        {
            int chequiados = 0;
            foreach (DataGridViewRow row in dtView_proveedores.Rows)          //recorro todo el datagridview

            {

                if (row.Cells["Eliminar"].Value != null && (bool)row.Cells["Eliminar"].Value == true)      //cuento cuantos valores tienen el checkbox marcado

                {
                    chequiados = chequiados + 1;
                    break;              //rompo el loop para no tener que recorrer toda la lista (parece buena idea)
                }


            }
            if (chequiados >= 1)      //si los valores que conte son mas o iguales a uno activo el boton de eliminar
            {
                btn_eliminarProveedores.Enabled = true;
            }
            else          //de modo contrario lo desactivo
            {
                btn_eliminarProveedores.Enabled = false;

            }
        }

        private void terminaredit(object sender, DataGridViewCellEventArgs e)
        {
            dtView_proveedores.EndEdit();
        }

        #endregion

        #region Funciones Miscelaneas

        private void descargarTextsBox()
        {
            txtbox_Email.Text = string.Empty;
            txtbox_Direccion.Text = string.Empty;
            txtbox_Nombre.Text = string.Empty;
            txtbox_Telefono.Text = string.Empty;
            txt_idproveedor.Text = string.Empty;
        }

       
        private void cargarGridView()                                  //funcion que utilizo para cargar y actualizar el gridview de proveedores
        {
            
            
            dtView_proveedores.Columns[0].Visible = false;
            dtView_proveedores.Columns[0].ReadOnly = true;
            dtView_proveedores.Columns[1].ReadOnly = true;
            dtView_proveedores.Columns[2].ReadOnly = true;
            dtView_proveedores.Columns[3].ReadOnly = true;
            dtView_proveedores.Columns[4].ReadOnly = true;
            var columnaeliminar = new DataGridViewCheckBoxColumn();
            columnaeliminar.HeaderText = "Eliminar";
            columnaeliminar.Name = "Eliminar";
            columnaeliminar.ReadOnly = false;
            dtView_proveedores.Columns.AddRange(new DataGridViewColumn[] { columnaeliminar });
            deshabilitarHeader();
        }
        

        

        private void deshabilitarHeader()
        {
            foreach (DataGridViewColumn columna in dtView_proveedores.Columns) {
                
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }








        #endregion

        private void txtbox_Telefono_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void txtbox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }
    }
}

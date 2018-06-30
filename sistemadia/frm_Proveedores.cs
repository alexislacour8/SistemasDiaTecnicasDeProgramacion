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
        bControl.Producto producto = new bControl.Producto();
        

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

            autocompletar AU = new autocompletar();
            AU.AutoCompletar(txt_Producto);
            txt_Producto.Focus();

        }
        DataTable productos = new DataTable();
        int cantidaddedatosviejos = 0;


        

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
                txt_Seleccionado.Text= dtView_proveedores.Rows[x].Cells["NOMBRE"].Value.ToString();

                DataTable productosintermedios = producto.productodeprovedor(dtView_proveedores.Rows[x].Cells["ID_PROVEDOR"].Value.ToString());
                
                productos.Clear();
                productos.Columns.Clear();
                
                dtGridView_ProductosdelProveedor.Columns.Clear();
                productos.Columns.Add("ID_PRODUCTO");
                productos.Columns.Add("NOMBRE PRODUCTO");
                productos.Columns.Add("PRECIO");
                productos.Columns.Add("TIPO");
                productos.Columns.Add("CODIGO PRODUCTO");
                productos.Columns[0].ReadOnly = true;
                productos.Columns[1].ReadOnly = true;
                productos.Columns[2].ReadOnly = true;
                productos.Columns[3].ReadOnly = true;
                productos.Columns[4].ReadOnly = true;
                int contador = 0;
                foreach (DataRow fila in productosintermedios.Rows)
                {
                    DataTable pasar=producto.obtenerproductoporid(fila["ID_PRODUCTO"].ToString());  //recien me di cuenta que podia traer los datos a traves de una sola consulta, soy un boludo, de todas maneras dejemoslo porque funciona
                    DataRow nuevo = productos.NewRow();
                    nuevo["ID_PRODUCTO"] = pasar.Rows[0][0].ToString();
                    nuevo["NOMBRE PRODUCTO"] = pasar.Rows[0][1].ToString();
                    nuevo["PRECIO"] = pasar.Rows[0][2].ToString();
                    nuevo["TIPO"] = pasar.Rows[0][3].ToString();
                    nuevo["CODIGO PRODUCTO"] = pasar.Rows[0][4].ToString();
                    productos.Rows.Add(nuevo);
                    contador = contador + 1;
                }
                dtGridView_ProductosdelProveedor.DataSource = productos;
                var columnaeliminar = new DataGridViewCheckBoxColumn();
                columnaeliminar.HeaderText = "ELIMINAR";
                columnaeliminar.Name = "Eliminar";
                columnaeliminar.ReadOnly = false;

                productosintermedios.Clear();

                dtGridView_ProductosdelProveedor.Columns.AddRange(new DataGridViewColumn[] { columnaeliminar });
                cantidaddedatosviejos = dtGridView_ProductosdelProveedor.Rows.Count;
                dtGridView_ProductosdelProveedor.Columns[0].Visible = false;
                deshabilitarotroHeader();
                txt_Producto.Enabled = true;
                btn_addproducto.Enabled = true;
                btn_addproductproveedor.Enabled = true;
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
            dtGridView_ProductosdelProveedor.EndEdit();
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
            txt_Seleccionado.Text = string.Empty;
            txt_Producto.Text = string.Empty;
            txt_Producto.Enabled = false;
            btn_addproducto.Enabled = false;
            btn_addproductproveedor.Enabled = false;
            btn_deleteproductproveedor.Enabled = false;
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

        private void deshabilitarotroHeader()
        {
            foreach (DataGridViewColumn columna in dtGridView_ProductosdelProveedor.Columns)
            {

                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }






        #endregion

        

        private void txtbox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
        }

        private void btn_deseleccionar_Click(object sender, EventArgs e)
        {
            descargarTextsBox();
        }

        public static string codigo;

        bControl.Buscador buscadore = new Buscador();
        

        private void buscador(object sender, EventArgs e)
        {
            DataTable leer = buscadore.buscarproducto(txt_Producto.Text.ToString());
            if (leer.Rows.Count > 0)
            {
                codigo = leer.Rows[0]["ID_PRODUCTO"].ToString();

            }
            else
            {
                
            }
        }

        private void btn_addproducto_Click(object sender, EventArgs e)
        {
            // a partir de este punto estoy programando fumado
            string producto = txt_Producto.Text.ToString();
            Producto product = new Producto();
            DataTable tabladeproductos=product.buscarproductopronombre(producto);
            if (tabladeproductos.Rows.Count >0)
            {
               
                DataRow nuevoa = productos.NewRow();
                nuevoa["ID_PRODUCTO"] = tabladeproductos.Rows[0][0].ToString();
                nuevoa["NOMBRE PRODUCTO"] = tabladeproductos.Rows[0][1].ToString();
                nuevoa["PRECIO"] = tabladeproductos.Rows[0][2].ToString();
                nuevoa["TIPO"] = tabladeproductos.Rows[0][3].ToString();
                nuevoa["CODIGO PRODUCTO"] = tabladeproductos.Rows[0][4].ToString();
                productos.Rows.Add(nuevoa);
                int filas=dtGridView_ProductosdelProveedor.Rows.Count;
                dtGridView_ProductosdelProveedor.Rows[filas-1].Cells["ELIMINAR"].ReadOnly = true;

            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
            txt_Producto.Text = "";

            txt_Producto.Focus();
        }

        private void btn_addproductproveedor_Click(object sender, EventArgs e)
        {
            string id_proveedor = txt_idproveedor.Text.ToString();
            for (int i = cantidaddedatosviejos; i < dtGridView_ProductosdelProveedor.Rows.Count; i++)
            {
                string id_producto=dtGridView_ProductosdelProveedor.Rows[i].Cells["ID_PRODUCTO"].Value.ToString();
                try { 
                    proveedor.agregarproducto(id_producto, id_proveedor);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("El objeto "+dtGridView_ProductosdelProveedor.Rows[i].Cells["NOMBRE PRODUCTO"].Value.ToString()+" esta repetido y no se tomara en cuenta");
                    continue;
                }
                
            }
        }

        private void checkboxeliminaractiva(object sender, DataGridViewCellEventArgs e)
        {
            int chequiados = 0;
            foreach (DataGridViewRow row in dtGridView_ProductosdelProveedor.Rows)          //recorro todo el datagridview

            {

                if (row.Cells["ELIMINAR"].Value != null && (bool)row.Cells["ELIMINAR"].Value == true)      //cuento cuantos valores tienen el checkbox marcado

                {
                    chequiados = chequiados + 1;
                    break;              //rompo el loop para no tener que recorrer toda la lista (parece buena idea)
                }


            }
            if (chequiados >= 1)      //si los valores que conte son mas o iguales a uno activo el boton de eliminar
            {
                btn_deleteproductproveedor.Enabled = true;
            }
            else          //de modo contrario lo desactivo
            {
                btn_deleteproductproveedor.Enabled = false;

            }
        }

        private void btn_deleteproductproveedor_Click(object sender, EventArgs e)
        {
            string id_proveedor = txt_idproveedor.Text.ToString();
            foreach (DataGridViewRow row in dtGridView_ProductosdelProveedor.Rows)
            {
                if (row.Cells["ELIMINAR"].Value != null && (bool)row.Cells["ELIMINAR"].Value == true)

                {
                    int id_produto = Int32.Parse(row.Cells["ID_PRODUCTO"].Value.ToString());
                    producto.eliminarproductosdelproveedor(id_produto.ToString(), id_proveedor);
                }
            }
            MessageBox.Show("Se han eliminado los productos del proveedor satisfactoriamente");
             DataTable productosintermedios = producto.productodeprovedor(id_proveedor);
                
                productos.Clear();
                productos.Columns.Clear();
                
                dtGridView_ProductosdelProveedor.Columns.Clear();
                productos.Columns.Add("ID_PRODUCTO");
                productos.Columns.Add("NOMBRE PRODUCTO");
                productos.Columns.Add("PRECIO");
                productos.Columns.Add("TIPO");
                productos.Columns.Add("CODIGO PRODUCTO");
                productos.Columns[0].ReadOnly = true;
                productos.Columns[1].ReadOnly = true;
                productos.Columns[2].ReadOnly = true;
                productos.Columns[3].ReadOnly = true;
                productos.Columns[4].ReadOnly = true;
                int contador = 0;
                foreach (DataRow fila in productosintermedios.Rows)
                {
                    DataTable pasar=producto.obtenerproductoporid(fila["ID_PRODUCTO"].ToString());  //recien me di cuenta que podia traer los datos a traves de una sola consulta, soy un boludo, de todas maneras dejemoslo porque funciona
                    DataRow nuevo = productos.NewRow();
                    nuevo["ID_PRODUCTO"] = pasar.Rows[0][0].ToString();
                    nuevo["NOMBRE PRODUCTO"] = pasar.Rows[0][1].ToString();
                    nuevo["PRECIO"] = pasar.Rows[0][2].ToString();
                    nuevo["TIPO"] = pasar.Rows[0][3].ToString();
                    nuevo["CODIGO PRODUCTO"] = pasar.Rows[0][4].ToString();
                    productos.Rows.Add(nuevo);
                    contador = contador + 1;
                }
                dtGridView_ProductosdelProveedor.DataSource = productos;
                var columnaeliminar = new DataGridViewCheckBoxColumn();
                columnaeliminar.HeaderText = "ELIMINAR";
                columnaeliminar.Name = "Eliminar";
                columnaeliminar.ReadOnly = false;

                productosintermedios.Clear();

                dtGridView_ProductosdelProveedor.Columns.AddRange(new DataGridViewColumn[] { columnaeliminar });
                cantidaddedatosviejos = dtGridView_ProductosdelProveedor.Rows.Count;
                dtGridView_ProductosdelProveedor.Columns[0].Visible = false;
                deshabilitarotroHeader();

        }

        private void btn_deseleccionar_Click_1(object sender, EventArgs e)
        {
            descargarTextsBox();
        }
    }
}

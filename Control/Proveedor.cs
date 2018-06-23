using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bControl
{
    public class Proveedor
    {
        #region Atributos
        private int id_proveedor;
        private string nombre;
        private string telefono;
        private string direccion;
        private string email;
        #endregion

        #region Getters y Setters
        public int Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
        cDatos.DALProveedor conexionProveedor = new cDatos.DALProveedor();


        #region Metodos
        public bool agregar_Proveedor(string nombre, string telefono, string direccion, string email)
        {
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(telefono)  && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(email)) //el signo de exclamacion niega el resultado de la  condicion, esta linea sirve para comprobar que los campos no esten vacios
            {
                conexionProveedor.Cargar_Proveedor(nombre, telefono, direccion, email);
                return true;
            }
            else
            {
                return false;
            }


        }

        public DataTable obtener_Proveedores()
        {

            DataTable dt_Proveedores = conexionProveedor.listar_Proveedores();
            return dt_Proveedores;

        }

        public void eliminar_Proveedor(int id_proveedor)
        {
            conexionProveedor.eliminar_Proveedor(id_proveedor);
        }

        public bool modificar_Prooveedor(string id_proveedor,string nombre,string telefono,string direccion,string email)
        {
            if (nombre.Length<=50 && telefono.Length<=20 && direccion.Length<=100 && email.Length<=100)
            {
                conexionProveedor.modificar_Proveedor(id_proveedor,nombre,direccion,telefono,email);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}

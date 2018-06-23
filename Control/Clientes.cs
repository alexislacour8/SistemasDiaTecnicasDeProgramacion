using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDatos;

namespace bControl
{
    public class Clientes
    {
        cDatos.DALCliente conexionDALcliente = new cDatos.DALCliente();

        private bool comprobarlogintud(string nombre,string apellido,string email)
        {
            if (nombre.Length<=50 && apellido.Length<=50 && email.Length<=70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable listar_Clientes()
        {
            DataTable clientes=conexionDALcliente.listar_Clientes();
            return clientes;
        }
        public DataTable contar_Clientes()
        {
            DataTable clientes = conexionDALcliente.contar();
            return clientes;
        }

        public bool crear_Cliente(string nombre,string apellido,string email,string tipo)
        {
            if (comprobarlogintud(nombre,apellido,email))
            {
                conexionDALcliente.guardar_Cliente(nombre,apellido,email,tipo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar_Cliente(string id_cliente,string nombre, string apellido, string email, string tipo)
        {
            if (comprobarlogintud(nombre,apellido,email))
            {
                int id = int.Parse(id_cliente);
                conexionDALcliente.modificar_Cliente(id,nombre,apellido,email,tipo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void eliminar_Cliente(string id_cliente)
        {
            int id = int.Parse(id_cliente);
            conexionDALcliente.eliminar_Cliente(id);
        }
    }
}


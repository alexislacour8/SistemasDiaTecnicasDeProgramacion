using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using cDatos;

namespace bControl
{

    // A esta le tendriamos que cambiar el nombre a PRODUCTO

    public class Listaprod
    {
        cDatos.DALProducto conexion = new cDatos.DALProducto();
        public DataTable productolist()
            {
            DataTable tablaproducto = conexion.obtenerproducto();
            return tablaproducto;
             
            }
        public DataTable productostocks()
        {
            DataTable tablaproducto = conexion.obtenerstocks();
            return tablaproducto;

        }
        public DataTable produccodigo(string codigo)
        {
            DataTable tablaproducto = conexion.obtenercodigo(codigo);
            return tablaproducto;

        }

        public DataTable buscarproducto(string box)
        {
            DataTable tablaproducto = conexion.BUSCAR(box);
            return tablaproducto;

        }


        public bool Agregar(string nombre, string disponiblidad, string precio, string tipo, string codigo_producto)
        {
            
                    conexion.insertarproducto(nombre, disponiblidad, precio, tipo, codigo_producto);
                    return true;
                  
                
               
        }
        public DataTable CONTAR()
        {
            DataTable tablaproducto = conexion.contar();
            return tablaproducto;

        }
        public void actualizar(string nombre, string disponiblidad, string precio, string tipo, string cod_pro)
        {

            conexion.actualizarproducto(nombre, disponiblidad, precio, tipo, cod_pro);




        }
        public void ELIMINAR( string cod_pro)
        {

            conexion.eliminarproducto( cod_pro);



        }

    }
}

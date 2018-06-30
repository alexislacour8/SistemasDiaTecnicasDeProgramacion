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

        public void Agregar(string nombre, string disponiblidad, string precio, string tipo, string codigo_producto)
        {
            
                    conexion.insertarproducto(nombre, disponiblidad, precio, tipo, codigo_producto);
                  
                
               
        }

            
        
    }
}

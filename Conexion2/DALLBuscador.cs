using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDatos
{
    public class DALLBuscador
    {
        Conexion conexion = new Conexion();
        public DataTable intentarbuscarproducto(string producto)
        {
            string comando = string.Format("SELECT ID_PRODUCTO,PRECIO FROM PRODUCTO WHERE HABILITADO = 1 AND NOMBRE LIKE '{0}%' OR COD_PRODUCTO LIKE '{0}%'",producto);
            DataTable lector = conexion.intentarobtener(comando);
            return lector;
        }
    }
}

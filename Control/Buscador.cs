using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bControl
{
    public class Buscador
    {
        cDatos.DALLBuscador conexionbuscador = new cDatos.DALLBuscador();
        public DataTable buscarproducto(string producto)
        {
            DataTable lector = conexionbuscador.intentarbuscarproducto(producto);
            return lector;
        }
    }
}

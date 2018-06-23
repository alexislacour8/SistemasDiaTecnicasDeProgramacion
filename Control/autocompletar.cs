using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bControl
{

    // TOMY 01-06-2018=ESTO HAY QUE PASARLO A UNA CLASE DE BUSCADOR (BUENA SUGERENCIA)

    public class autocompletar
    {
        
        SqlCommand dr;
        SqlDataReader cnr;


        SqlConnection cmm = new SqlConnection("Data Source=TCL;Initial Catalog=sistemadia;Integrated Security=True");
          



        
        public void AutoCompletar(TextBox cajaTexto)
        {
            try
            {
                dr = new SqlCommand("select NOMBRE from PRODUCTO where HABILITADO = 1", cmm);
                cmm.Open();
                cnr = dr.ExecuteReader();
                while (cnr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(cnr["NOMBRE"].ToString());
                }
                cmm.Close();
            }
            catch (Exception con)
            {
                MessageBox.Show("no se pudo autocompletar" + con.ToString());
            }
        }

    }
}

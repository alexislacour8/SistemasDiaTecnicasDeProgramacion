using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace cDatos
{
    public class DALUsuario
    {
        cDatos.Conexion conexion = new cDatos.Conexion();
        public bool comprobarUsuario(string user, string password) {

            string dbPassword, dbHash;
            string dbData;
            
            
            string consultarusuario = string.Format("SELECT TOP 1 CONVERT(VARCHAR(MAX),DECRYPTBYPASSPHRASE('password',PASSWORD)) AS PASSWORD FROM USUARIO WHERE DNI={0} AND HABILITADO=1", user);
            DataTable tabla = conexion.LeerPorComando(consultarusuario); 
            if (tabla.Rows.Count != 0)
            {
                dbData = tabla.Rows[0]["PASSWORD"].ToString();
                string[] dbDatapro = dbData.Split(',');
                dbHash = dbDatapro[0];
                dbPassword = dbDatapro[1];
                var md5 = new MD5CryptoServiceProvider();
                var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(password + dbHash));
                string md5encodificando = BitConverter.ToString(md5data).Replace("-", "").ToLower();
                if (md5encodificando == dbPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }


        }
        public string obtenerPermiso(string usuario)
        {
            string permiso;
            string consultapermiso = string.Format("SELECT TOP 1 CARGO FROM USUARIO WHERE DNI='{0}'",usuario);
            DataTable tablapermiso = conexion.LeerPorComando(consultapermiso);
            permiso = tablapermiso.Rows[0][0].ToString();
            return permiso;
            
        }
        public int obtenerID(string usuario)
        {
            int id;
            string consultaid = string.Format("SELECT TOP 1 ID_USUARIO FROM USUARIO WHERE DNI='{0}'", usuario);
            DataTable tablaid = conexion.LeerPorComando(consultaid);
            string idstring = tablaid.Rows[0][0].ToString();
            Int32.TryParse(idstring,out id);
            return id;
        }
        public string obtenerUser(string nombre)
        {
            string user;
            string consultapermiso = string.Format("SELECT TOP 1 NOMBRE FROM USUARIO WHERE DNI='{0}'", nombre);
            DataTable tablapermiso = conexion.LeerPorComando(consultapermiso);
            user = tablapermiso.Rows[0][0].ToString();
            return user;

        }
        public DataTable obtenerusuarios()
        {
            string consultausuarios ="SELECT ID_USUARIO,DNI,PASSWORD,CARGO,NOMBRE,APELLIDO FROM USUARIO WHERE HABILITADO=1";
            DataTable usuariosresultado = conexion.LeerPorComando(consultausuarios);
            return usuariosresultado;
        }

        public bool comprobarusuarioexistente(string username) {
            string comprobarexistente = String.Format("SELECT DNI FROM USUARIO WHERE DNI='{0}' AND HABILITADO=1",username);
            DataTable tabladeexistentes = conexion.LeerPorComando(comprobarexistente);
            int numeroDeExistentes = tabladeexistentes.Rows.Count;
            if (numeroDeExistentes==0) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void insertarnuevousuario(string username,string password, string permiso, string nombre, string apellido)
        {
            Int64 dni;
            Int64.TryParse(username,out dni);

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0]=conexion.crearParametro("@dni",dni);
            parametros[1]=conexion.crearParametro("@contra",password);
            parametros[2]=conexion.crearParametro("@cargo",permiso);
            parametros[3]=conexion.crearParametro("@nombre",nombre);
            parametros[4]=conexion.crearParametro("@apellido",apellido);

            conexion.EscribirPorStoreProcedure("REGISTRARUSUARIO", parametros);
        }
        public void modificarnuevousuario(string username, string password, string permiso, string nombre, string apellido)
        {
            Int64 dni;
            Int64.TryParse(username, out dni);

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = conexion.crearParametro("@dni", dni);
            parametros[1] = conexion.crearParametro("@contra", password);
            parametros[2] = conexion.crearParametro("@cargo", permiso);
            parametros[3] = conexion.crearParametro("@nombre", nombre);
            parametros[4] = conexion.crearParametro("@apellido", apellido);

            conexion.EscribirPorStoreProcedure("MODIFICAR_USUARIO", parametros);
        }
    }
}

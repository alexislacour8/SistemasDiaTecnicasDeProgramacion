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
    public class Usuario
    {
        #region Atributos
        private string str_usernombre, str_userpermiso,str_nombre;
        private int int_iduser;
        #endregion

        cDatos.DALUsuario conexionusuario = new cDatos.DALUsuario();

        #region Getters y Setters
        public int Int_iduser
        {
            get { return int_iduser; }
            set { int_iduser = value; }
        }
        public string Str_usernombre
        {
            get { return str_usernombre; }
            set { str_usernombre = value; }
        
        }

        public string Str_nombre
        {
            get { return str_nombre; }
            set { str_nombre = value; }
        }
        public string Str_userpermiso
        {
            get { return str_userpermiso; }
            set { str_userpermiso = value; }
        }
        #endregion

        #region Metodos
        public bool ingresar(string username,string password) {
            
            
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password) && conexionusuario.comprobarUsuario(username,password)) {
                this.str_usernombre = username;
                this.str_userpermiso = conexionusuario.obtenerPermiso(username);
                this.int_iduser = conexionusuario.obtenerID(username);
                this.str_nombre = conexionusuario.obtenerUser(username);
                return true;
            }
            else
            {
                return false;
            }
           

        }
        public DataTable listarusuarios()
        {
            DataTable tabladeusuarios =conexionusuario.obtenerusuarios();
            return tabladeusuarios;
        }
        public bool crearnuevousuario(string username,string password,string nombre, string apellido, string permiso) {

            if (!string.IsNullOrEmpty(username) & !string.IsNullOrEmpty(password) & !string.IsNullOrEmpty(nombre) & !string.IsNullOrEmpty(apellido) & !string.IsNullOrEmpty(permiso))
            {
                if (conexionusuario.comprobarusuarioexistente(username))
                {
                    string passwordsinhashear = password;
                    var bytes = new byte[16];
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(bytes);
                    }
                    string randomSalt = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                    var md5 = new MD5CryptoServiceProvider();
                    var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(passwordsinhashear + randomSalt));
                    string passwordhasheada = BitConverter.ToString(md5data).Replace("-", "").ToLower();

                    string passwordhasheadayconsalt = randomSalt + "," + passwordhasheada;

                    conexionusuario.insertarnuevousuario(username,passwordhasheadayconsalt,permiso,nombre,apellido);

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

        #endregion
    }
}


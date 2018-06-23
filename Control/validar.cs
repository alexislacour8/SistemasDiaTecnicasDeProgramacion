using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace bControl
{
    public class validar
    {
        // funcion validar con solo letras que tiene como evento keypress 
        public static void sololetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("")) ;
            else
            {
                e.Handled = true;
                MessageBox.Show("solo letras");
            }
        }
        public static void solonumero(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("solo numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static void solonumeroycomas(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals(".")) ;
            else
            {
                v.Handled = true;
                MessageBox.Show("solo numero y comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

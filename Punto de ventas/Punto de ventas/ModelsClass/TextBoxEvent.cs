using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_ventas.ModelsClass
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //codicion que solo nos permite usar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite usar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite usar la tecla backspace
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
        }

        public void numberDecimalKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            //codicion que solo nos permite usar datos de tipo numerico
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite usar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //condicion que nos permite usar la tecla backspace
            else if ((e.KeyChar == '.') && (!textBox.Text.Contains("."))) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

using Punto_de_ventas.Connection;
using Punto_de_ventas.ModelsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_ventas
{
    public partial class Form1 : Form
    {
        TextBoxEvent evento = new TextBoxEvent();
        Cliente cliente = new Cliente();
        private string accion = "insert", paginas = "4", deudaActual, Pago, dia,
        fecha;

        

        public Form1()
            {

                InitializeComponent();

            /***********************************************
            *                                              *
            *       CODIGO DEL CLIENTE                     * 
            *                                              *
            * **********************************************/
            #region

            radioButton_IngresarCliente.Checked = true;
            radioButton_IngresarCliente.ForeColor = Color.DarkCyan;
            #endregion

        }

        /************************************************
         *                                              *
         *       CODIGO DEL CLIENTE                     * 
         *                                              *
         * **********************************************/
        #region


        
        

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            paginas = "1";
            accion = "insert";
            //llamamos a la pagina nuemro 1 del tabcontrol1
            tabControl1.SelectedIndex = 1;
            //cargarDatos();
            button_Clientes.Enabled = false;
            button_Ventas.Enabled = true;
            button_Productos.Enabled = true;
            button_Compras.Enabled = true;
            button_Dpto.Enabled = true;
            button_Compras.Enabled = true;
        }

        private void radioButton_IngresarCliente_CheckedChanged(object sender, EventArgs e)
        {

            radioButton_IngresarCliente.ForeColor = Color.DarkCyan;
            radioButton_PagosDeudas.ForeColor = Color.Black;
            textBox_Nombre.ReadOnly = false;
            textBox_Apellido.ReadOnly = false;
            textBox_Direccion.ReadOnly = false;
            textBox_Telefono.ReadOnly = false;
            textBox_PagoscCliente.ReadOnly = true;
            label_PagoCliente.Text = "pagos de deudas ";
            label_PagoCliente.ForeColor = Color.DarkCyan;
        }

        private void radioButton_PagosDeudas_CheckedChanged(object sender, EventArgs e)
        {

            radioButton_PagosDeudas.ForeColor = Color.DarkCyan;
            radioButton_IngresarCliente.ForeColor = Color.Black;
            textBox_Nombre.ReadOnly = true;
            textBox_Apellido.ReadOnly = true;
            textBox_Direccion.ReadOnly = true;
            textBox_Telefono.ReadOnly = true;
            textBox_PagoscCliente.ReadOnly = false;

        }

        private void textBox_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "")
            {
                label_Id.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Id.Text = "ID";
                label_Id.ForeColor = Color.Green;
            }
        }

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text == "")
            {
                label_Nombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Nombre.Text = "Nombre completo";
                label_Nombre.ForeColor = Color.Green;
            }
        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Apellido.Text == "")
            {
                label_Nombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Apellido.Text = "Apellido completo";
                label_Apellido.ForeColor = Color.Green;
            }
        }

        private void textBox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        
        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Direccion.Text == "")
            {
                label_Direccion.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Direccion.Text = "Direccion";
                label_Direccion.ForeColor = Color.Green;
            }
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Telefono.Text == "")
            {
                label_Telefono.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Telefono.Text = "Telefono";
                label_Telefono.ForeColor = Color.Green;
            }
        }

        private void textBox_PagoscCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(textBox_PagoscCliente,e);
        }

        private void textBox_PagoscCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PagoscCliente.Text == "")
            {
                label_PagoCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_PagoCliente.Text = "pagos de deudas";
                label_PagoCliente.ForeColor = Color.Green;
            }
        }

        private void button_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (radioButton_IngresarCliente.Checked)
            {
                guardarCliente();
            }
        }
        private void guardarCliente()
        {
            if (textBox_Id.Text == "")
            {
                label_Id.Text = "Ingrese la ID";
                label_Id.ForeColor = Color.Red;
                textBox_Id.Focus();
            }
            else
            {
                if (textBox_Nombre.Text == "")
                {
                    label_Nombre.Text = "Ingrese el nombre completo";
                    label_Nombre.ForeColor = Color.Red;
                    textBox_Nombre.Focus();
                }
                else
                {
                    if (textBox_Apellido.Text == "")
                    {
                        label_Apellido.Text = "Ingrese el apellido completo";
                        label_Apellido.ForeColor = Color.Red;
                        textBox_Apellido.Focus();
                    }
                    else
                    {
                        if (textBox_Direccion.Text == "")
                        {
                            textBox_Direccion.Text = "Ingrese la direccion";
                            textBox_Direccion.ForeColor = Color.Red;
                            textBox_Direccion.Focus();
                        }
                        else
                        {
                            if (textBox_Telefono.Text == "")
                            {
                                textBox_Telefono.Text = "Ingrese el numero de telefono";
                                textBox_Telefono.ForeColor = Color.Red;
                                textBox_Telefono.Focus();
                            }
                            else
                            {
                                string ID = textBox_Id.Text;
                                string Nombre = textBox_Nombre.Text;
                                string Apellido = textBox_Apellido.Text;
                                string Direccion = textBox_Direccion.Text;
                                string Telefono = textBox_Telefono.Text;
                                if (accion == "insert")
                                {
                                    cliente.insertCliente(ID,Nombre,Apellido,Direccion,Telefono);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}

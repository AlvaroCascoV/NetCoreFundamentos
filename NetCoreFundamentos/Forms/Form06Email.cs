using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            this.lblValidacion.Text = "Su correo ";
            string email = txtEmail.Text;
            this.lblValidacion.Text += email;

            //Debemos verificar lo siguiente: 
            //Exista @ 
            //@ ni al inicio ni al final
            //No exista más de una @ 
            //Existe un punto
            //Un punto después de la @ 
            //Dominio de 2 a 3 caracteres

            //tiene @
            if (email.Contains("@"))
            {
                //no esté al inicio ni al final
                if (!email.StartsWith("@") || !email.EndsWith("@"))
                {
                    //cantidad de arrobas
                    int posicionArroba = email.IndexOf("@");
                    if (email.IndexOf("@", posicionArroba + 1) == -1)
                    {
                        //tiene un punto
                        if (email.Contains("."))
                        {
                            //punto después de la @
                            if (email.IndexOf(".", posicionArroba + 1) != -1)
                            {
                                //dominio de 2 a 3 caracteres
                                string dominio = email.Substring(email.LastIndexOf(".") + 1);
                                if (dominio.Length >= 2 && dominio.Length <= 3)
                                {
                                    this.lblValidacion.Text += " es válido";
                                }
                                else
                                {
                                    this.lblValidacion.Text += " no es válido, el dominio no es correcto";
                                }
                            }
                            else
                            {
                                this.lblValidacion.Text += " no es válido, no tiene un punto después de la '@'";
                            }
                        }
                        else
                        {
                            this.lblValidacion.Text += " no es válido, no tiene un punto";
                        }
                    }
                    else
                    {
                        this.lblValidacion.Text += " no es válido, tiene más de una '@'";
                    }
                }
                else
                {
                    this.lblValidacion.Text += " no es válido, la '@' no puede estar al inicio o al final";
                }
            }
            else
            {
                this.lblValidacion.Text += " no es válido, no tiene una '@'";

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            int longitud = isbn.Length;
            int suma = 0;
            if(longitud != 10)
            {
                MessageBox.Show("El ISBN debe tener 10 caracteres");
            }
            else
            {
                for (int i = 0; i < longitud; i++)
                {
                    int numero = int.Parse(isbn[i].ToString());
                    suma += numero * (i + 1);
                }
                if (suma % 11 == 0)
                {
                    this.lblISBN.Text = "ISBN Válido";
                }
                else { 
                    this.lblISBN.Text = "ISBN No Válido";
                }
            }
        }
    }
}

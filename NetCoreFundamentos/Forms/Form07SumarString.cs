using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numeros = txtNumeros.Text;
            int longitud = numeros.Length;
            int suma = 0;
            for (int i=0; i < longitud; i++)
            {
                char caracter = numeros[i];
                suma += int.Parse(caracter.ToString());
                //TAMBIEN SE PUEDE CONVERTIR CON UNA CLASE:
                //suma += Convert.ToInt32(caracter.ToString());
            }
            lblResultado.Text = "La suma de " + numeros + " es: " + suma;
        }
    }
}

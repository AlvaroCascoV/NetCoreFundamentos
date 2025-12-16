using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                int random = new Random().Next(1, 26);
                this.lstNumeros.Items.Add(random);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;
            foreach (int numero in this.lstNumeros.Items)
            {
                suma += numero;
                if (numero % 2 == 0)
                {
                    pares += numero;
                }
                else
                {
                    impares+= numero;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}

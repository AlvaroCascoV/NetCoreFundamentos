using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnAscii_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS CADA NUMERO A SU CHAR CORRESPONDIENTE
                char character = (char)i;
                if (char.IsLetter(character) == true)
                {
                    this.txtLetras.Text += character;
                }
                else if (char.IsNumber(character) == true)
                {
                    this.txtNumeros.Text += character;
                }
                else if (char.IsSymbol(character)== true) 
                {
                    this.txtSimbolos.Text += character;
                }
                else if (char.IsPunctuation(character) == true)
                {
                    this.txtPuntuacion.Text += character;
                }
            }
        }
    }
}

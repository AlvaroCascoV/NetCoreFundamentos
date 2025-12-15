using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosicionX.Text);
            int posY = int.Parse(txtPosicionY.Text);
            this.btnCambiarPosicion.Location = new Point(posX, posY);
        }
        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtColorRojo.Text);
            int verde = int.Parse(txtColorVerde.Text);
            int azul = int.Parse(txtColorAzul.Text);
            
            //CONDICIONALES
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor del rojo debe estar entre 0 y 255");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor del verde debe estar entre 0 y 255");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor del azul debe estar entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}

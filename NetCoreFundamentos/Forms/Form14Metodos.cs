using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }

        //ESTO SERIA LA FORMA CORRECTA DE DEVOLVER UN VALOR, CON UN METODO RETURN
        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            //AL MANDARLO POR VALOR, NO CAMBIAMOS EL VALOR ORIGINAL
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);//por return
            this.GetDobleValor(num);//por valor
            this.lblResultado.Text = num.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Peru;
        }
        //CON LOS OBJETOS, SI MANDAMOS UNA REFERENCIA, PODEMOS MODIFICAR EL OBJETO ORIGINAL
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        //SI PONEMOS ref, MANDAMOS LA DIRECCION DE MEMORIA, Y PODEMOS MODIFICAR EL VALOR ORIGINAL
        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //HAY QUE PONERLO TAMBIEN EN LA LLAMADA
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            lblRaton.Text = "X: " + e.X + "Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA Keys QUE NOS PERMITE
            //ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA DE BORRAR
            char teclaBorrar = (char)Keys.Back;
            //Si lo que escribo no es un digito o no es la tecla de borrar, desactivo el evento de escritura
            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEYPRESS
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA Keys QUE NOS PERMITE
            //ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA DE BORRAR
            char teclaBorrar = (char)Keys.Back;
            //Si lo que escribo no es un digito o no es la tecla de borrar, desactivo el evento de escritura
            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEYPRESS
                e.Handled = true;
            }
        }
    }
}

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
    }
}

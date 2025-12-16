using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//Los namespace necesarios para trabajar con StringBuilder y medir tiempos
using System.Text;
using System.Diagnostics;

namespace NetCoreFundamentos.Forms
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            
            //COMENZAMOS EL PROCESO
            krono.Start();
            for (int i = 0; i < longitud ; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO Stopwatch CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMRPOBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + 
                                  ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE STRINGBUILDER
            StringBuilder cadena = new StringBuilder();
            //PARA AÑADIR CONTENIDO, TIENE UN METODO LLAMADO Append
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;

            //COMENZAMOS EL PROCESO
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO Stopwatch CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMRPOBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds +
                                  ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}

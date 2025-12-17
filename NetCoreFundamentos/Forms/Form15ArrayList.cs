using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //VAMOS A CREAR UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //SI DESEAMOS ACCEDER A UN OBJETO Y MODIFICAR ALGUNA CARACTERISTICA
            //coleccion[0].BackColor = Color.Aqua;
            //NECESITAMOS REALIZAR UN CASTING
            ((Button)coleccion[0]).BackColor = Color.Yellow;

            //PODEMOS REALIZAR CASTINGS CON foreach
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.Aqua;
            }

            //Y SI AGREGAMOS OTRO CONTROL QUE NO SEA UN BUTTON??
            coleccion.Add(this.textBox1);
            //compila pero rompe en ejecucion si no le ponemos
            //la clase Control que sirve para abstraer todos los controles
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.Aqua;
                //CUANDO TENEMOS MULTIPLES OBJETOS DE DIFERENTES CLASES,
                //NOS PODEMOS ABSTRAER EN EL RECORRIDO, PERO A LO MEJOR
                //NECEISTAMOS ALGUNA CARACTERISTICA ESPECIAL DE CADA UNO
                //UNA CAJA TIENE UN METODO LLAMADO Paste() QUE UN BUTTON NO 
                //comprobamos si es una caja de texto
                if (boton is TextBox)
                {
                    //aun asi necesitamos hacer un casting
                    ((TextBox)boton).Paste();
                }
            }
        }
    }
}

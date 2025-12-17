using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            
            //INICIALIZAMOS LA VARIABLE CONTADOR
            this.contador = 0;

            //ALMACENAMOS TODOS LOS BOTONES EN UNA NUEVA COLECCION
            List<Button> botones = new List<Button>();
            //botones.Add(button1);
            //botones.Add(button2);
            //botones.Add(button3);
            //botones.Add(button4);
            //botones.Add(button5);
            //botones.Add(button6);

            //PODEMOS AÑADIR DINAMICAMENTE TODOS LOS BOTONES DEL FORMULARIO
            foreach (Control control in this.Controls)
            {
                //PREGUNTAMOS SI EL CONTROL ES UN BOTON
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
            }


            //VAMOS A CREAR UN METODO PARA QUE TODOS LOS BOTONES
            //LEAN AL SER PULSADOS
            foreach (Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();

            //QUEREMOS ACCEDER AL OBJETO QUE HA REALIZADO
            //LA PETICION AL METODO. MEDIANTE sender SE CAPTURA DICHO OBJETO (hay que hacer casting)
            ((Button)sender).BackColor = Color.Peru;
        }
    }
}

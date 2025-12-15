using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetCoreFundamentos.Forms
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        public void btnFecha_click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anyo = int.Parse(txtAno.Text);

            if (mes == 1)
            {
                mes = 13;
                anyo = anyo - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo = anyo - 1;
            }

            //Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int operacion1 = ((mes + 1) * 3) / 5;
            //Dividir el año entre 4
            int operacion2 = anyo / 4;
            //Dividir el año entre 100
            int operacion3 = anyo / 100;
            //Dividir el año entre 400
            int operacion4 = anyo / 400;
            //Sumar el día, el doble del mes, el año, el resultado de la operación 1,
            //el resultado de la operación 2, menos el resultado de la operación 3 más la operación 4 más 2
            int operacion5 = dia + (mes * 2) +anyo+ operacion1 + operacion2 - operacion3 + operacion4 + 2;
            //Dividir el resultado anterior entre 7.
            int operacion6 = operacion5 / 7;
            //Restar el número del paso 5 con el número del paso 6 por 7.
            int operacion7 = operacion5 - (operacion6*7);
            string diaSemana = "";

            if (operacion7 == 0) {diaSemana = "Sábado"; }
            else if (operacion7 == 1) {diaSemana = "Domingo";}
            else if (operacion7 == 2) {diaSemana = "Lunes";}
            else if (operacion7 == 3) {diaSemana = "Martes";}
            else if (operacion7 == 4) {diaSemana = "Miércoles";}
            else if (operacion7 == 5) {diaSemana = "Jueves";}
            else if (operacion7 == 6) {diaSemana = "Viernes"; } else { diaSemana = "ERROR LOGICO"; }
            lblResultado.Text = "El día de la semana es " + diaSemana;
        }
    }
}

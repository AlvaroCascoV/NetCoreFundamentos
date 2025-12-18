using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        List<Button> botones;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            this.botones = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    this.cajas.Add(textBox);
                }
                if (control is Button)
                {
                    Button button = (Button)control;
                    this.botones.Add(button);
                    control.Click += MostrarTablaMultiplicar;
                }
            }
        }

        private void MostrarTablaMultiplicar(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            int contador = 1;

            for (int i = cajas.Count - 1; i >= 0; i--)
            {
                int resultado = numero * contador;
                cajas[i].Text = resultado.ToString();
                contador++;
            }
        }
    }
}

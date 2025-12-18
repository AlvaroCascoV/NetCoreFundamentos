using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form18SumarCheckbox : Form
    {
        //Si seleccionamos, sumamos, si desmarcamos, restamos.
        List<CheckBox> checkBoxes;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checkBoxes = new List<CheckBox>();
            foreach (CheckBox chk in this.panel1.Controls)
            {
                this.checkBoxes.Add(chk);
                chk.CheckedChanged += SumarNumeros;
            }
        }
        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox chkPulsado = (CheckBox)sender;
            int numero = int.Parse(chkPulsado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            
            if (chkPulsado.Checked)
            {
                suma += numero;
            }
            else
            {
                suma -= numero;
            }
            this.txtSuma.Text = suma.ToString();
        }

        private void btnInicarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox chk in this.checkBoxes)
            {
                int aleat = random.Next(1, 50);
                chk.Text = aleat.ToString();
            }
        }
    }
}

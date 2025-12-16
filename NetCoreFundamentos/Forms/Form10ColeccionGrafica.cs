using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtNuevoElemento.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL ELEMENTO SELECCIONADO DE LA LISTA
            //string elementoSeleccionado = this.lstElementos.SelectedItem.ToString();
            //ELIMINAMOS EL OBJETO DE LA COLECCION
            //this.lstElementos.Items.Remove(elementoSeleccionado); (si hay repes,este quita el primero que encuentra)
            int index = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(index);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblItem.Text = "Item seleccionado: " + this.lstElementos.SelectedIndex.ToString();
                this.lblIndex.Text = "Index: " + this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}

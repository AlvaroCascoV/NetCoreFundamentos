using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //LA LISTA TENDRA MULTIPLE SELECCION
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            //UNA VENTAJA DEL foreach ES QUE PODEMOS RECORRER Y
            //HACER CASTING DE LOS OBJETOS A LA VEZ
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }
            //VISUALIZAMOS LOS INDICES SELECCIONADOS
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index.ToString() + ",";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //QUIERO ELIMINAR LOS ELEMENTOS SELECCIONADOS
            //PARA LAS ACCIONES SOBRE LAS COLECCIONES SIEMPRE
            //CON BUCLES DE CONTADOR PARA EVITAR BUCLES INFINITOS
            //VOY A UTILIZAR EL METODO RemoveAt POR LO QUE RECORREMOS
            //LA COLECCION SelectedIndices
            //for (int i= 0; i<this.lstElementos.SelectedIndices.Count; i++)
            //{
            //    int index = this.lstElementos.SelectedIndices[i];
            //    //ELIMINAMOS DE LA COLECCION
            //    this.lstElementos.Items.RemoveAt(index);
            //}
            //HAY QUE HACERLO AL REVES PARA QUE NO DE ERROR AL ELIMINAR
            int numElementos = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                //ELIMINAMOS DE LA COLECCION
                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}

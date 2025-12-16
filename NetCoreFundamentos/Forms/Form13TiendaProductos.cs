using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos.Forms
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string elemento = this.txtItem.Text;
            this.lstTienda.Items.Add(elemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndex);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int longitud = this.lstTienda.SelectedIndices.Count;
            for (int i = longitud - 1; i >= 0; i--)
            {
                var item = this.lstTienda.SelectedItems[i];
                this.lstAlmacen.Items.Add(item);
                this.lstTienda.Items.Remove(item);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.Items.Count - 1; i >= 0; i--)
            {
                var item = this.lstTienda.Items[i];
                this.lstAlmacen.Items.Add(item);
                this.lstTienda.Items.Remove(item);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                int indice = this.lstAlmacen.SelectedIndex;
                object item = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.Insert(indice - 1, item);
                this.lstAlmacen.Items.RemoveAt(indice + 1);
                this.lstAlmacen.SelectedIndex = indice - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            {
                int indice = this.lstAlmacen.SelectedIndex;
                object item = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.Insert(indice + 2, item);
                this.lstAlmacen.Items.RemoveAt(indice);
                this.lstAlmacen.SelectedIndex = indice + 1;
            }
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                this.btnSubir.Enabled = true;
            }
            else
            {
                this.btnSubir.Enabled = false;
            }
            if (this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = true;
            }
            else
            {
                this.btnBajar.Enabled = false;
            }
        }
    }
}

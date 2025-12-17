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
                int index = this.lstTienda.SelectedIndices[i];
                string item = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(item);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //EXISTE UN METODO PARA AÑADIR MULTIPLES ELEMENTOS A UNA COLECCION
            //AddRange
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();

            //for (int i = this.lstTienda.Items.Count - 1; i >= 0; i--)
            //{
            //    var item = this.lstTienda.Items[i];
            //    this.lstAlmacen.Items.Add(item);
            //    this.lstTienda.Items.Remove(item);
            //}
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                int indice = this.lstAlmacen.SelectedIndex;
                string item = this.lstAlmacen.SelectedItem.ToString();
                this.lstAlmacen.Items.RemoveAt(indice);
                this.lstAlmacen.Items.Insert(indice - 1, item);
                this.lstAlmacen.SelectedIndex = indice - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            {
                int indice = this.lstAlmacen.SelectedIndex;
                object item = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.RemoveAt(indice);
                this.lstAlmacen.Items.Insert(indice + 1, item);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos.Forms
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        //creamos el helper nuestro
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            //instanciamos el helper
            this.helper = new HelperFiles();

            //CUANDO HABLAMOS DE RUTAS O CARACTERES ESPECIALES
            //DENTRO DE STRING, TENEMOS DOS FORMAS DE ESCRIBIR DICHOS CARACTERES
            //1) C:\carpeta\1.txt
            //this.Path = "C:\\carpeta\\1.txt"; //Usamos doble barra
            //2) Utilizar @ antes del String y fuera del String
            //this.Path = @"C:\carpeta\1.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            ////TENEMOS UNA CLASE LLAMADA FileInfo QUE NOS DEVUELVE UN FILE
            ////Y PODEMOS GENERAR UN WRITER/READER
            //FileInfo file = new FileInfo(this.Path);
            ////CREAMOS EL FICHERO
            //using (TextWriter writer = file.CreateText()) 
            //{
            //    //aqui sabemos que el objeto ya está creado gracias al using
            //    string content = this.GetNombresListBox();
            //    //ESCRIBIMOS EN EL FICHERO
            //    await writer.WriteAsync(content);
            //    //DESPUES DE ESCRIBIR, DEBEMOS LIBERAR LA MEMORIA PARA HACERLO FIJO
            //    await writer.FlushAsync();
            //    //CERRAMOS EL FICHERO
            //    writer.Close();
            //    MessageBox.Show("Fichero almacenado");
            //}

            //usando nuestro helper
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string content = await reader.ReadToEndAsync();
            //    reader.Close();
            //    this.txtContenido.Text = content;
            //}

            //usando nuestro helper
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
        }
    }
}

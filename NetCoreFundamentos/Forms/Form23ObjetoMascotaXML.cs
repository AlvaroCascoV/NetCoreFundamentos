using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace NetCoreFundamentos.Forms
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(ProyectoClases.Models.Mascota));
        }
        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            //necesitamos guardar la imagen en un array de bytes
            mascota.Imagen = File.ReadAllBytes(this.openFileDialog1.FileName);
            //LAS CLASES QUE SE UTILIZAN SON DE TIPO STREAM
            //PARA ESCRIBIR NECESITAMOS LA CLASE StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();
            this.pictureBox1.Image = null;
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                //necesito mostrar una imagen previamente guardada
                using(MemoryStream imagen = new MemoryStream(mascota.Imagen))
                { 
                    this.pictureBox1.Image = Image.FromStream(imagen);
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //ABRIR EL OPENFILE PARA SELECCIONAR LA IMAGEN
            this.openFileDialog1.ShowDialog();
            //RECUPERAMOS LA RUTA DE LA IMAGEN
            string path = this.openFileDialog1.FileName;
            //DIBUJAMOS LA IMAGEN EN EL FORM
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}

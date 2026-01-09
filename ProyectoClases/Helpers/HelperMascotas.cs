using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        private void ConvertirMascotasList(string data)
        {
            //tenemos GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ,
                string[] propiedades = stringMascota.Split(',');
                //CONVERTIMOS EL TRISTE STRING EN OBJETOS
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //EL PROGRAMADOR ESCRIBA Read Y LEEMOS UN STRING Y RELLENAMOS LA COLECCION

        public async Task LeerMascotasAsync()
        {
            //LEEMOS EL FICHERO DE MASCOTAS
            string data = await this.helper.ReadFileAsync(this.path);
            //CONVERTIMOS EL STRING EN LIST
            this.ConvertirMascotasList(data);
        }

        //CONVERTIMOS LA COLECCION A STRING
        private string ConvertirMascotasString()
        {
            //queremos GARFIELD,GATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ,
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //SEPARAMOS CADA MASCOTA CON @
                data += propiedades + "@";
            }
            //QUITAMOS EL ULTIMO @
            data = data.Trim('@');
            return data;
        }

        //EL PROGRAMADOR ESCRIBA Write Y GUARDAMOS LAS MASCOTAS
        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();
            //ESCRIBIMOS LOS DATOS EN FILE
            await this.helper.WriteFileAsync(this.path, data);
        }
    }
}

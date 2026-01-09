using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }

        //añadido para serializar
        public int Edad { get; set; }

        //añadido para imagen
        public byte[] Imagen { get; set; }
    }
}

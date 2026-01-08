using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //podemos tener varios constructores en una clase
        public Direccion() 
        { 
            Debug.WriteLine("Constructor sin parametros");
        }
        public Direccion(string calle, string ciudad)
        {
            //INICIALIZAMOS LAS VARIABLES DE LA CLASE
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con dos parametros");
        }
        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION con tres parametros");
        }
    }
}

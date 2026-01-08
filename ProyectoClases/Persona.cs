using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public class Persona
    {
        //con esto creamos campos públicos, pero necesitaríamos propiedades
        //public string Nombre;
        //public string Apellidos;
        //public int Edad;

        public string Nombre;
        public string Apellidos;
        //CAMPO DE PROPIEDAD
        private int _Edad;
        //las propiedades van con gets y sets
        public int Edad {
            //DEVOLVEMOS EL VALOR
            get { return this._Edad; }
            //ESTABLECEMOS EL VALOR
            //si cambiamos el valor de Edad dentro de Edad se produce un bucle infinito, usamos el campo de propiedad
            set
            {
                //this.Edad = value;
                //dentro del setter, podemos validar el valor que se asigna
                if (value < 0)
                {
                    //NO NOS GUSTA, LO SOLUCIONAMOS EN SILENCIO (internamente)
                    //this._Edad = 0;
                    //TAMBIÉN PODEMOS LANZAR UNA EXCEPCIÓN
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    //para mejor organización del código, podemos usar regiones (#region NOMBRE, #endregion)
    #region ENUMERACIONES
    
    //LAS ENUMERACIONES ESTAN DENTRO DEL NAMESPACE, PERO FUERA DE LA CLASE
    //internamente se les asignan valores enteros empezando por 0
    public enum TipoGenero { Masculino = 0, Femenino = 1 }
    public enum Paises { España, Francia, Alemania, Andorra, Colombia }
    
    #endregion
    public class Persona
    {
        #region PROPIEDADES
        //si son enum, tienen que ser propiedades extendidas
        public TipoGenero _Genero;
        public Paises _Nacionalidad;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("El género no es válido");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set {
                if(value < Paises.España || value > Paises.Colombia)
                {
                    throw new Exception("La nacionalidad no es válida");
                }
                else
                {
                    this._Nacionalidad = value;
                }
            }
        }

        //con esto creamos campos públicos, pero necesitaríamos propiedades
        //public string Nombre;
        //public string Apellidos;
        //public int Edad;

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
        //PORPIEDADES AUTOIMPLMENTADAS
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        //si les pasas distintos parametros, se consideran métodos distintos (polimorfismo/sobrecarga de métodos)
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + ", " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {//tambien podemos llamar a otros métodos
            return this.GetNombreCompleto().ToLower();
        }

        public void GetNombreCompleto(string dato) { }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    //empleado hereda de Persona
    public class Empleado: Persona
    {
        //para sobrescribir el método en director, tiene que ser virtual
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        //depende de lo que quiera hay que poner public, private, protected o internal al salario
        //en este caso, protected para que lo hereden los directores
        protected int SalarioMinimo { get; set; }

        //aun con un constructor vacio en empleado, no se sustituye el vacio de persona
        //si ponemos un constructor con parámetros, lee el constructor con parámetros de empleado
        //pero antes el vacío de persona (el default) si no llamamos al que queremos explicitamente con ":base"
        //si no hay constructor vacío en persona, da error y obliga a llamar al que hay con ":base"
        public Empleado()
        {
            Console.WriteLine("Constructor EMPLEADO vacío");
            //this.SalarioMinimo = 1000;
            //subimos el salario para ver la herencia en directores
            this.SalarioMinimo = 1600;
        }
        //para poder ver el salario minimo desde fuera de la clase, tengo que crear un método público
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos)
            :base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con dos parámetros");
        }
        public Empleado(string nombre, string apellidos, int edad)
            : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con tres parámetros");
        }
    }
}

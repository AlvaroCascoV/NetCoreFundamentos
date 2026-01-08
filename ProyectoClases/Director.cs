using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR vacío");
            //this.SalarioMinimo = 1200; podemos hardcodedar el salario o hacerlo bien cogiendo el de empleado y subiendolo
            this.SalarioMinimo += 200;
        }
        //METODO VACACIONES SOBRESCRITOs
        //sobrescribimos el método de empleado con override
        public override int GetDiasVacaciones()
        {
            //si queremos sumar a lo que ya hace el empleado, se usa "base.METODO()"
            //LLAMAMOS AL METODO DEL EMPLEADO
            int vacasEmpleado = base.GetDiasVacaciones();

            Debug.WriteLine("GetVacaciones() DIRECTOR");
            //return 30;
            return vacasEmpleado + 8;
        }
    }
}

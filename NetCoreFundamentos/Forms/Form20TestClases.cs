using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos.Forms
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno";
            person.Apellidos = "Reyes";
            person.Edad = 25;
            this.lstClases.Items.Add("Nombre: " + person.Nombre +
                ", Apellidos: " + person.Apellidos +
                ", Edad: " + person.Edad);

            person.Genero = TipoGenero.Femenino;
            person.Nacionalidad = Paises.Andorra;

            this.lstClases.Items.Add("Genero: " + person.Genero +
                ", Nacionalidad: " + person.Nacionalidad);
            //dependiendo que le pase a GetNombreCompleto se comporta diferente
            this.lstClases.Items.Add("Nombre Completo: " + person.GetNombreCompleto(true));

            //si no creamos un objeto, Domicilio es null y da una excepción
            //podemos crear el objeto aqui o en la clase Persona en el constructor
            //si lo creamos aqui, podemos acceder a sus propiedades directamente en la creación
            person.Domicilio = new Direccion("Avenida Enero", "Lugo");

            person.Domicilio.Calle = "Avenida Enero";
            person.Domicilio.Ciudad = "Madrid";
            person.Domicilio.CodigoPostal = 28003;
            this.lstClases.Items.Add("Dirección: "
                + person.Domicilio.Calle + ", "
                + person.Domicilio.Ciudad + ", "
                + person.Domicilio.CodigoPostal);

            //PROPIEDADES INDEXADAS
            person[0] = "Vamos 1";
            person[1] = "Vamos 2";
            this.lstClases.Items.Add("Propiedad indexada 0: " + person[0]);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos="Becario";
            //emp.SalarioMinimo = 4000;
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacas empleado: " + emp.GetDiasVacaciones());

            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacas dire: " + dire.GetDiasVacaciones());

        }
    }
}

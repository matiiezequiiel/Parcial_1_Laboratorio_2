using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado :Persona
    {

        DateTime fechaDeIngreso;
        string puestoEmpleado;
        float sueldoEmpleado;

        public Empleado()
        {
            fechaDeIngreso = new DateTime(1900,01,01);
            this.puestoEmpleado = "Sin puesto";
            this.sueldoEmpleado = 0;
        }    
        public Empleado(string nombre, string apellido,int dni, DateTime fechaDeIngreso,string puesto,float sueldo)
        {
            this.nombrePersona = nombre;
            this.apellidoPersona = apellido;
            this.dniPersona = dni;
            this.fechaDeIngreso = fechaDeIngreso;
            this.puestoEmpleado = puesto;
            this.sueldoEmpleado = sueldo;
        }

        public string NombreEmpleado
        {
            get { return this.nombrePersona; }
            set { this.nombrePersona = value; }
        }

        public string ApellidoEmpleado
        {
            get { return this.apellidoPersona; }
            set { this.apellidoPersona = value; }
        }


        public DateTime FechaIngreso
        {
            get { return this.fechaDeIngreso; }
            set { this.fechaDeIngreso = value; }
        }


        public string PuestoEmpleado
        {
            get { return this.puestoEmpleado; }
            set { this.puestoEmpleado = value; }
        }

        public float SueldoEmpleado
        {
            get { return this.sueldoEmpleado; }
            set { this.sueldoEmpleado = value; }
        }

    }
}

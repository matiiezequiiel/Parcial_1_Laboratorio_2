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
        int[] ticketsVendidos;

        public Empleado()
        {
            fechaDeIngreso = new DateTime(1900, 01, 01);
            ticketsVendidos = new int[10];
            this.puestoEmpleado = "Sin puesto";
            this.sueldoEmpleado = 0;
        }    
        public Empleado(string nombre, string apellido,int dni, DateTime fechaDeIngreso,string puesto,float sueldo,int[] ticketsVendidos )
        {
            
            this.nombrePersona = nombre;
            this.apellidoPersona = apellido;
            this.dniPersona = dni;
            this.fechaDeIngreso = fechaDeIngreso;
            this.puestoEmpleado = puesto;
            this.sueldoEmpleado = sueldo;
            this.ticketsVendidos = ticketsVendidos;
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

        public static List<Empleado> HardcodearEmpleados()
        {
            List<Empleado> empleadosHardcodeados = new List<Empleado>();
            
            
      
            empleadosHardcodeados.Add(new Empleado("Apu", "Nahasamepapetilon", 3937594,new DateTime(2018,03,15),"Administrador",10000,new int[] {1,2,3}));
            empleadosHardcodeados.Add(new Empleado("Manjula", "Nahasamepapetilon", 3934322,new DateTime(2016,01,10), "Administrador", 10000,new int[] { 4, 5, 6 }));
            empleadosHardcodeados.Add(new Empleado("Sanjay", "Nahasamepapetilon", 3937594,new DateTime(2018,03,15),"Cajero",10000, new int[] { 1, 2 }));
            empleadosHardcodeados.Add(new Empleado("Pahusacheta", "Nahasamepapetilon", 3937594,new DateTime(2018,03,15),"Cajero",10000, new int[] { 4, 5, 6 }));
            empleadosHardcodeados.Add(new Empleado("Jamshed", "Nahasamepapetilon", 3937594,new DateTime(2018,03,15),"Cajero",10000, new int[] { 4, 5, 6 }));
                        
            return empleadosHardcodeados;

        }

        public static Dictionary<string,string> HardcodearUsuariosYPass()
        {
            Dictionary<string, string> miDiccionario = new Dictionary<string, string>();
            miDiccionario.Add("Apu", "Pass1");
            miDiccionario.Add("Manjula", "Pass2");
            miDiccionario.Add("Sanjay", "Pass3");
            miDiccionario.Add("Pahusacheta", "Pass4");
            miDiccionario.Add("Jamshed", "Pass5");

            return miDiccionario;
        }



        

    }
}

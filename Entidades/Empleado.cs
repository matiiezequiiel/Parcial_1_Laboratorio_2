﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos
        DateTime fechaDeIngreso;
        string puestoEmpleado;
        float sueldoEmpleado;
        int[] ticketsVendidos;
        #endregion

        #region constructores
        //private Empleado()
        //{
        //    fechaDeIngreso = new DateTime(1900, 01, 01);
        //    ticketsVendidos = new int[10];
        //    this.puestoEmpleado = "Sin puesto";
        //    this.sueldoEmpleado = 0;
        //}
        private Empleado(string nombre, string apellido, int dni, DateTime fechaDeIngreso, 
                        string puesto, float sueldo, int[] ticketsVendidos):base(nombre,apellido, dni)

        {

         //   this.nombrePersona = nombre;
         //   this.apellidoPersona = apellido;
          //  this.dniPersona = dni;
            this.fechaDeIngreso = fechaDeIngreso;
            this.puestoEmpleado = puesto;
            this.sueldoEmpleado = sueldo;
            this.ticketsVendidos = ticketsVendidos;
        }
        #endregion

        //private DateTime FechaIngreso
        //{
        //    get { return this.fechaDeIngreso; }
        //    set { this.fechaDeIngreso = value; }
        //}

        #region propiedades
        public string PuestoEmpleado
        {
            get { return this.puestoEmpleado; }
         //   set { this.puestoEmpleado = value; }
        }

        public int[] TicketsEmpleado
        {
            get { return this.ticketsVendidos; }
         //   set {this.ticketsVendidos = value; }
        }

        #endregion

        #region Metodos
        public static List<Empleado> HardcodearEmpleados()
        {
            List<Empleado> empleadosHardcodeados = new List<Empleado>();

            empleadosHardcodeados.Add(new Empleado("Apu", "Nahasamepapetilon", 3937594, new DateTime(2018, 03, 15), "Administrador", 10000, new int[10] { 1, 2, 3, 0, 0, 0, 0, 0, 0, 0 }));
            empleadosHardcodeados.Add(new Empleado("Manjula", "Nahasamepapetilon", 3934322, new DateTime(2016, 01, 10), "Administrador", 10000, new int[10] { 4, 5, 6, 0, 0, 0, 0, 0, 0, 0 }));
            empleadosHardcodeados.Add(new Empleado("Sanjay", "Nahasamepapetilon", 3937594, new DateTime(2018, 03, 15), "Cajero", 10000, new int[10] { 1, 2, 0, 0, 0, 0, 0, 0, 0, 0 }));
            empleadosHardcodeados.Add(new Empleado("Pahusacheta", "Nahasamepapetilon", 3937594, new DateTime(2018, 03, 15), "Cajero", 10000, new int[10] { 4, 5, 6, 0, 0, 0, 0, 0, 0, 0 }));
            empleadosHardcodeados.Add(new Empleado("Jamshed", "Nahasamepapetilon", 3937594, new DateTime(2018, 03, 15), "Cajero", 10000, new int[10] { 4, 5, 6, 0, 0, 0, 0, 0, 0, 0 }));

            return empleadosHardcodeados;

        }

        public static Dictionary<string, string> HardcodearUsuariosYPass()
        {
            Dictionary<string, string> miDiccionario = new Dictionary<string, string>();
            miDiccionario.Add("Apu Nahasamepapetilon", "Pass1");
            miDiccionario.Add("Manjula Nahasamepapetilon", "Pass2");
            miDiccionario.Add("Sanjay Nahasamepapetilon", "Pass3");
            miDiccionario.Add("Pahusacheta Nahasamepapetilon", "Pass4");
            miDiccionario.Add("Jamshed Nahasamepapetilon", "Pass5");

            return miDiccionario;
        }

        public override string DatosPersona()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del empleado: {0}\n", this.nombrePersona);
            sb.AppendFormat("Apellido del empleado: {0}\n", this.apellidoPersona);
            sb.AppendFormat("DNI del empleado: {0}\n", this.DniPersona);
            sb.AppendFormat("Fecha de ingreso del empleado: {0}\n", this.fechaDeIngreso);
            sb.AppendFormat("Puesto del empleado: {0}\n", this.puestoEmpleado);
            sb.AppendFormat("Sueldo del empleado: {0}\n", this.sueldoEmpleado);

            return sb.ToString();
        }
        #endregion

    }


}

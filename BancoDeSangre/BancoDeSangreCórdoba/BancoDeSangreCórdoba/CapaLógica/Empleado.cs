using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaLógica
{
    public class Empleado
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int idSeccion;

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Empleado(int legajo, string nombre, string apellido, DateTime fechaNacimiento, int idSeccion)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.idSeccion = idSeccion;
        }

        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public int Seccion
        {
            get => idSeccion;
            set => idSeccion = value;
        }
    }
}

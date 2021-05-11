using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaLógica
{
    public class Gerencias
    {
        private int idGer;
        private string nombre;
        private int idDir;
        private int legSup;

        public Gerencias()
        {
        }

        public Gerencias(int idGer, string nombre, int idDir, int legSup)
        {
            this.idGer = idGer;
            this.nombre = nombre;
            this.idDir = idDir;
            this.legSup = legSup;

        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public int IdGer
        {
            get => idGer;
            set => idGer = value;
        }
        public int IdDir
        {
            get => idDir;
            set => idDir= value;
        }
        public int LegSup
        {
            get => legSup;
            set => legSup = value;
        }

    }
    
}

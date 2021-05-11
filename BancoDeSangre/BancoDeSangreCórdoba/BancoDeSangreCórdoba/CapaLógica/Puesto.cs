using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaLógica
{
    public class Puesto
    {
        private int id;
        private string letra;

        public Puesto( string  let, int id)
        {
            
            this.letra = let;
            this.id = id;
        }

        public int id_puesto
        {
            get => id;
            set =>  id = value;
        }

        public string letraPuesto
        {
            get => letra;
            set => this.letra = value;
        }
    }
}

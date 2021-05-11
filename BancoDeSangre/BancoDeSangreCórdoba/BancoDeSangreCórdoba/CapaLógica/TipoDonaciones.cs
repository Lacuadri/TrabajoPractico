using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaLógica
{
    public class TipoDonaciones
    {
        public int id;
        public string nombreTipoDonacion;

        public TipoDonaciones()
        {
        }

        public TipoDonaciones(string nombre, int id)
        {
            this.nombreTipoDonacion = nombre;
            this.id = id;
        }
        public int id_TipoDonaciones
        {
            get => id;
            set => id = value;
        }

        public string nombreTiposDonaciones
        {
            get => nombreTipoDonacion;
            set => nombreTipoDonacion = value;
        }

    }
}

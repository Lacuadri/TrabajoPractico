using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación
{
    public partial class FormAcercaSistema : Form
    {
        public FormAcercaSistema()
        {
            InitializeComponent();
            lblIntegrantesGrupo10.Text = Texto();
        }

        private string Texto()
        {
            string listado;
            listado = "Farid Álvarez - Legajo: 81801" + '\r' + '\n';
            listado += "Jaquelina Aramayo - Legajo: 63394" + '\r' + '\n';
            listado += "David Borgogno - Legajo: 83431" + '\r' + '\n';
            listado += "Franco Lacuadri - Legajo: 82032" + '\r' + '\n';
            listado += "Lucas Santiago Paninka - Legajo: 82502" + '\r' + '\n';
            listado += "Álvaro Reartes - Legajo: 75481" + '\r' + '\n';
            listado += "Dalila Rojo - Legajo: 81846" + '\r' + '\n';
            listado += "Diego Claudio romero - Legajo: 58189" + '\r' + '\n';
            listado += "Elías Velardez - Legajo: 81802" + '\r' + '\n';
            return listado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación.ABMEmpleados
{
    public partial class FrmABMEmpleados : Form
    {
        public FrmABMEmpleados()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaEmpleado ventana = new FrmAltaEmpleado();
            ventana.ShowDialog();
        }
        private void PicModificar_Click(object sender, EventArgs e)
        {
            FrmModificarEmpleado ventana = new FrmModificarEmpleado();
            ventana.ShowDialog();
        }
        private void PicBorrar_Click(object sender, EventArgs e)
        {
            FrmBajaEmpleado ventana = new FrmBajaEmpleado();
            ventana.ShowDialog();
        }

       
    }
}

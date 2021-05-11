using BancoDeSangreCórdoba.CapaLógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación.ABMGerencias
{
    public partial class FormBajaGerencias : Form
    {
        Gerencias ger; 
        public FormBajaGerencias(Gerencias g)
        {
            InitializeComponent();
            ger = g;
            txtNombreGerenciaBaja.Enabled = false;
            txtLegajoBaja.Enabled = false;
            txtIdDireccionBaja.Enabled = false;

            txtIdDireccionBaja.Text = g.IdDir.ToString();
            txtNombreGerenciaBaja.Text = g.Nombre;
            txtLegajoBaja.Text = g.LegSup.ToString();
        }

        private void btnCancelarBaja_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

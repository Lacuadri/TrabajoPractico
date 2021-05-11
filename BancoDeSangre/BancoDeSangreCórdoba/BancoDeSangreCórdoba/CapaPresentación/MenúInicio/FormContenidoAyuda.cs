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
    public partial class FormContenidoAyuda : Form
    {
        private int avanzar;
        private int retroceder;

        public FormContenidoAyuda()
        {
            InitializeComponent();
            avanzar = 0;
            retroceder = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            avanzar++;
            switch (avanzar)
            {
                case 1:
                    lblMensaje.Text = "Página 1";
                    break;
                case 2:
                    lblMensaje.Text = "Página 2";
                    break;
                case 3:
                    lblMensaje.Text = "Página 3";
                    break;
                case 4:
                    lblMensaje.Text = "Página 4";
                    break;
                case 5:
                    lblMensaje.Text = "Página 5";
                    break;
                case 6:
                    lblMensaje.Text = "Página 6";
                    break;
                case 7:
                    lblMensaje.Text = "Página 7";
                    break;
                default:
                    lblMensaje.Text = "FIN";
                    break;
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            retroceder = avanzar;
            switch (retroceder)
            {
                case 1:
                    lblMensaje.Text = "INICIO";
                    avanzar = 0;
                    break;
                case 2:
                    lblMensaje.Text = "Página 1";
                    avanzar = 1;
                    break;
                case 3:
                    lblMensaje.Text = "Página 2";
                    avanzar = 2;
                    break;
                case 4:
                    lblMensaje.Text = "Página 3";
                    avanzar = 3;
                    break;
                case 5:
                    lblMensaje.Text = "Página 4";
                    avanzar = 4;
                    break;
                case 6:
                    lblMensaje.Text = "Página 5";
                    avanzar = 5;
                    break;
                case 7:
                    lblMensaje.Text = "Página 6";
                    avanzar = 6;
                    break;
                default:
                    lblMensaje.Text = "Página 7";
                    avanzar = 7;
                    break;
            }

        }


    }
}

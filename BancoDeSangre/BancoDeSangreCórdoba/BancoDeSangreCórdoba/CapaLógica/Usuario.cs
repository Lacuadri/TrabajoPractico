using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaLógica
{
    public class Usuario
    {
        private string nickname;
        private string password;
        private bool esAdministrador;
        private int legajoUsuario;

        public Usuario()
        {

        }

        public Usuario(string nickname, string password, bool esAdministrador, int legajoUsuario)
        {
            this.nickname = nickname;
            this.password = password;
            this.esAdministrador = esAdministrador;
            this.legajoUsuario = legajoUsuario;
        }

        public string Nickname
        {
            get => nickname;
            set => nickname = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool EsAdministrador
        {
            get => esAdministrador;
            set => esAdministrador = value;
        }
        public int LegajoUsuario
        {
            get => legajoUsuario;
            set => legajoUsuario = value;
        }
    }
}

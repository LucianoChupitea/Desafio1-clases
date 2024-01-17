using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable1_Clases
{
    internal class Usuario
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _Nombreusuario;
        private string _Contraseña;
        private string _Mail;
        public Usuario()
        {

        }

        public Usuario(int id, string nombre, string apellido, string nombreusuario, string contraseña,string mail)
        {
            this._Id = id;
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._Nombreusuario = nombreusuario;
            this._Contraseña = contraseña;
            this._Mail = mail;

        }
        public int Id { get { return _Id; } set { _Id = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string Apellido { get { return _Apellido; } set { _Apellido = value; } }
        public string Nombreusuario { get { return _Nombreusuario; } set { _Nombreusuario = value; } }
        public string Mail { get { return _Mail; } set { _Mail = value; } }











    }
}

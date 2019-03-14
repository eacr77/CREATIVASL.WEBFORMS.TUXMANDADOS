using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
   public class EUsuario
    {
        private string _token;

        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        private string _conexion;

        public string Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        private int _resultado;

        public int Resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }


    }
}

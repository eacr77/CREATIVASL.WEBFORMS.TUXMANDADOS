using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
   public class ValidEmail
    {
        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        private int _valido;

        public int valido
        {
            get { return _valido; }
            set { _valido = value; }
        }
        private string _token;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }

        private string _resultado;
        public string resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
        private string _conexion;
        public string conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        private string _DatosJson;
        public string DatosJson
        {
            get { return _DatosJson; }
            set { _DatosJson = value; }
        }

        public void GenerarJSON()
        {
            _DatosJson += "";
            ValidEmailJson valid = new ValidEmailJson
            {
                valido = _valido,
                token = _token
            };
            DatosJson += valid.ToJSON();
            DatosJson += "";
        }

    }
}

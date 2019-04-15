using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class SolicitudGetOrdersRepartidor
    {
        public Int64 IDCliente { get; set; }
        public Int64 IDUsuario { get; set; }
        public string Token { get; set; }
        public string Usuario { get; set; }

        #region Properties
        private object _result;
        public object Result
        {
            get { return _result; }
            set { _result = value; }
        }

        private string _mensaje;
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        private string _conexion;
        public string Conexion
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
        #endregion
    }
}

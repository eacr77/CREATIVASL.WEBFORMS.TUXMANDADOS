using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class LoginApp
    {
        private int _result;

        public int result
        {
            get { return _result; }
            set { _result = value; }
        }

        private Int64 _IDUsuario;
        public Int64 IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        private Int64 _IDCOR;
        public Int64 IDCOR
        {
            get { return _IDCOR; }
            set { _IDCOR = value; }
        }


        private string _token;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        private Int64 _rol;

        public Int64 Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
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
            LoginAppJson loginJson = new LoginAppJson
            {
                resultado = _result,
                IDUsuario = _IDUsuario,
                IDCOR = _IDCOR,
                token = _token,
                Rol = _rol
            };
            DatosJson += loginJson.ToJSON();
            DatosJson += "";
        }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }
    }
}

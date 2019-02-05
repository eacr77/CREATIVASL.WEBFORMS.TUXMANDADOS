using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class InfoUser
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _token;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        private int _rol;

        public int rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        private int _tipo;

        public int tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string  _apePat;

        public string  apePat
        {
            get { return _apePat; }
            set { _apePat = value; }
        }
        private string _apeMat;

        public string apeMat
        {
            get { return _apeMat; }
            set { _apeMat = value; }
        }
        private string _fecha_nac;

        public string fecha_nac
        {
            get { return _fecha_nac; }
            set { _fecha_nac = value; }
        }
        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private int _ubicacion;

        public int ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
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
            InfoUserJson info = new InfoUserJson
            {
                tipo=_tipo,
                nombre=_nombre,
                apePat=_apePat,
                apeMat=_apeMat,
                fecha_nac=_fecha_nac,
                telefono=_telefono,
                ubicacion=_ubicacion
            };
            DatosJson += info.ToJSON();
            DatosJson += "";
        }
    }
}

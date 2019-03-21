using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class ACUsuario
    {
        private int _opcion;

        public int opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }
        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _ape_pat;

        public string ape_pat
        {
            get { return _ape_pat; }
            set { _ape_pat = value; }
        }
        private string _ape_mat;

        public string ape_mat
        {
            get { return _ape_mat; }
            set { _ape_mat = value; }
        }
        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private decimal _latitud;

        public decimal latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }
        private decimal _longitud;

        public decimal longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }

        private bool _cambioPass;

        public bool cambioPass
        {
            get { return _cambioPass; }
            set { _cambioPass = value; }
        }

        private int _idcli;

        public int idcli
        {
            get { return _idcli; }
            set { _idcli = value; }
        }
        private int _idloc;

        public int idloc
        {
            get { return _idloc; }
            set { _idloc = value; }
        }
        private int _idusu;

        public int idusu
        {
            get { return _idusu; }
            set { _idusu = value; }
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
           ACUsuarioJson usuarioJson = new ACUsuarioJson
            {
                idcli=_idcli
            };
            DatosJson += usuarioJson.ToJSON();
            DatosJson += "";
        }
    }
}

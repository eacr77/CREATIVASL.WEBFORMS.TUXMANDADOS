using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class Cliente
    {
        private string _id_cliente;
        public string id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _Colonia;

        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; }
        }
        private string _Correo;

        public string CorreoElectronico
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        private string _DatosJson;
        public string DatosJson
        {
            get { return _DatosJson; }
            set { _DatosJson = value; }
        }
        private string _conexion;
        public string conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        private string _resultado;
        public string resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
        private DataTable _datos;
        public DataTable datos
        {
            get { return _datos; }
            set { _datos = value; }
        }
        public void GenerarJSON()
        {
            int i = 0;
            _DatosJson += "{\"Cliente\":[";
            foreach (DataRow row in this.datos.Rows)
            {
                ClienteJson clienteJson = new ClienteJson
                {
                    id_cliente = row["id_cliente"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    CorreoElectronico = row["CorreoElectronico"].ToString(),
                    Colonia = row["Colonia"].ToString(),
                };
                if (i > 0) DatosJson += ",";
                DatosJson += clienteJson.ToJSON();
                i++;
            }                        
            DatosJson += "]}";
        }


    }
    public class ClienteJson
    {
        public string id_cliente { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Colonia { get; set; }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }
    }
}

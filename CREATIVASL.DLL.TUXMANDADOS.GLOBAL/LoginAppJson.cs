using System;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class LoginAppJson
    {
        public int resultado { get; set; }
        public Int64 IDUsuario { get; set; }
        public Int64 IDCOR { get; set; }
        public string token { get; set; }
        public Int64 Rol { get; set; }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }
    }
}

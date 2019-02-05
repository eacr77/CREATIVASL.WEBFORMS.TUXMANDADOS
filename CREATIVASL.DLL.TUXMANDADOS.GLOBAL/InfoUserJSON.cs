using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class InfoUserJson
    {
        public int tipo { get; set; }
        public string nombre { get; set; }
        public string apePat { get; set; }
        public string apeMat { get; set; }
        public string fecha_nac { get; set; }
        public string telefono { get; set; }
        public int ubicacion { get; set; }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }
    }
}

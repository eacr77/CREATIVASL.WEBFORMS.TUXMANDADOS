using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
   public class ValidEmailJson
    {
        public int valido { get; set; }
        public string token { get; set; }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(this);
        }
    }
}

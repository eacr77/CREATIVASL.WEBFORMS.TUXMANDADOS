namespace CREATIVASL.DLL.TUXMANDADOS.GLOBAL
{
    public class Serialize
    {
        object content;
        public Serialize(object obj)
        {
            content = obj;
        }
        public string ToJSON()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer
                = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsonSerializer.Serialize(content);
        }
    }
}

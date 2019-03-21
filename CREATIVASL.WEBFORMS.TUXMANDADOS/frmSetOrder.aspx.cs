namespace CREATIVASL.WEBFORMS.TUXMANDADOS
{
    using System;
    using System.Configuration;
    using System.Web.UI;
    using CREATIVASL.DLL.TUXMANDADOS.DATOS;
    using CREATIVASL.DLL.TUXMANDADOS.GLOBAL;

    public partial class frmSetOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //if (true)
            {
                if (Page.Request.HttpMethod == "POST")
                //if (true)
                {
                    SolicitudSetOrder solicitudOrder = null;
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        solicitudOrder = jsonSerializer.Deserialize<SolicitudSetOrder>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    //if (true)
                    if (Valor != "")
                    {
                        SolicitudSetOrder solicitud = new SolicitudSetOrder();
                        AppDatos appDatos = new AppDatos();
                        solicitud.Conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                        
                        Order minisolicitud = new Order();// hacemos el objeto order, para mandarlo al servicio!
                        minisolicitud.Estado = solicitudOrder.Order.Estado;
                        minisolicitud.Descripcion = solicitudOrder.Order.Descripcion;
                        minisolicitud.Ubicacion = new Ubicacion();
                        minisolicitud.Ubicacion.Latitud = solicitudOrder.Order.Ubicacion.Latitud;
                        minisolicitud.Ubicacion.Longitud = solicitudOrder.Order.Ubicacion.Longitud;
                        solicitud.Order = minisolicitud;
                        solicitud.IDUsuario = solicitudOrder.IDUsuario;
                        solicitud.IDCliente = solicitudOrder.IDCliente;

                        try
                        {
                            appDatos.SetOrder(solicitud);
                        }
                        catch (Exception ex)
                        {
                            solicitud.Mensaje = ex.Message;
                            solicitud.DatosJson = "No se encontró.";
                        }
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        if (solicitud.Mensaje == "success")
                            Response.Write(solicitud.DatosJson);
                        else
                            Response.Write("Error " + solicitud.Mensaje);
                        Response.End();
                    }
                    else
                    {
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        Response.Write("Error ID:000: Valores Incorrectos");
                        Response.End();
                    }
                }
                else
                {
                    
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write("Error ID:002 Tipo Incorrecto");
                    Response.End();
                }
            }

        }
    }
}
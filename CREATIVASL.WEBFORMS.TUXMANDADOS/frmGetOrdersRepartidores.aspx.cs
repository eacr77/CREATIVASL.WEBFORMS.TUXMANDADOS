using System;
using System.Configuration;
using System.Web.UI;
using CREATIVASL.DLL.TUXMANDADOS.DATOS;
using CREATIVASL.DLL.TUXMANDADOS.GLOBAL;

namespace CREATIVASL.WEBFORMS.TUXMANDADOS
{
    public partial class frmGetOrdersRepartidores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            if (true)
            {
                //if (Page.Request.HttpMethod == "POST")
                if (true)
                {
                    SolicitudLogin solicitudGetOrders = null;
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        solicitudGetOrders = jsonSerializer.Deserialize<SolicitudLogin>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    if (true)
                    //if (Valor != "")
                    {
                        SolicitudGetOrdersRepartidor solicitud = new SolicitudGetOrdersRepartidor();
                        AppDatos appDatos = new AppDatos();
                        solicitud.Conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                        //solicitud.Usuario = solicitudGetOrders.usuario;
                        //solicitud.Token = solicitudGetOrders.token;
                        solicitud.Usuario = "eacr77";
                        solicitud.Token = "ECDC9E74-1DA2-4A3F-8667-53C22D7607B3";
                        //solicitud.Order = new Order();

                        try
                        {
                            appDatos.GetOrderRepartidores(solicitud);
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
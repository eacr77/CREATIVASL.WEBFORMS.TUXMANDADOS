using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CREATIVASL.DLL.TUXMANDADOS.DATOS;
using CREATIVASL.DLL.TUXMANDADOS.GLOBAL;
namespace CREATIVASL.WEBFORMS.TUXMANDADOS
{
    public partial class frmInfoUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //if (true)
            {
                if (Page.Request.HttpMethod == "POST")
                //if (true)
                {
                    SolicitudInfoUser solicitudUser = null;
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        solicitudUser = jsonSerializer.Deserialize<SolicitudInfoUser>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    //if (true)
                    if (Valor != "")
                    {
                        InfoUser info = new InfoUser();
                        AppDatos appDatos = new AppDatos();
                        info.conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                       
                        info.id = solicitudUser.id;
                        info.usuario = solicitudUser.usuario;
                        info.token = solicitudUser.token;
                        info.rol = solicitudUser.rol;
                        /*info.id = 3;
                        info.usuario = "eacr77";
                        info.token = "C39555B0-86C2-48CE-A0C5-25BF301A1A7E";
                        info.rol = 1;*/
                        try
                        {
                            appDatos.InfoUser(info);
                        }
                        catch (Exception ex)
                        {
                           info.resultado = ex.Message;
                            info.DatosJson = "No se encontró.";
                        }
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        if (info.resultado == "REGOK")
                            Response.Write(info.DatosJson);
                        else
                            Response.Write("Error " + info.resultado);
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
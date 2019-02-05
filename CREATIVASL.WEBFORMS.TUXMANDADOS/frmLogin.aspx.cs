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
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //if (true)
            {
                if (Page.Request.HttpMethod == "POST")
                //if (true)
                {
                    SolicitudLogin solicitudLogin = null;
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        solicitudLogin = jsonSerializer.Deserialize<SolicitudLogin>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    //if (true)
                    if (Valor != "")
                    {
                        LoginApp loginApp = new LoginApp();
                        AppDatos appDatos = new AppDatos();
                        loginApp.conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                        loginApp.usuario = solicitudLogin.usuario;
                        loginApp.password = solicitudLogin.password;
                        //loginApp.usuario = "eacr77";
                        //loginApp.password = "123456";

                        try
                        {
                            appDatos.login(loginApp);
                        }
                        catch (Exception ex)
                        {
                            loginApp.resultado = ex.Message;
                            loginApp.DatosJson = "No se encontró.";
                        }
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        if (loginApp.resultado == "REGOK")
                            Response.Write(loginApp.DatosJson);
                        else
                            Response.Write("Error " + loginApp.resultado);
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
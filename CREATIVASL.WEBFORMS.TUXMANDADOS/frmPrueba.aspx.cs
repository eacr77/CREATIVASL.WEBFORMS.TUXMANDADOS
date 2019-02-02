
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
    public partial class frmPrueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            if (true)
            {
                //if (Page.Request.HttpMethod == "POST")
                if (true)
                {
                   
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        //solicitudWodGlobal = jsonSerializer.Deserialize<SolicitudWodGlobal>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    if (true)
                    //if (Valor != "")
                    {
                        Cliente clien = new Cliente();
                        AppDatos appDatos = new AppDatos();
                        clien.conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;                       
                        try
                        {
                            appDatos.Getprueba(clien);
                        }
                        catch (Exception ex)
                        {
                            clien.resultado = ex.Message;
                            clien.DatosJson = "No se encontró.";
                        }
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        if (clien.resultado == "REGOK")
                            Response.Write(clien.DatosJson);
                        else
                            Response.Write("Error " + clien.resultado);
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
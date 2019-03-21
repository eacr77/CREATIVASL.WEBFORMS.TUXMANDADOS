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
    public partial class frmACUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //if (true)
            {
                if (Page.Request.HttpMethod == "POST")
                //if (true)
                {
                    SolicitudACUsuario solicitudUser = null;
                    string Valor = "";
                    //Leer JSON
                    try
                    {
                        using (var streamReader = new System.IO.StreamReader(Request.GetBufferedInputStream()))
                        {
                            Valor = streamReader.ReadToEnd();
                        }
                        System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        solicitudUser = jsonSerializer.Deserialize<SolicitudACUsuario>(Valor);
                    }
                    catch (Exception)
                    {
                        Valor = "";
                    }
                    //if (true)
                    if (Valor != "")
                    {
                        ACUsuario info = new ACUsuario();
                        AppDatos appDatos = new AppDatos();
                        info.conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                        
                         info.opcion = solicitudUser.opcion;
                         info.usuario = solicitudUser.usuario;
                         info.email = solicitudUser.email;
                         info.password = solicitudUser.password;
                         info.nombre = solicitudUser.nombre;
                         info.ape_pat = solicitudUser.ape_pat;
                         info.ape_mat = solicitudUser.ape_mat;
                         info.direccion = solicitudUser.direccion;
                         info.fecha = solicitudUser.fecha;
                         info.telefono = solicitudUser.telefono;
                         info.latitud = solicitudUser.latitud;
                         info.longitud = solicitudUser.longitud;
                        info.cambioPass = solicitudUser.cambioPass;
                        info.idloc = solicitudUser.idloc;
                        info.idcli = solicitudUser.idcli;
                        info.idusu = solicitudUser.idusu;
                                                            
                        /*info.opcion = 1;
                        info.usuario = "albert77";
                        info.email = "eacr_777@hotmail.com";
                        info.password = "albert77";
                        info.nombre = "Alberto";
                        info.ape_pat = "Espinoza";
                        info.ape_mat = "López";
                        info.direccion = "4 av sur poniente";
                        info.fecha = "1994-03-04";
                        info.telefono = "9618655232";
                        info.latitud = 13.344545M;
                        info.longitud = 10.34243454M;
                        info.cambioPass = false;
                        info.idloc = 0;
                        info.idcli = 0;
                        info.idusu = 0;*/
                         

                        try
                        {
                            appDatos.ACUsuario(info);
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
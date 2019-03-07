using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CREATIVASL.DLL.TUXMANDADOS.GLOBAL;
using CREATIVASL.WEBFORMS.TUXMANDADOS.ClasesAux;
using CREATIVASL.DLL.TUXMANDADOS.DATOS;
using System.Configuration;

namespace CREATIVASL.WEBFORMS.TUXMANDADOS
{
    public partial class frmRecuperarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count > 0)
            {
                EUsuario user = new EUsuario();
                user.Token = Request.Form["token"].ToString();
                user.Contraseña = Request.Form["contra"].ToString();
                user.Conexion = ConfigurationManager.ConnectionStrings["Conexion_App"].ConnectionString;
                AppDatos appDatos = new AppDatos();
                appDatos.recuperar(user);
                if (user.Resultado==1)
                {
                    string msg = "<script type='text/javascript'>";
                    msg += "alert('Contraseña actualizada exitosamente, ya puesdes ingresar a tuxmandados')";
                    msg += "</script>";
                    Response.Write(msg);
                    /*string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Contraseña actualizada correctamente ", "Exito",
                        ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);*/
                }
                else
                {


                    string msg = "<script type='text/javascript'>";
                    msg += "alert('El token ingresado es incorrecto revisa tu correo por favor')";
                    msg += "</script>";
                    Response.Write(msg);
                    /*string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error el token no existe ", "Error",
                        ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    Response.Redirect("frmRecuperarContraseña.aspx");*/
                }
            }
        }
    }
}
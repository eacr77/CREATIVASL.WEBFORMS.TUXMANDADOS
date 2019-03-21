using CREATIVASL.DLL.TUXMANDADOS.GLOBAL;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CREATIVASL.DLL.TUXMANDADOS.DATOS
{
    public class AppDatos
    {
       
        public void login(LoginApp login)
        {
            try
            {
                object[] Valores = { login.usuario, login.password };
                DataSet ds = SqlHelper.ExecuteDataset(login.conexion, "spCIDBD_get_Login", Valores);
                login.resultado = "No se encontraron resultados";
                if (ds != null)
                {
                    if(ds.Tables[0]!=null)
                    {
                        if(ds.Tables[0].Rows.Count>0)
                        {
                            switch (Convert.ToInt32(ds.Tables[0].Rows[0]["resultado"]))
                            {
                                case 1:
                                    {
                                        login.resultado = "REGOK";
                                        login.result= Convert.ToInt32(ds.Tables[0].Rows[0]["resultado"]);
                                        login.id= Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                                        login.token = ds.Tables[0].Rows[0]["token"].ToString();
                                        login.rol= ds.Tables[0].Rows[0]["rol"].ToString();
                                        login.GenerarJSON();
                                    }
                                    break;
                                case 2:
                                    {
                                        login.resultado = "Usuario o contraseña incorrecta";
                                    }
                                    break;
                                case 3:
                                    {
                                        login.resultado = "Usuario no encontrado, registrese por favor";
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void InfoUser(InfoUser info)
        {
            try
            {
                object[] Valores = {info.id,info.usuario,info.token,info.rol };
                DataSet ds = SqlHelper.ExecuteDataset(info.conexion, "CIDBD_get_InfoUser", Valores);
                info.resultado = "No se encontraron resultados";
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            info.resultado = "REGOK";
                            info.tipo =Convert.ToInt32(ds.Tables[0].Rows[0]["tipo"]);
                            info.nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                            info.apePat = ds.Tables[0].Rows[0]["apePat"].ToString();
                            info.apeMat = ds.Tables[0].Rows[0]["apeMat"].ToString();
                            info.fecha_nac = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_nac"]).ToString("dd-MM-yyyy");
                            info.telefono = ds.Tables[0].Rows[0]["telefono"].ToString();
                            info.ubicacion =Convert.ToInt32(ds.Tables[0].Rows[0]["ubicacion"]);
                            info.GenerarJSON();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ACUsuario(ACUsuario user)
        {
            try
            {
                object[] Valores = { user.opcion,user.usuario,user.email,user.password,user.nombre,user.ape_pat,user.ape_mat,user.direccion,user.fecha,
                user.telefono,user.latitud,user.longitud,user.cambioPass,user.idloc,user.idcli,user.idusu};
                object res = SqlHelper.ExecuteScalar(user.conexion, "spCIDBD_ACUsuarioNormal", Valores);
                user.resultado = "No se encontraron resultados";
                if (res != null)
                {
                    if (!string.IsNullOrEmpty(res.ToString()))
                    {
                        user.resultado = "REGOK";
                        user.idcli = Convert.ToInt32(res.ToString()); 
                        user.GenerarJSON();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ValidEmail(ValidEmail valido)
        {
            try
            {
                
                DataSet ds = SqlHelper.ExecuteDataset(valido.conexion, "spCIDBD_get_ValidarCorreo", valido.Correo);
                valido.resultado = "No se encontraron resultados";
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            valido.resultado = "REGOK";
                            valido.valido = Convert.ToInt32(ds.Tables[0].Rows[0]["Resultado"]);
                            valido.token = ds.Tables[0].Rows[0]["token"].ToString();
                            valido.GenerarJSON();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void recuperar(EUsuario user)
        {
            try
            {
                object[] Valores = { user.Token, user.Contraseña };
                DataSet ds = SqlHelper.ExecuteDataset(user.Conexion, "CIDBD_UpdContraseña", Valores);                
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            user.Resultado = Convert.ToInt32(ds.Tables[0].Rows[0]["resultado"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

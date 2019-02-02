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
        public void Getprueba(Cliente cliente)
        {
            try
            {
                //object[] Valores = { wodGlobal.id_nivel, wodGlobal.equipo, wodGlobal.id_cliente };
                DataSet ds = SqlHelper.ExecuteDataset(cliente.conexion, "creativ1_tuxmandados.Probedamart");
                cliente.resultado = "No se encontraron resultados";
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            cliente.resultado = "REGOK";
                            cliente.datos = ds.Tables[0];
                            cliente.GenerarJSON();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelEmpresa
    {
        public static DataTable CargarTipoEmpresa()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbtipo_empresa";
                MySqlCommand cmdTipoEmpresa = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdTipoEmpresa);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoEmpresa()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbestado";
                MySqlCommand cmdEstadoEmpresa = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdEstadoEmpresa);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
    }
}

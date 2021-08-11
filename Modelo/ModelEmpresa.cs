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

        //empresa correo  nit representante_legal id_tipo_empresa id_estado   direccion logoempresa
        #region CRUD
        public static bool AgregarEmpresa(string nombreE, string correo, string nit, string nombreRe, int idTipo, int idEstado, string direccion)
        {
            bool res = false;
            try
            {
                MySqlCommand cmandquery = new MySqlCommand(string.Format("INSERT INTO tbempresa(empresa, correo, nit, representante_legal,id_tipo_empresa, id_estado, direccion) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')", nombreE, correo, nit, nombreRe, idTipo, idEstado, direccion), ModeloConexion.ObtenerConexion());
                res = Convert.ToBoolean(cmandquery.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }

        }

        #endregion
    }
}

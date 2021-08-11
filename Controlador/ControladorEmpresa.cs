using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControladorEmpresa
    {
        public static DataTable ObtenerEstadoEmpresa()
        {
            return ModelEmpresa.CargarEstadoEmpresa();
        }

        public static DataTable ObtenerTipoEmpresa()
        {
            return ModelEmpresa.CargarTipoEmpresa();
        }
    }
}

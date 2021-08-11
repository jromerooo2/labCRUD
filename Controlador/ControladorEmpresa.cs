using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    class ControladorEmpresa
    {
        public static DataTable ObtenerEstadoEmpresa()
        {
            return Modelo.CargarEstadoEmpresa();
        }

        public static DataTable ObtenerTipoEmpresa()
        {
            return Modelo.CargarTipoEmpresa();
        }
    }
}

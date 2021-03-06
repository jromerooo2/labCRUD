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

        public static DataTable CargarEmpresas_Controller()
        {
            return ModelEmpresa.CargarListaEmpresas();
        }

        public static object CargarTipoEmpresaInnerJoin(string id)
        {
            return ModelEmpresa.CargarTipoEmpresaInner(id);
        }
        public static object CargarEstadoEmpresaInnerJoin(string id)
        {
            return ModelEmpresa.CargarTipoEstadoInner( id);
        }


        //atributos empresa
        public static int idempresa { get; set; }
        public static string nombreEmpresa { get; set; }
        public static string nombreRepresentante { get; set; }
        public static string nit { get; set; }
        public static string direccionEmpresa { get; set; }
        public static string correoEmpresa { get; set; }
        public static int idTipoEmpresa { get; set; }
        public static int idEstadoEmpresa { get; set; }

        //constructor 
        public ControladorEmpresa(string enombre, string erepresentante, string enit, string edireccion, string ecorreo, int etipo, int estado)        
        {
            nombreEmpresa = enombre;
            nombreRepresentante = erepresentante;
            nit = enit;
            direccionEmpresa = edireccion;
            correoEmpresa = ecorreo;
            idTipoEmpresa = etipo;
            idEstadoEmpresa = estado;
        }

        #region CRUD SECTION

        public bool AgregarEmpresa()
        {
            //empresa	correo	nit	representante_legal	id_tipo_empresa	id_estado	direccion	logoempresa

            return ModelEmpresa.AgregarEmpresa(nombreEmpresa, correoEmpresa, nit, nombreRepresentante, idTipoEmpresa, idEstadoEmpresa, direccionEmpresa);
        }

        public static bool EliminarEmpresa_Controller()
        {
            return ModelEmpresa.EliminarEmpresa(idempresa);
        }

        public static bool ActualizarEmpresa_Controller()
        {
            return ModelEmpresa.ActualizarEmpresa(idempresa, nombreEmpresa, correoEmpresa, nit, nombreRepresentante, idTipoEmpresa, idEstadoEmpresa, direccionEmpresa);
        }

        #endregion


    }
}

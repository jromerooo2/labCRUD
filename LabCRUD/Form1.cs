using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;

namespace LabCRUD
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            CargarDatos();
        }

        public DataTable datosEmpresas;
        public ControladorEmpresa empresa;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 65, 86); //back color custom
            CargarDatos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CargarDatos()
        {
            try
            {
                CargarEstadoEmpresa();
                CargarTipoEmpresa();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cargar ComboBox
        void CargarTipoEmpresa()
        {
            try
            {
                DataTable dataTipo = ControladorEmpresa.ObtenerTipoEmpresa();
                cmbTipoEmpresa.DataSource = dataTipo;
                cmbTipoEmpresa.DisplayMember = "tipo_empresa";
                cmbTipoEmpresa.ValueMember = "id_tipo_empresa";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de empresa .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        void CargarEstadoEmpresa()
        {
            try
            {
                DataTable dataEstado = ControladorEmpresa.ObtenerEstadoEmpresa();
                cmbEstadoEmpresa.DataSource = dataEstado;
                cmbEstadoEmpresa.DisplayMember = "estado";
                cmbEstadoEmpresa.ValueMember = "id_estado";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estados .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        void CargarGridDatos()
        {
            //datosEmpresas = EmpleadosController.CargarEmpleados_Controller();
            //dgvEmpleados.DataSource = datosEmpresas;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection objvalor;
            objvalor = ControladorConexion.Conexion();
            if (objvalor != null)
            {
                MessageBox.Show("Conexión se estableció con exito.");
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarDatos();
        }

        void EnviarDatos()
        {
            try
            {
                string nombreEmpresa, nombreRepresentante, nit, correoContacto, direccionEmpresa;
                int idTipoEmpresa, idEstadoEmpresa;
                nombreEmpresa = txtNombreEmpresa.Text;
                nit = txtNit.Text;
                idTipoEmpresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                idEstadoEmpresa = Convert.ToInt16(cmbEstadoEmpresa.SelectedValue);
                direccionEmpresa = txtDireccion.Text;
                correoContacto = txtCorreo.Text;
                nombreRepresentante = txtRepresentante.Text;

                empresa = new ControladorEmpresa(nombreEmpresa, nombreRepresentante, nit, direccionEmpresa, correoContacto, idTipoEmpresa, idEstadoEmpresa);
                bool res = empresa.AgregarEmpresa();
                if (res)
                {
                    MessageBox.Show("Empresa registrada exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Oops!, ocurrió un error al registrar la empresa, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            MySqlConnection objvalor;
            objvalor = ControladorConexion.Conexion();
            if (objvalor != null)
            {
                MessageBox.Show("Conexión se estableció con exito.");
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.");
            }
        }
    }
}

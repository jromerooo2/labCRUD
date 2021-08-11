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
        }

        public DataTable datosEmpresas;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 65, 86); //back color custom
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
            string nombreEmpresa, nombreRepresentante, nit, correoContacto, direccionEmpresa;
            int idTipoEmpresa, idEstadoEmpresa;
            nombreEmpresa = txtNombreEmpresa.Text;
            nit = txtNit.Text;
            idTipoEmpresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            idEstadoEmpresa = Convert.ToInt16(cmbEstadoEmpresa.SelectedValue);
            direccionEmpresa = txtDireccion.Text;
            correoContacto = txtCorreo.Text;
            nombreRepresentante = txtRepresentante.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

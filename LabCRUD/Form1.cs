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
            CargarGridDatos();
        }

        public DataTable datosEmpresas;
        public ControladorEmpresa empresa;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 110, 140); //back color custom
            CargarDatos();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
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
            datosEmpresas = ControladorEmpresa.CargarEmpresas_Controller();
            dgvEmpresas.DataSource = datosEmpresas;
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
            if (Empty())
            {
                MessageBox.Show("Todos los campos son requeridos.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnviarDatos();
                CargarGridDatos();
                LimpiarCampos();
            }
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
                MessageBox.Show("Conexión se estableció con exito.","Confirmación de conexion",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a: " + txtNombreEmpresa.Text + "?", "Confirmar eliminacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarDatos();
                CargarGridDatos();
            }
        }

        void EliminarDatos()
        {
            ControladorEmpresa.idempresa = Convert.ToInt16(txtId.Text);
            bool respuesta = ControladorEmpresa.EliminarEmpresa_Controller();
            if (respuesta == true)
            {
                MessageBox.Show("El registro ha sido eliminado correctamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no fue eliminado", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;

            int i = dgvEmpresas.CurrentRow.Index;

            txtId.Text = dgvEmpresas[0, i].Value.ToString();
            txtNombreEmpresa.Text = dgvEmpresas[1, i].Value.ToString();
            txtCorreo.Text = dgvEmpresas[2, i].Value.ToString();
            txtNit.Text = dgvEmpresas[3, i].Value.ToString();
            txtRepresentante.Text = dgvEmpresas[4, i].Value.ToString();
            txtDireccion.Text = dgvEmpresas[7, i].Value.ToString();

            string idTipoEmpresa = dgvEmpresas[5, i].Value.ToString();
            cmbTipoEmpresa.DataSource = ControladorEmpresa.CargarTipoEmpresaInnerJoin(idTipoEmpresa);
            cmbTipoEmpresa.DisplayMember = "tipo_empresa";
            cmbTipoEmpresa.ValueMember = "id_tipo_empresa";

            string idEstado = dgvEmpresas[6, i].Value.ToString();
            cmbEstadoEmpresa.DataSource = ControladorEmpresa.CargarEstadoEmpresaInnerJoin(idEstado);
            cmbEstadoEmpresa.DisplayMember = "estado";
            cmbEstadoEmpresa.ValueMember = "id_estado";
        }
        private void cmbTipoEmpresa_Click(object sender, EventArgs e)
        {
            CargarTipoEmpresa();
        }

        private void cmbEstadoEmpresa_Click(object sender, EventArgs e)
        {
            CargarEstadoEmpresa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtCorreo.Clear();
            txtNombreEmpresa.Clear();
            txtNit.Clear();
            txtDireccion.Clear();
            txtRepresentante.Clear();
            cmbEstadoEmpresa.SelectedIndex = 0;
            cmbTipoEmpresa.SelectedIndex = 0;
            textBox2.Clear();         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            LimpiarCampos();
        }

        void ActualizarDatos()
        {

            //nombreO == arrayDatosNuevos[0] && correO == arrayDatosNuevos[1] && nitO == arrayDatosNuevos[2] 
             //&& representanteO == arrayDatosNuevos[3] && direccionO == arrayDatosNuevos[4]

            List<string> arrayDatosActu = new List<string>();
            arrayDatosActu.Add(txtNombreEmpresa.Text);
            arrayDatosActu.Add(txtCorreo.Text);
            arrayDatosActu.Add(txtNit.Text);
            arrayDatosActu.Add(txtRepresentante.Text);
            arrayDatosActu.Add(txtDireccion.Text);

            int idEstado = Convert.ToInt16(cmbEstadoEmpresa.SelectedValue);
            int idTipo = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            

            if (sameOrnot(arrayDatosActu, idEstado, idTipo) && !Empty())
            {
                try
                {
                    string nombreEmpresa, nombreRepresentante, nit, correoContacto, direccionEmpresa;
                    int idTipoEmpresa, idEstadoEmpresa, idempresa;
                    idempresa = Convert.ToInt16(txtId.Text);
                    nombreEmpresa = txtNombreEmpresa.Text;
                    nit = txtNit.Text;
                    idTipoEmpresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                    idEstadoEmpresa = Convert.ToInt16(cmbEstadoEmpresa.SelectedValue);
                    direccionEmpresa = txtDireccion.Text;
                    correoContacto = txtCorreo.Text;
                    nombreRepresentante = txtRepresentante.Text;

                    empresa = new ControladorEmpresa(nombreEmpresa, nombreRepresentante, nit, direccionEmpresa, correoContacto, idTipoEmpresa, idEstadoEmpresa);
                    bool res = empresa.ActualizarEmpresa_Controller(idempresa);
                    if (res)
                    {
                        MessageBox.Show("Empresa actualizada exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Oops!, ocurrió un error al actualizar la empresa, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Error crítico.", "Errr C001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
            else
            {
                MessageBox.Show("Actualiza al menos uno de los datos para continuar, Por favor", "Advertencia");
            }


        }

        private bool sameOrnot(List<string> arrayDatosNuevos, int idEstado, int idTipo)
        {
            int i = dgvEmpresas.CurrentRow.Index;
 
            int estadoempresa0 = Convert.ToInt16(dgvEmpresas[5, i].Value);
            int tipoempresa0 = Convert.ToInt16(dgvEmpresas[6, i].Value);
            string nombreO = dgvEmpresas[1, i].Value.ToString();
            string correO = dgvEmpresas[2, i].Value.ToString();
            string nitO = dgvEmpresas[3, i].Value.ToString();
            string representanteO = dgvEmpresas[4, i].Value.ToString();
            string direccionO = dgvEmpresas[7, i].Value.ToString();

            if (nombreO == arrayDatosNuevos[0] && correO == arrayDatosNuevos[1] && nitO == arrayDatosNuevos[2] 
                && representanteO == arrayDatosNuevos[3] && direccionO == arrayDatosNuevos[4] && estadoempresa0 == idEstado && tipoempresa0 == idTipo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarGridDatos();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private bool Empty()
        {
            string nombres, representante, correo, direccion, nit;
            int estado, tipo;
            nit = txtNit.Text;
            direccion = txtCorreo.Text;
            correo = txtCorreo.Text;
            nombres = txtNombreEmpresa.Text;
            representante = txtRepresentante.Text;
            tipo = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            estado = Convert.ToInt16(cmbEstadoEmpresa.SelectedValue);

            if (!String.IsNullOrEmpty(nombres) && !String.IsNullOrEmpty(representante) && !String.IsNullOrEmpty(Convert.ToString(estado))
                &&!String.IsNullOrEmpty(Convert.ToString(tipo)) && !String.IsNullOrEmpty(correo) && !String.IsNullOrEmpty(direccion)
                && !String.IsNullOrEmpty(nit))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button4_EnabledChanged(object sender, EventArgs e)
        {
        }
    }
}

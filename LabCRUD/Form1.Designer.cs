namespace LabCRUD
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoEmpresa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoEmpresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Empresas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbEstadoEmpresa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbTipoEmpresa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRepresentante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreEmpresa);
            this.panel1.Controls.Add(this.label2);
<<<<<<< Updated upstream
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.panel1.Location = new System.Drawing.Point(9, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 395);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
<<<<<<< Updated upstream
            this.txtId.Location = new System.Drawing.Point(344, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtId.Location = new System.Drawing.Point(258, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(87, 22);
            this.txtId.TabIndex = 25;
            // 
            // txtDireccion
            // 
<<<<<<< Updated upstream
            this.txtDireccion.Location = new System.Drawing.Point(13, 271);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaximumSize = new System.Drawing.Size(200, 200);
=======
            this.txtDireccion.Location = new System.Drawing.Point(10, 220);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.MaximumSize = new System.Drawing.Size(151, 163);
>>>>>>> Stashed changes
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(197, 102);
            this.txtDireccion.TabIndex = 24;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.Location = new System.Drawing.Point(27, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Direccion de la empresa";
            // 
            // cmbEstadoEmpresa
            // 
            this.cmbEstadoEmpresa.FormattingEnabled = true;
<<<<<<< Updated upstream
            this.cmbEstadoEmpresa.Location = new System.Drawing.Point(237, 271);
            this.cmbEstadoEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.cmbEstadoEmpresa.Location = new System.Drawing.Point(178, 220);
            this.cmbEstadoEmpresa.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.cmbEstadoEmpresa.Name = "cmbEstadoEmpresa";
            this.cmbEstadoEmpresa.Size = new System.Drawing.Size(193, 24);
            this.cmbEstadoEmpresa.TabIndex = 23;
            this.cmbEstadoEmpresa.Click += new System.EventHandler(this.cmbEstadoEmpresa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label10.Location = new System.Drawing.Point(251, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Estado de la Empresa";
            // 
            // cmbTipoEmpresa
            // 
            this.cmbTipoEmpresa.FormattingEnabled = true;
<<<<<<< Updated upstream
            this.cmbTipoEmpresa.Location = new System.Drawing.Point(237, 145);
            this.cmbTipoEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.cmbTipoEmpresa.Location = new System.Drawing.Point(178, 118);
            this.cmbTipoEmpresa.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.cmbTipoEmpresa.Name = "cmbTipoEmpresa";
            this.cmbTipoEmpresa.Size = new System.Drawing.Size(193, 24);
            this.cmbTipoEmpresa.TabIndex = 21;
            this.cmbTipoEmpresa.Click += new System.EventHandler(this.cmbTipoEmpresa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Location = new System.Drawing.Point(287, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cargar Logo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.btnAgregar.Location = new System.Drawing.Point(260, 306);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnAgregar.Location = new System.Drawing.Point(195, 249);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 68);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
<<<<<<< Updated upstream
            this.textBox2.Location = new System.Drawing.Point(232, 210);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.textBox2.Location = new System.Drawing.Point(174, 171);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "obviar este textbox";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label7.Location = new System.Drawing.Point(83, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIT";
            // 
            // txtNit
            // 
<<<<<<< Updated upstream
            this.txtNit.Location = new System.Drawing.Point(11, 210);
            this.txtNit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtNit.Location = new System.Drawing.Point(8, 171);
            this.txtNit.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(200, 22);
            this.txtNit.TabIndex = 14;
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Location = new System.Drawing.Point(268, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(27, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Representante Legal";
            // 
            // txtRepresentante
            // 
<<<<<<< Updated upstream
            this.txtRepresentante.Location = new System.Drawing.Point(11, 145);
            this.txtRepresentante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtRepresentante.Location = new System.Drawing.Point(8, 118);
            this.txtRepresentante.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(200, 22);
            this.txtRepresentante.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(251, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo de contacto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCorreo
            // 
<<<<<<< Updated upstream
            this.txtCorreo.Location = new System.Drawing.Point(237, 84);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtCorreo.Location = new System.Drawing.Point(178, 68);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 22);
            this.txtCorreo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de la empresa";
            // 
            // txtNombreEmpresa
            // 
<<<<<<< Updated upstream
            this.txtNombreEmpresa.Location = new System.Drawing.Point(7, 84);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtNombreEmpresa.Location = new System.Drawing.Point(5, 68);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(200, 22);
            this.txtNombreEmpresa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Empresa";
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresas.Location = new System.Drawing.Point(475, 213);
            this.dgvEmpresas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresas.Location = new System.Drawing.Point(356, 173);
            this.dgvEmpresas.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.RowTemplate.Height = 24;
            this.dgvEmpresas.Size = new System.Drawing.Size(1187, 274);
            this.dgvEmpresas.TabIndex = 4;
            this.dgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellClick);
            this.dgvEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEmpresas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmpresas_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(620, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 40);
            this.label11.TabIndex = 5;
            this.label11.Text = "Gestionar Empresas";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnConectar.Location = new System.Drawing.Point(9, 10);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(141, 48);
            this.btnConectar.TabIndex = 24;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.btnEliminar.Location = new System.Drawing.Point(1516, 134);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnEliminar.Location = new System.Drawing.Point(1137, 109);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 59);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar Empresa";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.button2.Location = new System.Drawing.Point(1341, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.button2.Location = new System.Drawing.Point(1006, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 59);
            this.button2.TabIndex = 26;
            this.button2.Text = "Limpiar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.btnActualizar.Location = new System.Drawing.Point(1516, 53);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnActualizar.Location = new System.Drawing.Point(1137, 43);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(141, 59);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar Empresa";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.EnabledChanged += new System.EventHandler(this.button4_EnabledChanged);
            this.btnActualizar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.button3.Location = new System.Drawing.Point(1341, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.button3.Location = new System.Drawing.Point(1006, 109);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 59);
            this.button3.TabIndex = 29;
            this.button3.Text = "Actualizar Datos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1110, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1675, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< Updated upstream
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.Name = "frmEmpresa";
            this.Text = "Control Empresas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbTipoEmpresa;
        private System.Windows.Forms.ComboBox cmbEstadoEmpresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace citasMedicas
{
    partial class Mantenimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.pagePacientes = new MetroFramework.Controls.MetroTabPage();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxPac = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgMedicos = new System.Windows.Forms.DataGridView();
            this.btnMdLimpiar = new System.Windows.Forms.Button();
            this.btnMedGuardar = new System.Windows.Forms.Button();
            this.groupBoxMed = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbClinMedic = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMedEmail = new System.Windows.Forms.TextBox();
            this.txtMedTel = new System.Windows.Forms.TextBox();
            this.txtMedNombre = new System.Windows.Forms.TextBox();
            this.txtMedExeq = new System.Windows.Forms.TextBox();
            this.txtMedCedula = new System.Windows.Forms.TextBox();
            this.txtMedId = new System.Windows.Forms.TextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dgClinicas = new System.Windows.Forms.DataGridView();
            this.btGuarCli = new System.Windows.Forms.Button();
            this.btnLimpCli = new System.Windows.Forms.Button();
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDirCli = new System.Windows.Forms.TextBox();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.pagePacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.groupBoxPac.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicos)).BeginInit();
            this.groupBoxMed.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClinicas)).BeginInit();
            this.groupBoxCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mantenimientos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 29);
            this.panel1.TabIndex = 1;
            // 
            // picSalir
            // 
            this.picSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSalir.Image = global::citasMedicas.Properties.Resources.delete_sign_16px;
            this.picSalir.Location = new System.Drawing.Point(689, 0);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(44, 29);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSalir.TabIndex = 1;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.pagePacientes);
            this.TabControl1.Controls.Add(this.metroTabPage2);
            this.TabControl1.Controls.Add(this.metroTabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 29);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(733, 413);
            this.TabControl1.TabIndex = 2;
            this.TabControl1.UseSelectable = true;
            // 
            // pagePacientes
            // 
            this.pagePacientes.BackColor = System.Drawing.Color.White;
            this.pagePacientes.Controls.Add(this.dgPacientes);
            this.pagePacientes.Controls.Add(this.btnLimpiar);
            this.pagePacientes.Controls.Add(this.btnGuardar);
            this.pagePacientes.Controls.Add(this.groupBoxPac);
            this.pagePacientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagePacientes.HorizontalScrollbarBarColor = true;
            this.pagePacientes.HorizontalScrollbarHighlightOnWheel = false;
            this.pagePacientes.HorizontalScrollbarSize = 10;
            this.pagePacientes.Location = new System.Drawing.Point(4, 38);
            this.pagePacientes.Name = "pagePacientes";
            this.pagePacientes.Size = new System.Drawing.Size(725, 371);
            this.pagePacientes.TabIndex = 0;
            this.pagePacientes.Text = "Pacientes";
            this.pagePacientes.VerticalScrollbarBarColor = true;
            this.pagePacientes.VerticalScrollbarHighlightOnWheel = false;
            this.pagePacientes.VerticalScrollbarSize = 10;
            // 
            // dgPacientes
            // 
            this.dgPacientes.AllowUserToResizeColumns = false;
            this.dgPacientes.AllowUserToResizeRows = false;
            this.dgPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPacientes.ColumnHeadersHeight = 22;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPacientes.EnableHeadersVisualStyles = false;
            this.dgPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgPacientes.Location = new System.Drawing.Point(36, 184);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPacientes.Size = new System.Drawing.Size(653, 179);
            this.dgPacientes.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(141)))), ((int)(((byte)(162)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(554, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 35);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(554, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxPac
            // 
            this.groupBoxPac.Controls.Add(this.label7);
            this.groupBoxPac.Controls.Add(this.label6);
            this.groupBoxPac.Controls.Add(this.label5);
            this.groupBoxPac.Controls.Add(this.label4);
            this.groupBoxPac.Controls.Add(this.label3);
            this.groupBoxPac.Controls.Add(this.label2);
            this.groupBoxPac.Controls.Add(this.txtDireccion);
            this.groupBoxPac.Controls.Add(this.txtEmail);
            this.groupBoxPac.Controls.Add(this.txtTelefono);
            this.groupBoxPac.Controls.Add(this.txtNombre);
            this.groupBoxPac.Controls.Add(this.txtCedula);
            this.groupBoxPac.Controls.Add(this.txtId);
            this.groupBoxPac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPac.Location = new System.Drawing.Point(36, 15);
            this.groupBoxPac.Name = "groupBoxPac";
            this.groupBoxPac.Size = new System.Drawing.Size(500, 149);
            this.groupBoxPac.TabIndex = 2;
            this.groupBoxPac.TabStop = false;
            this.groupBoxPac.Text = "Pacientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(339, 101);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(135, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(339, 69);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(95, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(339, 37);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(135, 26);
            this.txtCedula.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(95, 37);
            this.txtId.MaxLength = 6;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 26);
            this.txtId.TabIndex = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.dgMedicos);
            this.metroTabPage2.Controls.Add(this.btnMdLimpiar);
            this.metroTabPage2.Controls.Add(this.btnMedGuardar);
            this.metroTabPage2.Controls.Add(this.groupBoxMed);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(725, 371);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Médicos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgMedicos
            // 
            this.dgMedicos.AllowUserToResizeColumns = false;
            this.dgMedicos.AllowUserToResizeRows = false;
            this.dgMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMedicos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMedicos.ColumnHeadersHeight = 22;
            this.dgMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMedicos.EnableHeadersVisualStyles = false;
            this.dgMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgMedicos.Location = new System.Drawing.Point(36, 201);
            this.dgMedicos.Name = "dgMedicos";
            this.dgMedicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgMedicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMedicos.Size = new System.Drawing.Size(653, 162);
            this.dgMedicos.TabIndex = 11;
            // 
            // btnMdLimpiar
            // 
            this.btnMdLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(141)))), ((int)(((byte)(162)))));
            this.btnMdLimpiar.FlatAppearance.BorderSize = 0;
            this.btnMdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnMdLimpiar.Location = new System.Drawing.Point(555, 66);
            this.btnMdLimpiar.Name = "btnMdLimpiar";
            this.btnMdLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnMdLimpiar.TabIndex = 8;
            this.btnMdLimpiar.Text = "Limpiar";
            this.btnMdLimpiar.UseVisualStyleBackColor = false;
            this.btnMdLimpiar.Click += new System.EventHandler(this.btnMdLimpiar_Click);
            // 
            // btnMedGuardar
            // 
            this.btnMedGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnMedGuardar.FlatAppearance.BorderSize = 0;
            this.btnMedGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedGuardar.ForeColor = System.Drawing.Color.White;
            this.btnMedGuardar.Location = new System.Drawing.Point(555, 21);
            this.btnMedGuardar.Name = "btnMedGuardar";
            this.btnMedGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnMedGuardar.TabIndex = 7;
            this.btnMedGuardar.Text = "Guardar";
            this.btnMedGuardar.UseVisualStyleBackColor = false;
            this.btnMedGuardar.Click += new System.EventHandler(this.btnMedGuardar_Click);
            // 
            // groupBoxMed
            // 
            this.groupBoxMed.Controls.Add(this.label14);
            this.groupBoxMed.Controls.Add(this.cbbClinMedic);
            this.groupBoxMed.Controls.Add(this.label8);
            this.groupBoxMed.Controls.Add(this.label9);
            this.groupBoxMed.Controls.Add(this.label10);
            this.groupBoxMed.Controls.Add(this.label11);
            this.groupBoxMed.Controls.Add(this.label12);
            this.groupBoxMed.Controls.Add(this.label13);
            this.groupBoxMed.Controls.Add(this.txtMedEmail);
            this.groupBoxMed.Controls.Add(this.txtMedTel);
            this.groupBoxMed.Controls.Add(this.txtMedNombre);
            this.groupBoxMed.Controls.Add(this.txtMedExeq);
            this.groupBoxMed.Controls.Add(this.txtMedCedula);
            this.groupBoxMed.Controls.Add(this.txtMedId);
            this.groupBoxMed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMed.Location = new System.Drawing.Point(36, 14);
            this.groupBoxMed.Name = "groupBoxMed";
            this.groupBoxMed.Size = new System.Drawing.Size(503, 173);
            this.groupBoxMed.TabIndex = 5;
            this.groupBoxMed.TabStop = false;
            this.groupBoxMed.Text = "Médicos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Clínicas:";
            // 
            // cbbClinMedic
            // 
            this.cbbClinMedic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClinMedic.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClinMedic.FormattingEnabled = true;
            this.cbbClinMedic.Location = new System.Drawing.Point(99, 127);
            this.cbbClinMedic.Name = "cbbClinMedic";
            this.cbbClinMedic.Size = new System.Drawing.Size(382, 26);
            this.cbbClinMedic.TabIndex = 6;
            this.cbbClinMedic.Click += new System.EventHandler(this.cbbClinMedic_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Exequátur:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Cédula:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Id:";
            // 
            // txtMedEmail
            // 
            this.txtMedEmail.BackColor = System.Drawing.Color.White;
            this.txtMedEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedEmail.Location = new System.Drawing.Point(346, 95);
            this.txtMedEmail.Name = "txtMedEmail";
            this.txtMedEmail.Size = new System.Drawing.Size(135, 26);
            this.txtMedEmail.TabIndex = 5;
            // 
            // txtMedTel
            // 
            this.txtMedTel.BackColor = System.Drawing.Color.White;
            this.txtMedTel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedTel.Location = new System.Drawing.Point(99, 95);
            this.txtMedTel.MaxLength = 10;
            this.txtMedTel.Name = "txtMedTel";
            this.txtMedTel.Size = new System.Drawing.Size(135, 26);
            this.txtMedTel.TabIndex = 2;
            // 
            // txtMedNombre
            // 
            this.txtMedNombre.BackColor = System.Drawing.Color.White;
            this.txtMedNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedNombre.Location = new System.Drawing.Point(99, 63);
            this.txtMedNombre.Name = "txtMedNombre";
            this.txtMedNombre.Size = new System.Drawing.Size(135, 26);
            this.txtMedNombre.TabIndex = 1;
            // 
            // txtMedExeq
            // 
            this.txtMedExeq.BackColor = System.Drawing.Color.White;
            this.txtMedExeq.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedExeq.Location = new System.Drawing.Point(346, 63);
            this.txtMedExeq.MaxLength = 6;
            this.txtMedExeq.Name = "txtMedExeq";
            this.txtMedExeq.Size = new System.Drawing.Size(135, 26);
            this.txtMedExeq.TabIndex = 4;
            // 
            // txtMedCedula
            // 
            this.txtMedCedula.BackColor = System.Drawing.Color.White;
            this.txtMedCedula.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedCedula.Location = new System.Drawing.Point(346, 31);
            this.txtMedCedula.MaxLength = 11;
            this.txtMedCedula.Name = "txtMedCedula";
            this.txtMedCedula.Size = new System.Drawing.Size(135, 26);
            this.txtMedCedula.TabIndex = 3;
            // 
            // txtMedId
            // 
            this.txtMedId.BackColor = System.Drawing.Color.White;
            this.txtMedId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedId.Location = new System.Drawing.Point(99, 31);
            this.txtMedId.MaxLength = 6;
            this.txtMedId.Name = "txtMedId";
            this.txtMedId.Size = new System.Drawing.Size(135, 26);
            this.txtMedId.TabIndex = 0;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.White;
            this.metroTabPage3.Controls.Add(this.dgClinicas);
            this.metroTabPage3.Controls.Add(this.btGuarCli);
            this.metroTabPage3.Controls.Add(this.btnLimpCli);
            this.metroTabPage3.Controls.Add(this.groupBoxCli);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(725, 371);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Clínicas";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // dgClinicas
            // 
            this.dgClinicas.AllowUserToResizeColumns = false;
            this.dgClinicas.AllowUserToResizeRows = false;
            this.dgClinicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClinicas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgClinicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClinicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClinicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgClinicas.ColumnHeadersHeight = 22;
            this.dgClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClinicas.EnableHeadersVisualStyles = false;
            this.dgClinicas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgClinicas.Location = new System.Drawing.Point(70, 194);
            this.dgClinicas.Name = "dgClinicas";
            this.dgClinicas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgClinicas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgClinicas.Size = new System.Drawing.Size(585, 163);
            this.dgClinicas.TabIndex = 11;
            // 
            // btGuarCli
            // 
            this.btGuarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btGuarCli.FlatAppearance.BorderSize = 0;
            this.btGuarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuarCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuarCli.ForeColor = System.Drawing.Color.White;
            this.btGuarCli.Location = new System.Drawing.Point(505, 22);
            this.btGuarCli.Name = "btGuarCli";
            this.btGuarCli.Size = new System.Drawing.Size(150, 35);
            this.btGuarCli.TabIndex = 3;
            this.btGuarCli.Text = "Guardar";
            this.btGuarCli.UseVisualStyleBackColor = false;
            this.btGuarCli.Click += new System.EventHandler(this.btGuarCli_Click);
            // 
            // btnLimpCli
            // 
            this.btnLimpCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(141)))), ((int)(((byte)(162)))));
            this.btnLimpCli.FlatAppearance.BorderSize = 0;
            this.btnLimpCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpCli.ForeColor = System.Drawing.Color.White;
            this.btnLimpCli.Location = new System.Drawing.Point(505, 65);
            this.btnLimpCli.Name = "btnLimpCli";
            this.btnLimpCli.Size = new System.Drawing.Size(150, 35);
            this.btnLimpCli.TabIndex = 4;
            this.btnLimpCli.Text = "Limpiar";
            this.btnLimpCli.UseVisualStyleBackColor = false;
            this.btnLimpCli.Click += new System.EventHandler(this.btnLimpCli_Click);
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.label15);
            this.groupBoxCli.Controls.Add(this.label18);
            this.groupBoxCli.Controls.Add(this.label20);
            this.groupBoxCli.Controls.Add(this.txtDirCli);
            this.groupBoxCli.Controls.Add(this.txtNomCli);
            this.groupBoxCli.Controls.Add(this.txtIdCli);
            this.groupBoxCli.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCli.Location = new System.Drawing.Point(70, 13);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(418, 167);
            this.groupBoxCli.TabIndex = 5;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "Clínicas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Direccion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Nombre:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(74, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "Id:";
            // 
            // txtDirCli
            // 
            this.txtDirCli.BackColor = System.Drawing.Color.White;
            this.txtDirCli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirCli.Location = new System.Drawing.Point(115, 119);
            this.txtDirCli.Name = "txtDirCli";
            this.txtDirCli.Size = new System.Drawing.Size(277, 26);
            this.txtDirCli.TabIndex = 2;
            // 
            // txtNomCli
            // 
            this.txtNomCli.BackColor = System.Drawing.Color.White;
            this.txtNomCli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCli.Location = new System.Drawing.Point(115, 78);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(277, 26);
            this.txtNomCli.TabIndex = 1;
            // 
            // txtIdCli
            // 
            this.txtIdCli.BackColor = System.Drawing.Color.White;
            this.txtIdCli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCli.Location = new System.Drawing.Point(115, 37);
            this.txtIdCli.MaxLength = 6;
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(277, 26);
            this.txtIdCli.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 413);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(731, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 413);
            this.panel3.TabIndex = 14;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.pagePacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.groupBoxPac.ResumeLayout(false);
            this.groupBoxPac.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicos)).EndInit();
            this.groupBoxMed.ResumeLayout(false);
            this.groupBoxMed.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClinicas)).EndInit();
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSalir;
        private MetroFramework.Controls.MetroTabPage pagePacientes;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabControl TabControl1;
        private System.Windows.Forms.Button btnMdLimpiar;
        private System.Windows.Forms.Button btnMedGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMedEmail;
        private System.Windows.Forms.TextBox txtMedTel;
        private System.Windows.Forms.TextBox txtMedNombre;
        private System.Windows.Forms.TextBox txtMedExeq;
        private System.Windows.Forms.TextBox txtMedCedula;
        private System.Windows.Forms.TextBox txtMedId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbClinMedic;
        private System.Windows.Forms.Button btnLimpCli;
        private System.Windows.Forms.Button btGuarCli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDirCli;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.DataGridView dgMedicos;
        private System.Windows.Forms.DataGridView dgClinicas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.GroupBox groupBoxMed;
        public System.Windows.Forms.GroupBox groupBoxPac;
        public System.Windows.Forms.GroupBox groupBoxCli;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtId;
    }
}
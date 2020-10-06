namespace citasMedicas
{
    partial class Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.pagePacientes = new MetroFramework.Controls.MetroTabPage();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.btnPacBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.txtPacBuscar = new System.Windows.Forms.TextBox();
            this.picBuscarb = new System.Windows.Forms.PictureBox();
            this.rbPacEmail = new System.Windows.Forms.RadioButton();
            this.rbPacNombre = new System.Windows.Forms.RadioButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgMedicos = new System.Windows.Forms.DataGridView();
            this.btnMedBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMedBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbExequatur = new System.Windows.Forms.RadioButton();
            this.rbMedNombre = new System.Windows.Forms.RadioButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.btnCitBuscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtCitBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rbCitPaciente = new System.Windows.Forms.RadioButton();
            this.rbCitNom = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.pagePacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarb)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultas";
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
            this.TabControl1.TabIndex = 4;
            this.TabControl1.UseSelectable = true;
            // 
            // pagePacientes
            // 
            this.pagePacientes.BackColor = System.Drawing.Color.White;
            this.pagePacientes.Controls.Add(this.dgPacientes);
            this.pagePacientes.Controls.Add(this.btnPacBuscar);
            this.pagePacientes.Controls.Add(this.groupBox1);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPacientes.ColumnHeadersHeight = 22;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPacientes.EnableHeadersVisualStyles = false;
            this.dgPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgPacientes.Location = new System.Drawing.Point(69, 172);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPacientes.Size = new System.Drawing.Size(587, 179);
            this.dgPacientes.TabIndex = 13;
            // 
            // btnPacBuscar
            // 
            this.btnPacBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnPacBuscar.FlatAppearance.BorderSize = 0;
            this.btnPacBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacBuscar.ForeColor = System.Drawing.Color.White;
            this.btnPacBuscar.Location = new System.Drawing.Point(533, 28);
            this.btnPacBuscar.Name = "btnPacBuscar";
            this.btnPacBuscar.Size = new System.Drawing.Size(122, 35);
            this.btnPacBuscar.TabIndex = 12;
            this.btnPacBuscar.Text = "Buscar";
            this.btnPacBuscar.UseVisualStyleBackColor = false;
            this.btnPacBuscar.Click += new System.EventHandler(this.btnPacBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBuscar);
            this.groupBox1.Controls.Add(this.txtPacBuscar);
            this.groupBox1.Controls.Add(this.picBuscarb);
            this.groupBox1.Controls.Add(this.rbPacEmail);
            this.groupBox1.Controls.Add(this.rbPacNombre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // picBuscar
            // 
            this.picBuscar.Image = global::citasMedicas.Properties.Resources.search_filled_27px;
            this.picBuscar.Location = new System.Drawing.Point(383, 79);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(27, 27);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 7;
            this.picBuscar.TabStop = false;
            // 
            // txtPacBuscar
            // 
            this.txtPacBuscar.BackColor = System.Drawing.Color.White;
            this.txtPacBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacBuscar.Location = new System.Drawing.Point(50, 80);
            this.txtPacBuscar.Name = "txtPacBuscar";
            this.txtPacBuscar.Size = new System.Drawing.Size(322, 26);
            this.txtPacBuscar.TabIndex = 6;
            this.txtPacBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtPacBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPacBuscar_KeyUp);
            this.txtPacBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // picBuscarb
            // 
            this.picBuscarb.Image = global::citasMedicas.Properties.Resources.search_filled_blue27px;
            this.picBuscarb.Location = new System.Drawing.Point(383, 79);
            this.picBuscarb.Name = "picBuscarb";
            this.picBuscarb.Size = new System.Drawing.Size(27, 27);
            this.picBuscarb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscarb.TabIndex = 8;
            this.picBuscarb.TabStop = false;
            this.picBuscarb.Visible = false;
            // 
            // rbPacEmail
            // 
            this.rbPacEmail.AutoSize = true;
            this.rbPacEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPacEmail.Location = new System.Drawing.Point(180, 37);
            this.rbPacEmail.Name = "rbPacEmail";
            this.rbPacEmail.Size = new System.Drawing.Size(65, 21);
            this.rbPacEmail.TabIndex = 1;
            this.rbPacEmail.Text = "E-mail";
            this.rbPacEmail.UseVisualStyleBackColor = true;
            this.rbPacEmail.CheckedChanged += new System.EventHandler(this.rbPacEmail_CheckedChanged);
            // 
            // rbPacNombre
            // 
            this.rbPacNombre.AutoSize = true;
            this.rbPacNombre.Checked = true;
            this.rbPacNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPacNombre.Location = new System.Drawing.Point(50, 37);
            this.rbPacNombre.Name = "rbPacNombre";
            this.rbPacNombre.Size = new System.Drawing.Size(79, 21);
            this.rbPacNombre.TabIndex = 0;
            this.rbPacNombre.TabStop = true;
            this.rbPacNombre.Text = "Nombre";
            this.rbPacNombre.UseVisualStyleBackColor = true;
            this.rbPacNombre.CheckedChanged += new System.EventHandler(this.rbPacNombre_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.dgMedicos);
            this.metroTabPage2.Controls.Add(this.btnMedBuscar);
            this.metroTabPage2.Controls.Add(this.groupBox2);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMedicos.ColumnHeadersHeight = 22;
            this.dgMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMedicos.EnableHeadersVisualStyles = false;
            this.dgMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgMedicos.Location = new System.Drawing.Point(69, 172);
            this.dgMedicos.Name = "dgMedicos";
            this.dgMedicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgMedicos.Size = new System.Drawing.Size(586, 179);
            this.dgMedicos.TabIndex = 16;
            // 
            // btnMedBuscar
            // 
            this.btnMedBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnMedBuscar.FlatAppearance.BorderSize = 0;
            this.btnMedBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedBuscar.ForeColor = System.Drawing.Color.White;
            this.btnMedBuscar.Location = new System.Drawing.Point(533, 28);
            this.btnMedBuscar.Name = "btnMedBuscar";
            this.btnMedBuscar.Size = new System.Drawing.Size(122, 35);
            this.btnMedBuscar.TabIndex = 15;
            this.btnMedBuscar.Text = "Buscar";
            this.btnMedBuscar.UseVisualStyleBackColor = false;
            this.btnMedBuscar.Click += new System.EventHandler(this.btnMedBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtMedBuscar);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.rbExequatur);
            this.groupBox2.Controls.Add(this.rbMedNombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(69, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::citasMedicas.Properties.Resources.search_filled_27px;
            this.pictureBox1.Location = new System.Drawing.Point(383, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtMedBuscar
            // 
            this.txtMedBuscar.BackColor = System.Drawing.Color.White;
            this.txtMedBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedBuscar.Location = new System.Drawing.Point(50, 80);
            this.txtMedBuscar.Name = "txtMedBuscar";
            this.txtMedBuscar.Size = new System.Drawing.Size(322, 26);
            this.txtMedBuscar.TabIndex = 6;
            this.txtMedBuscar.Enter += new System.EventHandler(this.txtBuscarMed_Enter);
            this.txtMedBuscar.Leave += new System.EventHandler(this.txtBuscarMed_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::citasMedicas.Properties.Resources.search_filled_blue27px;
            this.pictureBox2.Location = new System.Drawing.Point(383, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // rbExequatur
            // 
            this.rbExequatur.AutoSize = true;
            this.rbExequatur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExequatur.Location = new System.Drawing.Point(180, 37);
            this.rbExequatur.Name = "rbExequatur";
            this.rbExequatur.Size = new System.Drawing.Size(90, 21);
            this.rbExequatur.TabIndex = 1;
            this.rbExequatur.Text = "Exequatur";
            this.rbExequatur.UseVisualStyleBackColor = true;
            this.rbExequatur.CheckedChanged += new System.EventHandler(this.rbExequatur_CheckedChanged);
            // 
            // rbMedNombre
            // 
            this.rbMedNombre.AutoSize = true;
            this.rbMedNombre.Checked = true;
            this.rbMedNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedNombre.Location = new System.Drawing.Point(50, 37);
            this.rbMedNombre.Name = "rbMedNombre";
            this.rbMedNombre.Size = new System.Drawing.Size(79, 21);
            this.rbMedNombre.TabIndex = 0;
            this.rbMedNombre.TabStop = true;
            this.rbMedNombre.Text = "Nombre";
            this.rbMedNombre.UseVisualStyleBackColor = true;
            this.rbMedNombre.CheckedChanged += new System.EventHandler(this.rbMedNombre_CheckedChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.White;
            this.metroTabPage3.Controls.Add(this.dgCitas);
            this.metroTabPage3.Controls.Add(this.btnCitBuscar);
            this.metroTabPage3.Controls.Add(this.groupBox3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(725, 371);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Citas";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // dgCitas
            // 
            this.dgCitas.AllowUserToResizeColumns = false;
            this.dgCitas.AllowUserToResizeRows = false;
            this.dgCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCitas.ColumnHeadersHeight = 22;
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCitas.EnableHeadersVisualStyles = false;
            this.dgCitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.dgCitas.Location = new System.Drawing.Point(69, 172);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgCitas.Size = new System.Drawing.Size(586, 179);
            this.dgCitas.TabIndex = 16;
            // 
            // btnCitBuscar
            // 
            this.btnCitBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnCitBuscar.FlatAppearance.BorderSize = 0;
            this.btnCitBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitBuscar.ForeColor = System.Drawing.Color.White;
            this.btnCitBuscar.Location = new System.Drawing.Point(533, 28);
            this.btnCitBuscar.Name = "btnCitBuscar";
            this.btnCitBuscar.Size = new System.Drawing.Size(122, 35);
            this.btnCitBuscar.TabIndex = 15;
            this.btnCitBuscar.Text = "Buscar";
            this.btnCitBuscar.UseVisualStyleBackColor = false;
            this.btnCitBuscar.Click += new System.EventHandler(this.btnCitBuscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.txtCitBuscar);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.rbCitPaciente);
            this.groupBox3.Controls.Add(this.rbCitNom);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(69, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 130);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::citasMedicas.Properties.Resources.search_filled_27px;
            this.pictureBox3.Location = new System.Drawing.Point(383, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // txtCitBuscar
            // 
            this.txtCitBuscar.BackColor = System.Drawing.Color.White;
            this.txtCitBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitBuscar.Location = new System.Drawing.Point(50, 80);
            this.txtCitBuscar.Name = "txtCitBuscar";
            this.txtCitBuscar.Size = new System.Drawing.Size(322, 26);
            this.txtCitBuscar.TabIndex = 6;
            this.txtCitBuscar.Enter += new System.EventHandler(this.txtBuscarCitas_Enter);
            this.txtCitBuscar.Leave += new System.EventHandler(this.txtBuscarCitas_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::citasMedicas.Properties.Resources.search_filled_blue27px;
            this.pictureBox4.Location = new System.Drawing.Point(383, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // rbCitPaciente
            // 
            this.rbCitPaciente.AutoSize = true;
            this.rbCitPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCitPaciente.Location = new System.Drawing.Point(289, 37);
            this.rbCitPaciente.Name = "rbCitPaciente";
            this.rbCitPaciente.Size = new System.Drawing.Size(83, 21);
            this.rbCitPaciente.TabIndex = 1;
            this.rbCitPaciente.Text = "Paciente";
            this.rbCitPaciente.UseVisualStyleBackColor = true;
            this.rbCitPaciente.CheckedChanged += new System.EventHandler(this.rbCitPaciente_CheckedChanged);
            // 
            // rbCitNom
            // 
            this.rbCitNom.AutoSize = true;
            this.rbCitNom.Checked = true;
            this.rbCitNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCitNom.Location = new System.Drawing.Point(50, 37);
            this.rbCitNom.Name = "rbCitNom";
            this.rbCitNom.Size = new System.Drawing.Size(185, 21);
            this.rbCitNom.TabIndex = 0;
            this.rbCitNom.TabStop = true;
            this.rbCitNom.Text = "Nombre/Exequatur Med.";
            this.rbCitNom.UseVisualStyleBackColor = true;
            this.rbCitNom.CheckedChanged += new System.EventHandler(this.rbCitNom_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 413);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(731, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 413);
            this.panel3.TabIndex = 6;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.pagePacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarb)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSalir;
        private MetroFramework.Controls.MetroTabControl TabControl1;
        private MetroFramework.Controls.MetroTabPage pagePacientes;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPacEmail;
        private System.Windows.Forms.RadioButton rbPacNombre;
        private System.Windows.Forms.TextBox txtPacBuscar;
        private System.Windows.Forms.Button btnPacBuscar;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.PictureBox picBuscarb;
        private System.Windows.Forms.Button btnMedBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMedBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbExequatur;
        private System.Windows.Forms.RadioButton rbMedNombre;
        private System.Windows.Forms.Button btnCitBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtCitBuscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rbCitPaciente;
        private System.Windows.Forms.RadioButton rbCitNom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.DataGridView dgMedicos;
        private System.Windows.Forms.DataGridView dgCitas;
    }
}
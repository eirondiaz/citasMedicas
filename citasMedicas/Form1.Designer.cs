namespace citasMedicas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plUtl = new System.Windows.Forms.Panel();
            this.plCons = new System.Windows.Forms.Panel();
            this.plProc = new System.Windows.Forms.Panel();
            this.plMan = new System.Windows.Forms.Panel();
            this.btnUtilitarios = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnManten = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picMin);
            this.panel1.Controls.Add(this.picSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Citas Medicas";
            // 
            // picMin
            // 
            this.picMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMin.Image = global::citasMedicas.Properties.Resources.minus_math_16px;
            this.picMin.Location = new System.Drawing.Point(966, 0);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(44, 29);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMin.TabIndex = 2;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            this.picMin.MouseLeave += new System.EventHandler(this.picMin_MouseLeave);
            this.picMin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMin_MouseMove);
            // 
            // picSalir
            // 
            this.picSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSalir.Image = global::citasMedicas.Properties.Resources.delete_sign_16px;
            this.picSalir.Location = new System.Drawing.Point(1010, 0);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(44, 29);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSalir.TabIndex = 1;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            this.picSalir.MouseLeave += new System.EventHandler(this.picSalir_MouseLeave);
            this.picSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSalir_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.plUtl);
            this.panel2.Controls.Add(this.plCons);
            this.panel2.Controls.Add(this.plProc);
            this.panel2.Controls.Add(this.plMan);
            this.panel2.Controls.Add(this.btnUtilitarios);
            this.panel2.Controls.Add(this.btnConsultas);
            this.panel2.Controls.Add(this.btnProcesos);
            this.panel2.Controls.Add(this.btnManten);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 538);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(20, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 3;
            // 
            // plUtl
            // 
            this.plUtl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.plUtl.Location = new System.Drawing.Point(0, 335);
            this.plUtl.Name = "plUtl";
            this.plUtl.Size = new System.Drawing.Size(7, 48);
            this.plUtl.TabIndex = 6;
            this.plUtl.Visible = false;
            // 
            // plCons
            // 
            this.plCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.plCons.Location = new System.Drawing.Point(0, 287);
            this.plCons.Name = "plCons";
            this.plCons.Size = new System.Drawing.Size(7, 48);
            this.plCons.TabIndex = 5;
            this.plCons.Visible = false;
            // 
            // plProc
            // 
            this.plProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.plProc.Location = new System.Drawing.Point(0, 239);
            this.plProc.Name = "plProc";
            this.plProc.Size = new System.Drawing.Size(7, 48);
            this.plProc.TabIndex = 3;
            this.plProc.Visible = false;
            // 
            // plMan
            // 
            this.plMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.plMan.Location = new System.Drawing.Point(0, 191);
            this.plMan.Name = "plMan";
            this.plMan.Size = new System.Drawing.Size(7, 48);
            this.plMan.TabIndex = 2;
            this.plMan.Visible = false;
            // 
            // btnUtilitarios
            // 
            this.btnUtilitarios.FlatAppearance.BorderSize = 0;
            this.btnUtilitarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilitarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilitarios.ForeColor = System.Drawing.Color.DimGray;
            this.btnUtilitarios.Image = global::citasMedicas.Properties.Resources.money_27px;
            this.btnUtilitarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilitarios.Location = new System.Drawing.Point(0, 335);
            this.btnUtilitarios.Name = "btnUtilitarios";
            this.btnUtilitarios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUtilitarios.Size = new System.Drawing.Size(254, 48);
            this.btnUtilitarios.TabIndex = 4;
            this.btnUtilitarios.Text = "         Utilitarios";
            this.btnUtilitarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilitarios.UseVisualStyleBackColor = true;
            this.btnUtilitarios.Click += new System.EventHandler(this.btnUtilitarios_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.DimGray;
            this.btnConsultas.Image = global::citasMedicas.Properties.Resources.wish_list_27px;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 287);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(254, 48);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "         Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.FlatAppearance.BorderSize = 0;
            this.btnProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.ForeColor = System.Drawing.Color.DimGray;
            this.btnProcesos.Image = global::citasMedicas.Properties.Resources.list_filled_27px;
            this.btnProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Location = new System.Drawing.Point(0, 239);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProcesos.Size = new System.Drawing.Size(254, 48);
            this.btnProcesos.TabIndex = 2;
            this.btnProcesos.Text = "         Procesos";
            this.btnProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnManten
            // 
            this.btnManten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManten.FlatAppearance.BorderSize = 0;
            this.btnManten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManten.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManten.ForeColor = System.Drawing.Color.DimGray;
            this.btnManten.Image = global::citasMedicas.Properties.Resources.maintenance_27px33;
            this.btnManten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManten.Location = new System.Drawing.Point(0, 191);
            this.btnManten.Name = "btnManten";
            this.btnManten.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnManten.Size = new System.Drawing.Size(254, 48);
            this.btnManten.TabIndex = 1;
            this.btnManten.Text = "         Mantenimientos";
            this.btnManten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManten.UseVisualStyleBackColor = true;
            this.btnManten.Click += new System.EventHandler(this.btnManten_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::citasMedicas.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(62, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::citasMedicas.Properties.Resources.bg11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnManten;
        private System.Windows.Forms.Button btnUtilitarios;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel plMan;
        public System.Windows.Forms.Panel plCons;
        public System.Windows.Forms.Panel plProc;
        public System.Windows.Forms.Panel plUtl;
    }
}

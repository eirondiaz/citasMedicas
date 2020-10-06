namespace citasMedicas
{
    partial class Utilitarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbUsdDop = new System.Windows.Forms.RadioButton();
            this.rbDopUsd = new System.Windows.Forms.RadioButton();
            this.txtDivisa = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilitarios";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conversor de divisas";
            // 
            // rbUsdDop
            // 
            this.rbUsdDop.AutoSize = true;
            this.rbUsdDop.Checked = true;
            this.rbUsdDop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsdDop.Location = new System.Drawing.Point(58, 144);
            this.rbUsdDop.Name = "rbUsdDop";
            this.rbUsdDop.Size = new System.Drawing.Size(89, 23);
            this.rbUsdDop.TabIndex = 5;
            this.rbUsdDop.TabStop = true;
            this.rbUsdDop.Text = "USD/DOP";
            this.rbUsdDop.UseVisualStyleBackColor = true;
            this.rbUsdDop.CheckedChanged += new System.EventHandler(this.rbUsdDop_CheckedChanged);
            // 
            // rbDopUsd
            // 
            this.rbDopUsd.AutoSize = true;
            this.rbDopUsd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDopUsd.Location = new System.Drawing.Point(184, 144);
            this.rbDopUsd.Name = "rbDopUsd";
            this.rbDopUsd.Size = new System.Drawing.Size(88, 23);
            this.rbDopUsd.TabIndex = 6;
            this.rbDopUsd.Text = "DOP/USD";
            this.rbDopUsd.UseVisualStyleBackColor = true;
            this.rbDopUsd.CheckedChanged += new System.EventHandler(this.rbDopUsd_CheckedChanged);
            // 
            // txtDivisa
            // 
            this.txtDivisa.BackColor = System.Drawing.Color.White;
            this.txtDivisa.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisa.Location = new System.Drawing.Point(121, 198);
            this.txtDivisa.Name = "txtDivisa";
            this.txtDivisa.Size = new System.Drawing.Size(144, 36);
            this.txtDivisa.TabIndex = 7;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.BackColor = System.Drawing.Color.Transparent;
            this.lblSimbolo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbolo.ForeColor = System.Drawing.Color.Black;
            this.lblSimbolo.Location = new System.Drawing.Point(55, 200);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(66, 29);
            this.lblSimbolo.TabIndex = 8;
            this.lblSimbolo.Text = "USD$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(430, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 413);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(301, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 413);
            this.panel3.TabIndex = 0;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Location = new System.Drawing.Point(277, 198);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(98, 36);
            this.btnConvertir.TabIndex = 10;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Location = new System.Drawing.Point(82, 253);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(192, 15);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "El conversor solo acepta números";
            this.lblError.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 413);
            this.panel4.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DimGray;
            this.lblResult.Location = new System.Drawing.Point(50, 316);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(225, 58);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "DOP$ 20";
            this.lblResult.Visible = false;
            // 
            // picError
            // 
            this.picError.Image = global::citasMedicas.Properties.Resources.attention_20px;
            this.picError.Location = new System.Drawing.Point(60, 252);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(17, 17);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError.TabIndex = 11;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::citasMedicas.Properties.Resources.badera_dom;
            this.pictureBox2.Location = new System.Drawing.Point(164, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::citasMedicas.Properties.Resources._1200px_Flag_of_the_United_States;
            this.pictureBox1.Location = new System.Drawing.Point(28, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "1 Dólar estadounidense Es igual a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "52.80 Peso ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "dominicano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(25, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "1 peso dominicano = USD$ 0.019";
            // 
            // Utilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 442);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtDivisa);
            this.Controls.Add(this.rbDopUsd);
            this.Controls.Add(this.rbUsdDop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Utilitarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilitarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbUsdDop;
        private System.Windows.Forms.RadioButton rbDopUsd;
        private System.Windows.Forms.TextBox txtDivisa;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}
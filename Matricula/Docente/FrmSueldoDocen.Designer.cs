namespace Matricula.Docente {
    partial class FrmSueldoDocen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSueldoDocen));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnSuperior.Controls.Add(this.lblTitulo);
            this.pnSuperior.Controls.Add(this.pictureBox1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1017, 167);
            this.pnSuperior.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 55);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(453, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro de Docente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(633, 482);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 37);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(106)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(252, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(205, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox1.Location = new System.Drawing.Point(16, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(977, 288);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro del Docente";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCod.Location = new System.Drawing.Point(208, 68);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(22, 31);
            this.lblCod.TabIndex = 23;
            this.lblCod.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Codigo:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDni.Location = new System.Drawing.Point(737, 208);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 32);
            this.txtDni.TabIndex = 11;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCel.Location = new System.Drawing.Point(213, 208);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(180, 32);
            this.txtCel.TabIndex = 10;
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtApe.Location = new System.Drawing.Point(737, 126);
            this.txtApe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(180, 32);
            this.txtApe.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNom.Location = new System.Drawing.Point(213, 126);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 32);
            this.txtNom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(592, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas de T.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(20, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(592, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmSueldoDocen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnSuperior);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSueldoDocen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSueldoDocen";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace Matricula.Alumno {
    partial class FrmMatricula {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricula));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.Label();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.pnSuperior.Size = new System.Drawing.Size(977, 167);
            this.pnSuperior.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(243, 55);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registrar Matricula";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAlumnos);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.cboCiclo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox1.Location = new System.Drawing.Point(16, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(945, 284);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Alumno";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(351, 64);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 31);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "-";
            this.lblId.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDni.Location = new System.Drawing.Point(207, 138);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(17, 23);
            this.txtDni.TabIndex = 10;
            this.txtDni.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "DNI:";

            // 
            // txtCarrera
            // 
            this.txtCarrera.AutoSize = true;
            this.txtCarrera.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtCarrera.Location = new System.Drawing.Point(683, 138);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(22, 31);
            this.txtCarrera.TabIndex = 7;
            this.txtCarrera.Text = "-";
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(207, 64);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(22, 31);
            this.txtNom.TabIndex = 6;
            this.txtNom.Text = "-";
            // 
            // txtCod
            // 
            this.txtCod.AutoSize = true;
            this.txtCod.Location = new System.Drawing.Point(683, 64);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(22, 31);
            this.txtCod.TabIndex = 5;
            this.txtCod.Text = "-";
            // 
            // cboCiclo
            // 
            this.cboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(212, 210);
            this.cboCiclo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(57, 31);
            this.cboCiclo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alumno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Seccion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSec);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cboPeriodo);
            this.groupBox2.Controls.Add(this.txtSeccion);
            this.groupBox2.Controls.Add(this.cboTurno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox2.Location = new System.Drawing.Point(16, 543);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(945, 218);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descipcion";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(440, 159);
            this.lblSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(22, 31);
            this.lblSec.TabIndex = 10;
            this.lblSec.Text = "-";
            this.lblSec.Visible = false;

            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "2019-01",
            "2019-02",
            "2020-00",
            "2020-01"});
            this.cboPeriodo.Location = new System.Drawing.Point(685, 66);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(160, 39);
            this.cboPeriodo.TabIndex = 8;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Enabled = false;
            this.txtSeccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSeccion.Location = new System.Drawing.Point(212, 155);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(160, 32);
            this.txtSeccion.TabIndex = 6;
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde ",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(212, 66);
            this.cboTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(160, 31);
            this.cboTurno.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Periodo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Turno:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnReporte);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox3.Location = new System.Drawing.Point(16, 768);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(945, 122);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(106)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(125, 54);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 47);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(716, 54);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 48);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReporte.Location = new System.Drawing.Point(423, 54);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(155, 47);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(487, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Inscripcion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(779, 197);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 35);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 903);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnSuperior);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMatricula";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.ComboBox cboTurno;
        public System.Windows.Forms.Label txtCod;
        public System.Windows.Forms.Label txtCarrera;
        public System.Windows.Forms.Label txtNom;
        public System.Windows.Forms.Label txtDni;
        public System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnGuardar;
    }
}
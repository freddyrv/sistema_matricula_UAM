namespace Matricula.Docente {
    partial class FrmIEDocente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIEDocente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOpe = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(583, 737);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 37);
            this.btnSalir.TabIndex = 10;
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
            this.btnGuardar.Location = new System.Drawing.Point(229, 737);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(205, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnSuperior.Controls.Add(this.pbFoto);
            this.pnSuperior.Controls.Add(this.btnFoto);
            this.pnSuperior.Controls.Add(this.lblTitulo);
            this.pnSuperior.Controls.Add(this.pictureBox1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1009, 181);
            this.pnSuperior.TabIndex = 8;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Gray;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(864, 4);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(141, 137);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 17;
            this.pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.DarkGray;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Location = new System.Drawing.Point(864, 148);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(141, 28);
            this.btnFoto.TabIndex = 16;
            this.btnFoto.Text = "Ingresar Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 55);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(416, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Datos del Docente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblOpe);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboDistrito);
            this.groupBox1.Controls.Add(this.txtDirrecion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox1.Location = new System.Drawing.Point(16, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(977, 529);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtArea.Location = new System.Drawing.Point(420, 473);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(259, 32);
            this.txtArea.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label13.Location = new System.Drawing.Point(281, 476);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Area:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(372, 68);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 31);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "-";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(800, 409);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(87, 38);
            this.txtHora.TabIndex = 29;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSueldo.Location = new System.Drawing.Point(601, 412);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(105, 32);
            this.txtSueldo.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(716, 415);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Horas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(505, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sueldo:";
            // 
            // lblOpe
            // 
            this.lblOpe.AutoSize = true;
            this.lblOpe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOpe.Location = new System.Drawing.Point(697, 68);
            this.lblOpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpe.Name = "lblOpe";
            this.lblOpe.Size = new System.Drawing.Size(22, 31);
            this.lblOpe.TabIndex = 25;
            this.lblOpe.Text = "-";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.d.Location = new System.Drawing.Point(503, 70);
            this.d.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(120, 23);
            this.d.TabIndex = 24;
            this.d.Text = "Operación:";
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
            this.label11.Location = new System.Drawing.Point(20, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Codigo:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(703, 335);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(184, 31);
            this.cboDistrito.TabIndex = 21;
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDirrecion.Location = new System.Drawing.Point(213, 412);
            this.txtDirrecion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(180, 32);
            this.txtDirrecion.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(20, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirrecion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(505, 338);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Distrito";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(703, 126);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(184, 31);
            this.cboSexo.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Location = new System.Drawing.Point(703, 265);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 32);
            this.txtEmail.TabIndex = 14;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Fecha.Location = new System.Drawing.Point(703, 197);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(184, 32);
            this.Fecha.TabIndex = 13;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDni.Location = new System.Drawing.Point(213, 335);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 32);
            this.txtDni.TabIndex = 11;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCel.Location = new System.Drawing.Point(213, 265);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(180, 32);
            this.txtCel.TabIndex = 10;
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtApe.Location = new System.Drawing.Point(213, 193);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(505, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(503, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(503, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(20, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(20, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(17, 197);
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
            // FrmIEDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 783);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIEDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIEDocente";
            this.Load += new System.EventHandler(this.FrmIEDocente_Load);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblOpe;
        private System.Windows.Forms.Label d;
        public System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label13;
    }
}
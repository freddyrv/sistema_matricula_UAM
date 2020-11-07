namespace Matricula.Cursos {
    partial class FrmCursos {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.mATRICULADataSet1 = new Matricula.MATRICULADataSet1();
            this.cURSOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOSTableAdapter = new Matricula.MATRICULADataSet1TableAdapters.CURSOSTableAdapter();
            this.iDCURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCARRERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCICLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATRICULADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion de cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCURSODataGridViewTextBoxColumn,
            this.nOMCURSODataGridViewTextBoxColumn,
            this.iDCARRERADataGridViewTextBoxColumn,
            this.iDCICLODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cURSOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 203);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(164, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(245, 103);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(326, 104);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // mATRICULADataSet1
            // 
            this.mATRICULADataSet1.DataSetName = "MATRICULADataSet1";
            this.mATRICULADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURSOSBindingSource
            // 
            this.cURSOSBindingSource.DataMember = "CURSOS";
            this.cURSOSBindingSource.DataSource = this.mATRICULADataSet1;
            // 
            // cURSOSTableAdapter
            // 
            this.cURSOSTableAdapter.ClearBeforeFill = true;
            // 
            // iDCURSODataGridViewTextBoxColumn
            // 
            this.iDCURSODataGridViewTextBoxColumn.DataPropertyName = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.HeaderText = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.Name = "iDCURSODataGridViewTextBoxColumn";
            this.iDCURSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMCURSODataGridViewTextBoxColumn
            // 
            this.nOMCURSODataGridViewTextBoxColumn.DataPropertyName = "NOM_CURSO";
            this.nOMCURSODataGridViewTextBoxColumn.HeaderText = "NOM_CURSO";
            this.nOMCURSODataGridViewTextBoxColumn.Name = "nOMCURSODataGridViewTextBoxColumn";
            // 
            // iDCARRERADataGridViewTextBoxColumn
            // 
            this.iDCARRERADataGridViewTextBoxColumn.DataPropertyName = "ID_CARRERA";
            this.iDCARRERADataGridViewTextBoxColumn.HeaderText = "ID_CARRERA";
            this.iDCARRERADataGridViewTextBoxColumn.Name = "iDCARRERADataGridViewTextBoxColumn";
            // 
            // iDCICLODataGridViewTextBoxColumn
            // 
            this.iDCICLODataGridViewTextBoxColumn.DataPropertyName = "ID_CICLO";
            this.iDCICLODataGridViewTextBoxColumn.HeaderText = "ID_CICLO";
            this.iDCICLODataGridViewTextBoxColumn.Name = "iDCICLODataGridViewTextBoxColumn";
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 374);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATRICULADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMenu;
        private MATRICULADataSet1 mATRICULADataSet1;
        private System.Windows.Forms.BindingSource cURSOSBindingSource;
        private MATRICULADataSet1TableAdapters.CURSOSTableAdapter cURSOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCARRERADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCICLODataGridViewTextBoxColumn;
    }
}
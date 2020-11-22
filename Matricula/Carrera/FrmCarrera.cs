﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Cursos {
    public partial class FrmCursos : Form {
        FrmMenu menu = new FrmMenu();
        CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
        public FrmCursos() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu!");
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.ListarCarrera();

        }
    }
}

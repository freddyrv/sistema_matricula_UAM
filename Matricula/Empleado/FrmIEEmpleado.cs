using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Empleado {
    public partial class FrmIEEmpleado : Form {
        FrmMenu menu = new FrmMenu();
        public FrmIEEmpleado() {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            menu.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

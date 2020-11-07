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
    public partial class FrmListarEmpleado : Form {
        FrmMenu menu = new FrmMenu();
        public FrmListarEmpleado() {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtApe.Text = "";
            this.txtCod.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu!");
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

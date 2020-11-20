using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Docente {
    public partial class FrmMenuDocente : Form {
        public FrmMenuDocente() {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar Sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FrmNotas nota = new FrmNotas();
            this.Hide();
            nota.ShowDialog();
            this.Show();

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FrmInfoDocente info = new FrmInfoDocente();
            this.Hide();
            info.ShowDialog();
            this.Show();


        }

        private void btnHorario_Click(object sender, EventArgs e)
        {

        }

        private void btnClases_Click(object sender, EventArgs e)
        {

        }
    }
}

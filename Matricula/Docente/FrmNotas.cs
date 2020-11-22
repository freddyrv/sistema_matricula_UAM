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
    public partial class FrmNotas : Form {
        public FrmNotas() {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
        

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtEspañol.Text = "";
            this.txtMatematica.Text = "";
            this.txtCiencias.Text = "";
            this.txtIngles.Text = "";
            this.txtSociales.Text = "";
        }
    }
}

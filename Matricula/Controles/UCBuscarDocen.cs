using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Controles {
    public partial class UCBuscarDocen : UserControl {
        FrmMenu menu = new FrmMenu();

            public UCBuscarDocen() {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu!");
            menu.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtape.Text = "";
            this.txtCod.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

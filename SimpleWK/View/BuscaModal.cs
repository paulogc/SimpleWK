using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View {
    public partial class BuscaModal : Form {
        public BuscaModal() {
            InitializeComponent();
        }
        
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbBuscar.Text != null)
            {
                lblBusca.Text = cbBuscar.Text + ":";
                txtBuscar.Enabled = true;
            }
        }

        private void lblBusca_Click(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            if(txtBuscar.TextLength > 0)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}

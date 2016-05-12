using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroVenda : View.ModeloCompraVenda
    {
        public CadastroVenda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            MessageBox.Show("Venda finalizada!");
            Close();
        }

        private void btnLocalizarItem_Click(object sender, EventArgs e) {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroCompra : View.ModeloCompraVenda
    {
        public CadastroCompra()
        {
            InitializeComponent();
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            MessageBox.Show("Compra finalizada!");
            Close();
        }

        private void btnLocalizarItem_Click(object sender, EventArgs e) {
            BuscarProduto bp = new BuscarProduto();
            bp.ShowDialog();
        }
    }
}

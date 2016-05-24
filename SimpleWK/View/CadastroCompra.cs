using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class CadastroCompra : View.ModeloCompraVenda
    {
        CompraCtrl compraCtrl = new CompraCtrl();

        public void InserirCB() {
            String[] cbPropriedades = { "Nota fiscal", "Data", "CPF/CNPJ" };
            foreach (String prop in cbPropriedades)
            {
                cbCampo.Items.Add(prop);
            }
        }

        public CadastroCompra()
        {
            InitializeComponent();
            InserirCB();
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
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {
            compraCtrl.getNomeColuna(cbCampo.Text);
            compraCtrl.getValorBusca(txtBusca.Text);
        }
    }
}

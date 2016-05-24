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
    public partial class CadastroVenda : View.ModeloCompraVenda
    {
        VendaCtrl vendaCtrl = new VendaCtrl();

        public void InserirCB() {
            String[] cbPropriedades = { "Nota fiscal", "CPF/CNPJ", "Data" };
            foreach (String prop in cbPropriedades)
            {
                cbCampo.Items.Add(prop);
            }
        }

        public CadastroVenda()
        {
            InitializeComponent();
            InserirCB();
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

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e) {
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {
            vendaCtrl.getNomeColuna(cbCampo.Text);
            vendaCtrl.getValorBusca(txtBusca.Text);
        }
    }
}

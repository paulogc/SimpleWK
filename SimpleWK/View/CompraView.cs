using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAO;
using Model;

namespace View
{
    public partial class CompraView : View.ModeloCompraVenda
    {
        int idFornecedor = 0;
        public CompraView()
        {
            InitializeComponent();
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            if(txtNomeFornecedor.Text != "")
            {
                String buscarPor = txtNomeFornecedor.Text;
                ListaFornecedores fornecedores = new ListaFornecedores(buscarPor, idFornecedor, "Fornecedores");
                fornecedores.ShowDialog();
            }
            else
            {
                ListaFornecedores fornecedores = new ListaFornecedores(idFornecedor, "Fornecedores");
                fornecedores.ShowDialog();
            }
            

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
        }
    }
}

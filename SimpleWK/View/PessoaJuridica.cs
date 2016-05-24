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
    public partial class PessoaJuridica : View.ModeloCadastroGeral
    {
        PessoaJuridicaCtrl pessoaJCtrl = new PessoaJuridicaCtrl();
        public void InserirCB() {
            String[] cbPropriedades = { "Nome", "CNPJ", "Email" };
            foreach (String prop in cbPropriedades)
            {
                cbCampo.Items.Add(prop);
            }
        }

        public PessoaJuridica()
        {
            InitializeComponent();
            InserirCB();
        }
        //chama a tela de cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            Endereco end = new Endereco();
            end.ShowDialog();
            end.Dispose();
        }
               

        private void btnBusca_Click(object sender, EventArgs e) {
            pessoaJCtrl.getNomeColuna(cbCampo.Text);
            pessoaJCtrl.getValorBusca(txtBusca.Text);
        }
    }
}

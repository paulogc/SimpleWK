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
    public partial class PessoaFisica : View.ModeloCadastroGeral
    {
        PessoaFisicaCtrl pessoaFCtrl = new PessoaFisicaCtrl();
        public void InserirCB() {
            String[] cbPropriedades = { "Nome", "CPF", "Email"};
            foreach (String prop in cbPropriedades)
            {
                cbCampo.Items.Add(prop);
            }
        }

        public PessoaFisica()
        {
            InitializeComponent();
            InserirCB();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Chama a tela para cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            Endereco end = new Endereco();
            end.ShowDialog();
            end.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {
            pessoaFCtrl.getNomeColuna(cbCampo.Text);
            pessoaFCtrl.getValorBusca(txtBusca.Text);
        }
    }
}

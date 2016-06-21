using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class PessoaJuridicaView : View.ModeloCadastroGeral
    {
        Localizacao localizacao = new Localizacao();
        public PessoaJuridicaView()
        {
            InitializeComponent();
        }
        //chama a tela de cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            EnderecoView end = new EnderecoView(localizacao);
            end.ShowDialog();
            end.Dispose();
        }
               

        private void btnBusca_Click(object sender, EventArgs e) {

        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            Juridica pessoaJuridica = new Juridica();
            if(localizacao.Bairro != null)
            {
                MessageBox.Show(localizacao.Bairro);
                CreatePessoaJuridica(pessoaJuridica);
            }else
            {
                MessageBox.Show("Você precisa cadastrar a localização antes!");
            }
        }
        
        private void CreatePessoaJuridica(Juridica juridica) {
            juridica.Nome = txtNome.Text;
            juridica.RazaoSocial = txtRazaoSocial.Text;
            juridica.Cnpj = txtCnpj.Text;
            juridica.TelefoneFixo = txtTelefoneFixo.Text;
            juridica.TelefoneMovel = txtTelefoneMovel.Text;
            juridica.Email = txtEmail.Text;
        }
    }
}

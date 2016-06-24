using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using DAO;


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
        private void btnLocalizacao_Click(object sender, EventArgs e)
        {
            EnderecoView end = new EnderecoView(localizacao);
            end.ShowDialog();
            end.Dispose();
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Juridica pessoaJuridica = new Juridica();
                if (localizacao.Bairro != null)
                {
                    pessoaJuridica.Endereco = localizacao;
                    createPessoaJuridica(pessoaJuridica);

                    LocalizacaoDAO locDao = new LocalizacaoDAO();
                    locDao.Create(pessoaJuridica.Endereco);
                    int idEnd = Database.GetInstance().GetId();
                    pessoaJuridica.Endereco.Id = idEnd;

                    PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();

                    pjDao.Create(pessoaJuridica);
                    LimparCampos();

                }
                else
                {
                    MessageBox.Show("Você precisa cadastrar um endereço antes!");
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }
        private void LimparCampos()
        {
            lbID.Text = txtNome.Text = txtRazaoSocial.Text = txtCnpj.Text = txtTelefoneFixo.Text = txtTelefoneMovel.Text = txtEmail.Text = "";
        }

        private void createPessoaJuridica(Juridica juridica)
        {
            juridica.Nome = txtNome.Text;
            juridica.RazaoSocial = txtRazaoSocial.Text;
            juridica.Cnpj = txtCnpj.Text;
            juridica.TelefoneFixo = txtTelefoneFixo.Text;
            juridica.TelefoneMovel = txtTelefoneMovel.Text;
            juridica.Email = txtEmail.Text;
        }
    }
}
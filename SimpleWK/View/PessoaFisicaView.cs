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
    public partial class PessoaFisicaView : View.ModeloCadastroGeral
    {
        Localizacao localizacao = new Localizacao();        
        public PessoaFisicaView()
        {
            InitializeComponent();
        }

        //Chama a tela para cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {            
            EnderecoView end = new EnderecoView(localizacao);
            end.ShowDialog();
            end.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            try
            {
                Fisica pessoaFisica = new Fisica();
                if (localizacao.Bairro != null)
                {
                    pessoaFisica.Endereco = localizacao;
                    createPessoaFisica(pessoaFisica);

                    LocalizacaoDAO locDao = new LocalizacaoDAO();
                    locDao.Create(pessoaFisica.Endereco);
                    int idEnd = Database.GetInstance().GetId();
                    pessoaFisica.Endereco.Id = idEnd;

                    PessoaFisicaDAO pfDao = new PessoaFisicaDAO();

                    pfDao.Create(pessoaFisica);

                }
                else
                {
                    MessageBox.Show("Você precisa cadastrar um endereço antes!");
                }
            }catch(Exception p)
            {
                MessageBox.Show(p.ToString());
            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private void PessoaFisica_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dsFisica.fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.fisicaTableAdapter.Fill(this.dsFisica.fisica);

        }

        private void createPessoaFisica(Fisica pessoaFisica) {
            pessoaFisica.Nome = txtNome.Text;
            pessoaFisica.Sobrenome = txtSobrenome.Text;
            pessoaFisica.TelefoneFixo = txtTelefoneFixo.Text;
            pessoaFisica.TelefoneMovel = txtTelefoneMovel.Text;
            pessoaFisica.Cpf = txtCpf.Text;
            pessoaFisica.Email = txtEmail.Text;
        }
    }
}

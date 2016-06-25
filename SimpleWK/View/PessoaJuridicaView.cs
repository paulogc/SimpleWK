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
            EnderecoView end = new EnderecoView(localizacao.Id, localizacao);
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
                    PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();

                    if (pessoaJuridica.Id > 0)
                    {
                        pjDao.Update(pessoaJuridica);
                        locDao.Update(pessoaJuridica.Endereco);
                        localizacao = new Localizacao();
                    }
                    else
                    {
                        locDao.Create(pessoaJuridica.Endereco);
                        int idEnd = Database.GetInstance().GetId();
                        pessoaJuridica.Endereco.Id = idEnd;
                        pjDao.Create(pessoaJuridica);
                        pessoaJuridica.Endereco.Id = idEnd;
                    }
                    AtualizarGrid();
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
            if ( lbID.Text !="")
            {
                juridica.Id = int.Parse(lbID.Text);
            }
            juridica.Nome = txtNome.Text;
            juridica.RazaoSocial = txtRazaoSocial.Text;
            juridica.Cnpj = txtCnpj.Text;
            juridica.TelefoneFixo = txtTelefoneFixo.Text;
            juridica.TelefoneMovel = txtTelefoneMovel.Text;
            juridica.Email = txtEmail.Text;
        }

        private void PessoaJuridicaView_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            PessoaJuridicaDAO pdao = new PessoaJuridicaDAO();
            dgvPessoaJuridica.DataSource = pdao.ListAllJuridica();
            dgvPessoaJuridica.Columns[0].HeaderText = "ID";
            dgvPessoaJuridica.Columns[1].HeaderText = "Nome";
            dgvPessoaJuridica.Columns[2].HeaderText = "Razão Social";
            dgvPessoaJuridica.Columns[3].HeaderText = "CNPJ";
            dgvPessoaJuridica.Columns[4].HeaderText = "E-mail";
            dgvPessoaJuridica.Columns[5].HeaderText = "Telefone";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String message = "Você deve selecionar um Fornecedor na tabela!";

            Juridica pessoaJuridica = new Juridica();
            PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();

            foreach (DataGridViewRow row in dgvPessoaJuridica.Rows)
            {
                if (row.Selected)
                {
                    pessoaJuridica.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    pessoaJuridica = pjDao.Read(pessoaJuridica.Id);
                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                lbID.Text = pessoaJuridica.Id.ToString();
                txtNome.Text = pessoaJuridica.Nome;
                txtRazaoSocial.Text = pessoaJuridica.RazaoSocial;
                txtCnpj.Text = pessoaJuridica.Cnpj;
                txtEmail.Text = pessoaJuridica.Email;
                txtTelefoneFixo.Text = pessoaJuridica.TelefoneFixo;
                txtTelefoneMovel.Text = pessoaJuridica.TelefoneMovel;
                localizacao = pessoaJuridica.Endereco;

                DialogResult confirm = MessageBox.Show("Deseja excluir o fornecedor?", "Confirmar exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    pjDao.Delete(pessoaJuridica);
                    LimparCampos();
                    AtualizarGrid();
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            String message = "Você deve selecionar um Fornecedor na tabela!";

            Juridica pessoaJuridica = new Juridica();
            foreach (DataGridViewRow row in dgvPessoaJuridica.Rows)
            {
                if (row.Selected)
                {
                    pessoaJuridica.Id = Int32.Parse(row.Cells[0].Value.ToString());

                    PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();
                    pessoaJuridica = pjDao.Read(pessoaJuridica.Id);

                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                lbID.Text = pessoaJuridica.Id.ToString();
                txtNome.Text = pessoaJuridica.Nome;
                txtRazaoSocial.Text = pessoaJuridica.RazaoSocial;
                txtCnpj.Text = pessoaJuridica.Cnpj;
                txtEmail.Text = pessoaJuridica.Email;
                txtTelefoneFixo.Text = pessoaJuridica.TelefoneFixo;
                txtTelefoneMovel.Text = pessoaJuridica.TelefoneMovel;
                localizacao = pessoaJuridica.Endereco;
            }
        }
    }
}
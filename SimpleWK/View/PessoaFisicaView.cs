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
            EnderecoView end = new EnderecoView(localizacao.Id, localizacao);
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
                    PessoaFisicaDAO pfDao = new PessoaFisicaDAO();

                    if(pessoaFisica.Id > 0)
                    {
                        pfDao.Update(pessoaFisica);
                        locDao.Update(pessoaFisica.Endereco);
                        localizacao = new Localizacao();
                    }
                    else
                    {                       
                        locDao.Create(pessoaFisica.Endereco);
                        int idEnd = Database.GetInstance().GetId();
                        pessoaFisica.Endereco.Id = idEnd;
                        pfDao.Create(pessoaFisica);
                        localizacao = new Localizacao();
                    }
                    
                    AtualizarGrid();
                    LimparCampos();
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
            string busca = txtBusca.Text;
            string campo = null;

            switch(cbCampo.Text) {
                case "Nome":
                    campo = "p.nome";
                    break;
                case "CPF":
                    campo = "f.cpf";
                    break;
                case "E-mail":
                    campo = "p.email";
                    break;
                case "Sobrenome":
                    campo = "f.sobrenome";
                    break;
            }

            PessoaFisicaDAO pdao = new PessoaFisicaDAO();
            dgvPessoaFisica.DataSource = pdao.BuscaFisica(busca, campo);
        }



        private void PessoaFisica_Load(object sender, EventArgs e) {
            AtualizarGrid();
            cbCampo.SelectedIndex = 0;
        }

        private void AtualizarGrid() {
            PessoaFisicaDAO pdao = new PessoaFisicaDAO();
            dgvPessoaFisica.DataSource = pdao.ListAllFisica();
            dgvPessoaFisica.Columns[0].HeaderText = "ID";
            dgvPessoaFisica.Columns[1].HeaderText = "Nome";
            dgvPessoaFisica.Columns[2].HeaderText = "Sobrenome";
            dgvPessoaFisica.Columns[3].HeaderText = "CPF";
            dgvPessoaFisica.Columns[4].HeaderText = "E-mail";
            dgvPessoaFisica.Columns[5].HeaderText = "Telefone";
        }

        private void createPessoaFisica(Fisica pessoaFisica) {
            if(lbID.Text != "")
            {
                pessoaFisica.Id = Int32.Parse(lbID.Text);
            }
            pessoaFisica.Nome = txtNome.Text;
            pessoaFisica.Sobrenome = txtSobrenome.Text;
            pessoaFisica.TelefoneFixo = txtTelefoneFixo.Text;
            pessoaFisica.TelefoneMovel = txtTelefoneMovel.Text;
            pessoaFisica.Cpf = txtCpf.Text;
            pessoaFisica.Email = txtEmail.Text;
        }

        private void LimparCampos() {
            lbID.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtTelefoneFixo.Text = "";
            txtTelefoneMovel.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            String message = "Você deve selecionar um Insumo na tabela!";

            Fisica pessoaFisica = new Fisica();
            foreach (DataGridViewRow row in dgvPessoaFisica.Rows)
            {
                if (row.Selected)
                {
                    pessoaFisica.Id = Int32.Parse(row.Cells[0].Value.ToString());

                    PessoaFisicaDAO pfDao = new PessoaFisicaDAO();
                    pessoaFisica = pfDao.Read(pessoaFisica.Id);
                                        
                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                lbID.Text = pessoaFisica.Id.ToString();
                txtNome.Text = pessoaFisica.Nome;
                txtSobrenome.Text = pessoaFisica.Sobrenome;
                txtCpf.Text = pessoaFisica.Cpf;
                txtEmail.Text = pessoaFisica.Email;
                txtTelefoneFixo.Text = pessoaFisica.TelefoneFixo;
                txtTelefoneMovel.Text = pessoaFisica.TelefoneMovel;
                localizacao = pessoaFisica.Endereco;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String message = "Você deve selecionar uma Pessoa na tabela!";

            Fisica pessoaFisica = new Fisica();
            PessoaFisicaDAO pfDao = new PessoaFisicaDAO();

            foreach (DataGridViewRow row in dgvPessoaFisica.Rows)
            {
                if (row.Selected)
                {
                    pessoaFisica.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    pessoaFisica = pfDao.Read(pessoaFisica.Id);
                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                lbID.Text = pessoaFisica.Id.ToString();
                txtNome.Text = pessoaFisica.Nome;
                txtSobrenome.Text = pessoaFisica.Sobrenome;
                txtCpf.Text = pessoaFisica.Cpf;
                txtEmail.Text = pessoaFisica.Email;
                txtTelefoneFixo.Text = pessoaFisica.TelefoneFixo;
                txtTelefoneMovel.Text = pessoaFisica.TelefoneMovel;
                localizacao = pessoaFisica.Endereco;

                DialogResult confirm = MessageBox.Show("Deseja excluir essa pessoa?", "Confirmar exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    LocalizacaoDAO ldao = new LocalizacaoDAO();
                    pfDao.Delete(pessoaFisica);
                    ldao.Delete(pessoaFisica.Endereco);
                    LimparCampos();
                    AtualizarGrid();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAO;

namespace View
{
    public partial class EnderecoView : Form
    {
        Localizacao novo = new Localizacao();
        public EnderecoView(int idLocalizacao, Localizacao endAtual)
        {
            InitializeComponent();
            LocalizacaoDAO localDao = new LocalizacaoDAO();
            Localizacao localizacao = new Localizacao();
            localizacao = localDao.ReadById(idLocalizacao);
            FillText(localizacao);
            novo = endAtual;           
        }

        public EnderecoView() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                Convert.ToInt32(txtNum.Text);
            }
            catch {
                txtNum.Text = "0";
            }
            finally {
                CriarObjeto();
            }
        }

        private void CriarObjeto() {
            novo.Logradouro = txtLogradouro.Text;
            novo.Numero = Int32.Parse(txtNum.Text);
            novo.Complemento = txtComplemento.Text;
            novo.Bairro = txtBairro.Text;
            novo.Cep = txtCep.Text;
            novo.Cidade = txtCidade.Text;
            novo.Uf = cbUf.Text;
            novo.Pais = txtPais.Text;
        }

        private void FillText(Localizacao local) {
            txtLogradouro.Text = local.Logradouro;
            txtBairro.Text = local.Bairro;
            txtNum.Text = local.Numero.ToString();
            txtCidade.Text = local.Cidade;
            txtComplemento.Text = local.Complemento;
            txtCep.Text = local.Cep;
            cbUf.Text = local.Uf;                       
        }

        private void EnderecoView_Load(object sender, EventArgs e) {
        }
    }
}

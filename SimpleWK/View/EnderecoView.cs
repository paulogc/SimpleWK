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

namespace View
{
    public partial class EnderecoView : Form
    {
        public EnderecoView(Localizacao end)
        {
            InitializeComponent();
        }

        public EnderecoView() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {

        }

        private Localizacao CriarObjeto() {
            Localizacao end = new Localizacao();
            end.Logradouro = txtLogradouro.Text;
            end.Numero = Int32.Parse(txtNum.Text);
            end.Complemento = txtComplemento.Text;
            end.Bairro = txtBairro.Text;
            end.Cep = txtCep.Text;
            end.Cidade = txtCidade.Text;
            end.Uf = cbUf.Text;
            end.Pais = txtPais.Text;

            return end;
        }
    }
}

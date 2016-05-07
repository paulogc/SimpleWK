using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class PessoaJuridica : View.ModeloCadastroGeral
    {
        public PessoaJuridica()
        {
            InitializeComponent();
        }
        //chama a tela de cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            Endereco end = new Endereco();
            end.ShowDialog();
            end.Dispose();
        }
    }
}

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

        private void btnLocalizacao_Click(object sender, EventArgs e) {
            Localizacao localizacao = new Localizacao();
            localizacao.Show();
        }
    }
}

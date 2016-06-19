using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class PessoaJuridicaView : View.ModeloCadastroGeral
    {

        public PessoaJuridicaView()
        {
            InitializeComponent();
        }
        //chama a tela de cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            EnderecoView end = new EnderecoView();
            end.ShowDialog();
            end.Dispose();
        }
               

        private void btnBusca_Click(object sender, EventArgs e) {

        }
    }
}

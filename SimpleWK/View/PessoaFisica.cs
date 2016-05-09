using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace View
{
    public partial class PessoaFisica : View.ModeloCadastroGeral
    {
        public PessoaFisica()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Chama a tela para cadastro de endereço
        private void btnLocalizacao_Click(object sender, EventArgs e) {
            Endereco end = new Endereco();
            end.ShowDialog();
            end.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaModal busca = new BuscaModal();
            busca.ShowDialog();
            busca.Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace View
{
    public partial class PessoaFisicaView : View.ModeloCadastroGeral
    {

        public PessoaFisicaView()
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
            EnderecoView end = new EnderecoView();
            end.ShowDialog();
            end.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private void PessoaFisica_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dsFisica.fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.fisicaTableAdapter.Fill(this.dsFisica.fisica);

        }
    }
}

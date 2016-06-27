using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAO;
using Model;

namespace View
{
    public partial class CompraView : View.ModeloCompraVenda
    {
        Juridica pessoaJuridica = new Juridica();
        Insumo insumo = new Insumo();
        int quantidadeTotal = 0;
        decimal totalCompra = 0;

        public CompraView()
        {
            InitializeComponent();
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            if(txtNomeFornecedor.Text != "")
            {
                String buscarPor = txtNomeFornecedor.Text;
                ListaPessoas fornecedores = new ListaPessoas(buscarPor, pessoaJuridica, "Fornecedores");
                fornecedores.ShowDialog();
                PreencherDadosBusca();
            }
            else
            {
                ListaPessoas fornecedores = new ListaPessoas(pessoaJuridica, "Fornecedores");
                fornecedores.ShowDialog();
                PreencherDadosBusca();
            }
            

        }

        public void PreencherDadosBusca() { 
            
            if(pessoaJuridica.Id > 0)
            {
                PessoaJuridicaDAO pjDAO = new PessoaJuridicaDAO();
                pessoaJuridica = pjDAO.Read(pessoaJuridica.Id);
                txtCPFCNPJ.Text = pessoaJuridica.Cnpj.ToString();
                txtNomeFornecedor.Text = pessoaJuridica.Nome + " " + pessoaJuridica.RazaoSocial;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            MessageBox.Show("Compra finalizada!");
            Close();
        }

        private void btnLocalizarItem_Click(object sender, EventArgs e) {
            if(txtNomeItem.Text != "")
            {
                String buscarPor = txtNomeItem.Text;
                ListaItens itens = new ListaItens("Insumos", insumo, buscarPor);
                itens.ShowDialog();
                InsumoDAO insDao = new InsumoDAO();
                insumo = insDao.Read(insumo.Id);
                CompletarItens(insumo);
            }
            else
            {
                ListaItens itens = new ListaItens("Insumos", insumo);
                itens.ShowDialog();
                InsumoDAO insDao = new InsumoDAO();
                insumo = insDao.Read(insumo.Id);
                CompletarItens(insumo);
            }
        }

        private void CompletarItens(Insumo insu) {
            txtIDItem.Text = insu.Id.ToString();
            txtNomeItem.Text = insu.Nome;
            txtItemValorUnitario.Text = insu.ValorCusto.ToString();
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private void LimparCamposInsumo() {
            txtIDItem.Text = "";
            txtItemQuantidade.Text = "";
            txtNomeItem.Text = "";
            txtItemValorUnitario.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            dgvItensInseridos.Rows.Add(insumo.Id,
                insumo.Nome, 
                insumo.Descricao, 
                txtItemQuantidade.Text, 
                insumo.ValorCusto);
            Somar();
            LimparCamposInsumo();
        }

        private void Somar() {
            int qtd = Int32.Parse(txtItemQuantidade.Text);
            totalCompra += insumo.ValorCusto * qtd;
            quantidadeTotal += qtd;

            AtualizarValores();
        }

        private void AtualizarValores() {
            txtToralCompra.Text = totalCompra.ToString();
            txtTotalInsumo.Text = quantidadeTotal.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            String mensagem = "Voce deve selecionar um insumo antes!";

            foreach(DataGridViewRow row in dgvItensInseridos.Rows)
            {
                if (row.Selected)
                {
                    int qtd = Int32.Parse(row.Cells[3].Value.ToString());
                    decimal valor = Decimal.Parse(row.Cells[4].Value.ToString());
                    quantidadeTotal -= qtd;
                    totalCompra -= qtd * valor;
                    AtualizarValores();
                    dgvItensInseridos.Rows.Remove(row);
                    mensagem = "";
                }
            }

            if(mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
        }
    }
}

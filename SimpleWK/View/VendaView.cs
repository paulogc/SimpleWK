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
    public partial class VendaView : View.ModeloCompraVenda
    {
        Fisica pessoaFisica = new Fisica();
        ProdutoFinal produto = new ProdutoFinal();
        int quantidadeTotal = 0;
        decimal totalCompra = 0;
        List<ProdutoAcao> listaProduto = new List<ProdutoAcao>();

        public VendaView()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            if(txtCPFCNPJ.Text == "") {
                MessageBox.Show("Um fornecedor deve ser selecionado");
                txtCPFCNPJ.Text = "";
            }
            else {
                if(totalCompra > 0 && quantidadeTotal > 0) {
                    try {
                        Venda venda = new Venda();
                        venda.NotaFiscal = txtNumNF.Text;
                        PessoaFisicaDAO pdao = new PessoaFisicaDAO();
                        venda.PessoaJF = pdao.BuscarCpf(txtCPFCNPJ.Text);
                        venda.Valor = totalCompra;
                        venda.Produtos = listaProduto;
                        venda.DataHora = DateTime.Now;

                        VendaDAO vendaDAO = new VendaDAO();
                        vendaDAO.Create(venda);
                        MessageBox.Show("Compra finalizada!");
                        Close();
                    }
                    catch(Exception p) {
                        MessageBox.Show(p.ToString());
                    }

                }
                else {
                    MessageBox.Show("Você precisa inserir itens para efetuar a compra");
                }
            }
        }
        public void LimparAposCompra() {
            txtIDItem.Text = "";
            txtItemQuantidade.Text = "";
            txtNomeItem.Text = "";
            txtItemValorUnitario.Text = "";
            txtCPFCNPJ.Text = "";
            txtNumNF.Text = "";
            txtValorTotal.Text = "";
            txtTotalProdutos.Text = "";
            txtNomeFornecedor.Text = "";
            totalCompra = 0;
            quantidadeTotal = 0;
            dgvProdutos.Rows.Clear();
        }

        private void btnLocalizarItem_Click(object sender, EventArgs e) {
            if (txtNomeItem.Text != "")
            {
                String buscarPor = txtNomeItem.Text;
                ListaItens itens = new ListaItens("Produtos", produto, buscarPor);
                itens.ShowDialog();
                ProdutoFinalDAO prodDao = new ProdutoFinalDAO();
                produto = prodDao.Read(produto.Id);
                CompletarItens(produto);
            }
            else
            {
                ListaItens itens = new ListaItens("Produtos", produto);
                itens.ShowDialog();
                ProdutoFinalDAO prodDao = new ProdutoFinalDAO();
                produto = prodDao.Read(produto.Id);
                CompletarItens(produto); 
            }
        }

        private void CompletarItens(ProdutoFinal prod) {
            txtIDItem.Text = prod.Id.ToString();
            txtNomeItem.Text = prod.Nome;
            txtItemValorUnitario.Text = prod.PrecoVenda.ToString();
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e) {
            if (txtNomeFornecedor.Text != "")
            {
                String buscarPor = txtNomeFornecedor.Text;
                ListaPessoas clientes = new ListaPessoas(buscarPor, pessoaFisica, "Clientes");
                clientes.ShowDialog();
                PreencherDadosBusca();
            }
            else
            {
                ListaPessoas clientes = new ListaPessoas(pessoaFisica, "Clientes");
                clientes.ShowDialog();
                PreencherDadosBusca();
            }
        }

        public void PreencherDadosBusca() {

            if (pessoaFisica.Id > 0)
            {
                PessoaFisicaDAO pFDAO = new PessoaFisicaDAO();
                pessoaFisica = pFDAO.Read(pessoaFisica.Id);
                txtCPFCNPJ.Text = pessoaFisica.Cpf.ToString();
                txtNomeFornecedor.Text = pessoaFisica.Nome + " " + pessoaFisica.Sobrenome;
            }
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            if(txtIDItem.Text == "")
                MessageBox.Show("Um insumo deve ser selecionado.");
            else {
                try {
                    ProdutoAcao produtoFinal = new ProdutoAcao();
                    produtoFinal.Id = Int32.Parse(txtIDItem.Text);
                    produtoFinal.Nome = txtNomeItem.Text;
                    produtoFinal.QuantidadeProduto = Int32.Parse(txtItemQuantidade.Text);
                    produtoFinal.ValorCusto = Decimal.Parse(txtItemValorUnitario.Text);

                    listaProduto.Add(produtoFinal);

                    dgvProdutos.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Descricao,
                        txtItemQuantidade.Text,
                        produto.PrecoVenda);
                    Somar();
                    LimparCamposProduto();
                }
                catch(FormatException f) {
                    try {
                        Convert.ToInt32(txtItemQuantidade);
                    }
                    catch {
                        MessageBox.Show("O campo 'quantidade' deve ser preenchido com um valor numérico e inteiro!");
                        txtItemQuantidade.Text = "";
                    }
                }
            }
            }

        private void LimparCamposProduto() {
            txtIDItem.Text = "";
            txtItemQuantidade.Text = "";
            txtNomeItem.Text = "";
            txtItemValorUnitario.Text = "";
        }

        private void Somar() {
            int qtd = Int32.Parse(txtItemQuantidade.Text);
            totalCompra += produto.PrecoVenda * qtd;
            quantidadeTotal += qtd;

            AtualizarValores();
        }

        private void AtualizarValores() {
            txtValorTotal.Text = totalCompra.ToString();
            txtTotalProdutos.Text = quantidadeTotal.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            String mensagem = "Voce deve selecionar um insumo antes!";

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.Selected)
                {
                    int qtd = Int32.Parse(row.Cells[3].Value.ToString());
                    decimal valor = Decimal.Parse(row.Cells[4].Value.ToString());
                    quantidadeTotal -= qtd;
                    totalCompra -= qtd * valor;
                    AtualizarValores();
                    dgvProdutos.Rows.Remove(row);
                    mensagem = "";
                }
            }

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
        }
    }
}

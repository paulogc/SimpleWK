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
    public partial class ProdutoFinalView : View.ModeloCadastroGeral
    {

        List<InsumoProdutoFinal> listaInsumos = new List<InsumoProdutoFinal>();
        public ProdutoFinalView()
        {
            InitializeComponent();
        }

        string str;

        private bool IsNumeric(int Val) {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void Formata(object sender, KeyEventArgs e, object x) {
            
            int KeyCode = e.KeyValue;

            if(!IsNumeric(KeyCode)) {
                e.Handled = true;
                return;
            }
            else {
                e.Handled = true;
            }
            if(((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0)) {
                str = str.Substring(0, str.Length - 1);
            }
            else if(!((KeyCode == 8) || (KeyCode == 46))) {
                str = str + Convert.ToChar(KeyCode);
            }
            if(str.Length == 0) {
                ((TextBox)x).Text = "";
            }
            if(str.Length == 1) {
                ((TextBox)x).Text = "0.0" + str;
            }
            else if(str.Length == 2) {
                ((TextBox)x).Text = "0." + str;
            }
            else if(str.Length > 2) {
                ((TextBox)x).Text = "" + str.Substring(0, str.Length - 2) + "." +
                                str.Substring(str.Length - 2);
            }
        }

        private void ValorKeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtValorCusto_KeyDown(object sender, KeyEventArgs e) {
            Formata(sender, e, txtValorCusto);
        }

        private void txtValorFinal_KeyDown(object sender, KeyEventArgs e) {
            Formata(sender, e, txtValorVenda);
        }

        private void txtValorCusto_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void txtValorFinal_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void btnAddInsumo_Click(object sender, EventArgs e) {
            AdicaoInsumos add = new AdicaoInsumos(listaInsumos);
            add.ShowDialog();
            txtValorVenda.Text = (somaPrecoVenda(listaInsumos)).ToString();
            txtValorCusto.Text = (somaCusto(listaInsumos)).ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            ProdutoFinal produtoFinal = new ProdutoFinal();
            produtoFinal.Insumos = listaInsumos;            

            if(produtoFinal.Insumos.Count > 0)
            {
                ProdutofCreate(produtoFinal);
                ProdutoFinalDAO pfDAO = new ProdutoFinalDAO();
                pfDAO.Create(produtoFinal);
                dgvProdutoFinal.DataSource = pfDAO.ListAllProdutoFinal();
            }
            else
            {
                MessageBox.Show("Você precisa inserir um insumo antes!");
            }
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private Decimal somaPrecoVenda(List<InsumoProdutoFinal> listaPF) {
            Decimal soma = 0;
            foreach(InsumoProdutoFinal insumo in listaPF){
                soma += insumo.ValorCusto * insumo.QuantidadeInsumo;
            }
            soma = soma + (soma * (40/100));
            return soma;
        }

        private Decimal somaCusto(List<InsumoProdutoFinal> listaPF) {
            Decimal soma = 0;
            foreach (InsumoProdutoFinal insumo in listaPF)
                {
                    soma += insumo.ValorCusto * insumo.QuantidadeInsumo;
                }
            return soma;
        }

        private void ProdutofCreate(ProdutoFinal produtof) {

            if (lbID.Text != "") {
                produtof.Id = Int32.Parse(lbID.Text);
            } 
            produtof.Nome = txtNome.Text;
            produtof.Descricao = txtDescricao.Text;
            produtof.PrecoVenda = Decimal.Parse(txtValorVenda.Text);
            produtof.Quantidade = Int32.Parse(txtQuantidade.Text);
            produtof.ValorCusto = Decimal.Parse(txtValorCusto.Text);
            
        }

        private void ProdutoFinalView_Load(object sender, EventArgs e) {
            ProdutoFinalDAO pfDAO = new ProdutoFinalDAO();
            dgvProdutoFinal.DataSource = pfDAO.ListAllProdutoFinal();
            dgvProdutoFinal.Columns[0].HeaderText = "ID";
            dgvProdutoFinal.Columns[1].HeaderText = "Nome";
            dgvProdutoFinal.Columns[2].HeaderText = "Descrição";
            dgvProdutoFinal.Columns[3].HeaderText = "Valor Venda";
            dgvProdutoFinal.Columns[4].HeaderText = "Quantidade";
        }
    }
}

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

        List<InsumoAcao> listaInsumos = new List<InsumoAcao>();
        public ProdutoFinalView()
        {
            InitializeComponent();
        }

        string str;

        private bool IsNumeric(int Val) {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void txtValorVenda_KeyDown(object sender, KeyEventArgs e) {
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                txtValorVenda.Text = "";
            }
            if (str.Length == 1)
            {
                txtValorVenda.Text = "0.0" + str;
            }
            else if (str.Length == 2)
            {
                txtValorVenda.Text = "0." + str;
            }
            else if (str.Length > 2)
            {
                txtValorVenda.Text = "" + str.Substring(0, str.Length - 2) + "." +
                                str.Substring(str.Length - 2);
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtValorCusto_KeyDown(object sender, KeyEventArgs e) {
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                txtValorCusto.Text = "";
            }
            if (str.Length == 1)
            {
                txtValorCusto.Text = "0.0" + str;
            }
            else if (str.Length == 2)
            {
                txtValorCusto.Text = "0." + str;
            }
            else if (str.Length > 2)
            {
                txtValorCusto.Text = "" + str.Substring(0, str.Length - 2) + "." +
                                str.Substring(str.Length - 2);
            }
        }

        private void txtValorCusto_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void btnAddInsumo_Click(object sender, EventArgs e) {
            AdicaoInsumos add = new AdicaoInsumos(listaInsumos);
            add.ShowDialog();
            txtValorVenda.Text = (somaPrecoVenda(listaInsumos)).ToString();
            txtValorCusto.Text = (somaCusto(listaInsumos)).ToString();
            AtualizarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            ProdutoFinal produtoFinal = new ProdutoFinal();
            produtoFinal.Insumos = listaInsumos;            

            if(produtoFinal.Insumos.Count > 0)
            {
                try
                {
                    ProdutofCreate(produtoFinal);
                    ProdutoFinalDAO pfDAO = new ProdutoFinalDAO();

                    if(produtoFinal.Id > 0)
                    {
                        pfDAO.Update(produtoFinal);
                        dgvProdutoFinal.DataSource = pfDAO.ListAllProdutoFinal();
                        listaInsumos = new List<InsumoAcao>();
                        LimparCampos();                        
                    }
                    else
                    {
                        pfDAO.Create(produtoFinal);
                        dgvProdutoFinal.DataSource = pfDAO.ListAllProdutoFinal();
                        listaInsumos = new List<InsumoAcao>();
                        LimparCampos();
                    }

                    
                }
                catch(Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
            }
            else
            {
                MessageBox.Show("Você precisa inserir um insumo antes!");
            }
        }

        private void btnBusca_Click(object sender, EventArgs e) {
            string busca = txtBusca.Text;
            string campo = null;

            switch(cbCampo.Text) {
                case "Nome":
                    campo = "i.nome";
                    break;
                case "Descrição":
                    campo = "i.descricao";
                    break;
            }
            ProdutoFinalDAO idao = new ProdutoFinalDAO();
            dgvProdutoFinal.DataSource = idao.BuscaProdutoFinal(busca, campo);
        }

        private Decimal somaPrecoVenda(List<InsumoAcao> listaPF) {
            Decimal soma = 0;
            foreach(InsumoAcao insumo in listaPF){
                soma += insumo.ValorCusto * insumo.QuantidadeInsumo;
            }
            soma = soma + soma;
            return soma;
        }

        private Decimal somaCusto(List<InsumoAcao> listaPF) {
            Decimal soma = 0;
            foreach (InsumoAcao insumo in listaPF)
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
            produtof.PrecoVenda = somaPrecoVenda(listaInsumos);
            produtof.Quantidade = Int32.Parse(txtQuantidade.Text);
            produtof.ValorCusto = somaCusto(listaInsumos);
            
        }

        private void ProdutoFinalView_Load(object sender, EventArgs e) {
            AtualizarGrid();
        }

        private void FillProdutoFinal(ProdutoFinal produto) {
            if(produto.Id > 0)
            {
                lbID.Text = produto.Id.ToString();
            }
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtValorVenda.Text = produto.PrecoVenda.ToString();
            txtQuantidade.Text = produto.Quantidade.ToString();
            txtValorCusto.Text = somaCusto(produto.Insumos).ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            String message = "Você deve selecionar um Insumo na tabela!";

            ProdutoFinal produtof = new ProdutoFinal();
            foreach (DataGridViewRow row in dgvProdutoFinal.Rows)
            {
                if (row.Selected)
                {
                    produtof.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    message = "";
                }
            }

            if(message != "")
            {
                MessageBox.Show(message.ToString());
            }
            else
            {
                try
                {
                    ProdutoFinalDAO pfDAO = new ProdutoFinalDAO();
                    produtof = pfDAO.Read(produtof.Id);
                    FillFields(produtof);
                    listaInsumos = produtof.Insumos;
                }
                catch(Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
            }

            AtualizarGrid();
        }

        public void LimparCampos() {
            lbID.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValorCusto.Text = "";
            txtValorVenda.Text = "";
        }

        public void FillFields(ProdutoFinal produtoF) {
            if(produtoF.Id > 0)
            {
                lbID.Text = produtoF.Id.ToString();
            }
            txtNome.Text = produtoF.Nome;
            txtDescricao.Text = produtoF.Descricao;
            txtQuantidade.Text = produtoF.Quantidade.ToString();
            txtValorCusto.Text = somaCusto(produtoF.Insumos).ToString();
            txtValorVenda.Text = somaPrecoVenda(produtoF.Insumos).ToString();            
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            String message = "Você deve selecionar um Produto na tabela!";

            ProdutoFinal produtof = new ProdutoFinal();
            foreach (DataGridViewRow row in dgvProdutoFinal.Rows)
            {
                if (row.Selected)
                {
                    produtof.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    message = "";
                }
            }

            if (message != "")
            {
                MessageBox.Show(message.ToString());
            }
            else
            {
                ProdutoFinalDAO pfDAO = new ProdutoFinalDAO();
                produtof = pfDAO.Read(produtof.Id);

                FillFields(produtof);

                DialogResult confirm = MessageBox.Show("Deseja excluir esse Produto?", "Confirmar exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {                    
                    pfDAO.Delete(produtof);
                    dgvProdutoFinal.DataSource = pfDAO.ListAllProdutoFinal();
                    LimparCampos();
                }
                
            }
        }

        private void AtualizarGrid()
        {
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

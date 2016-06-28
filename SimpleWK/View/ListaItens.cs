using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;

namespace View {
    public partial class ListaItens : Form {
        Item itemList = new Item();
        
        public ListaItens(String nomeForm, Item item) {
            InitializeComponent();
            this.Text = nomeForm;
            if (nomeForm == "Insumos")
            {
                PreencherGridInsumo();
            }
            if (nomeForm == "Produtos")
            {
                PreencherGridProduto();
            }
            itemList = item;
        }

        public ListaItens(String nomeForm, Item item, String buscarPor) {
            InitializeComponent();
            this.Text = nomeForm;
            if (nomeForm == "Insumos")
            {
                PreencherGridInsumo(buscarPor);
            }
            if (nomeForm == "Produtos")
            {
                PreencherGridProduto(buscarPor);
            }
            itemList = item;
        }

        private void button1_Click(object sender, EventArgs e) {
            SelecionarItem();
        }

        public void PreencherGridInsumo() {
            InsumoDAO insumoDAO = new InsumoDAO();
            dgvItens.DataSource = insumoDAO.ListAllInsumo();
            HeaderDGV();
        }

        public void PreencherGridProduto() {
            ProdutoFinalDAO produtoFDAO = new ProdutoFinalDAO();
            dgvItens.DataSource = produtoFDAO.ListAllProdutoFinal();
            HeaderDGVProd();
        }

        public void PreencherGridInsumo(String buscarPor) {
            InsumoDAO insumoDAO = new InsumoDAO();
            dgvItens.DataSource = insumoDAO.ListAllInsumo(buscarPor);
            HeaderDGV();
        }

        public void PreencherGridProduto(String buscarPor) {
            ProdutoFinalDAO produtoFDAO = new ProdutoFinalDAO();
            dgvItens.DataSource = produtoFDAO.ListAllProdutoFinal(buscarPor);
            HeaderDGVProd();
        }

        public void HeaderDGV() {
            dgvItens.Columns[0].HeaderText = "ID";
            dgvItens.Columns[1].HeaderText = "Nome";
            dgvItens.Columns[2].HeaderText = "Descrição";
            dgvItens.Columns[3].HeaderText = "Quantidade";
            dgvItens.Columns[4].HeaderText = "Valor de Custo";
        }

        public void HeaderDGVProd() {
            dgvItens.Columns[0].HeaderText = "ID";
            dgvItens.Columns[1].HeaderText = "Nome";
            dgvItens.Columns[2].HeaderText = "Descrição";
            dgvItens.Columns[3].HeaderText = "Quantidade";
            dgvItens.Columns[4].HeaderText = "Valor de Venda";
        }

        public void SelecionarItem() {
            String menssagem = "Você deve selecionar um intem na tabela antes!";

            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                if (row.Selected)
                {
                    itemList.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    menssagem = "";
                }
            }

            if (menssagem != "")
            {
                MessageBox.Show(menssagem);
            }
            else
            {
                Close();
            }
        }

        private void ListaItens_Load(object sender, EventArgs e) {

        }
    }
}

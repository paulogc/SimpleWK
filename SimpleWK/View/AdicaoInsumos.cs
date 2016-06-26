using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Model;
using DAO;

namespace View {
    public partial class AdicaoInsumos : Form {

        List<InsumoProdutoFinal> listaPF = new List<InsumoProdutoFinal>();
        public AdicaoInsumos(List<InsumoProdutoFinal> lista) {
            InitializeComponent();
            listaPF = lista;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            String message = "Você deve selecionar um Insumo na tabela!";
            bool inserir = false;
            int qtd = 0;
            if(txtQtd.Text == "" || Int32.Parse(txtQtd.Text) == 0)
            {
                MessageBox.Show("Você deve digitar a quantidade maior que 0!");
            }
            else
            {
                qtd = Int32.Parse(txtQtd.Text);
                foreach (DataGridViewRow row in dgvInsumos.Rows)
                {
                    InsumoProdutoFinal insumoPF = new InsumoProdutoFinal();
                    if (row.Selected)
                    {
                        if(Int32.Parse(row.Cells[4].Value.ToString()) < qtd)
                        {
                            MessageBox.Show("Não há saldo suficiente em estoque!");
                            message = "";
                        }
                        else
                        {
                            insumoPF.Id = Int32.Parse(row.Cells[0].Value.ToString());
                            insumoPF.Nome = row.Cells[1].Value.ToString();
                            insumoPF.Descricao = row.Cells[2].Value.ToString();
                            insumoPF.QuantidadeInsumo = qtd;
                            insumoPF.ValorCusto = Decimal.Parse(row.Cells[3].Value.ToString());
                            dgvInsumos.Rows.Remove(row);
                            message = "";
                            inserir = true;
                        }
                        
                    }
                    if(insumoPF.Id > 0)
                    {
                        listaPF.Add(insumoPF);
                    }
                }

                if (message != "")
                {
                    MessageBox.Show(message);
                }
                else if(inserir == true)
                {
                    if (listaPF.Count > 0)
                    {
                        AtualizaGridInsumoPF(listaPF);
                        txtQtd.Text = "";
                    }
                }
            }
          
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e) { 

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Close();
        }

        private void AdicaoInsumos_Load(object sender, EventArgs e) {
            AtualizarGridAllInsumos();
        }

        private void AtualizarGridAllInsumos() {
            InsumoDAO insumoDAO = new InsumoDAO();
            dgvInsumos.DataSource = insumoDAO.ListAllInsumo();
            dgvInsumos.Columns[0].HeaderText = "ID";
            dgvInsumos.Columns[1].HeaderText = "Nome";
            dgvInsumos.Columns[2].HeaderText = "Descrição";
            dgvInsumos.Columns[3].HeaderText = "Custo";
            dgvInsumos.Columns[4].HeaderText = "Quantidade";
            if(listaPF.Count > 0)
            {
                foreach(InsumoProdutoFinal insumo in listaPF) { 
                    foreach (DataGridViewRow row in dgvInsumos.Rows)
                    {
                        if(Int32.Parse(row.Cells[0].Value.ToString()) == insumo.Id)
                        {
                            dgvInsumos.Rows.Remove(row);
                        }
                    }
                }
                AtualizaGridInsumoPF(listaPF);
            }
        }

        private void AtualizaGridInsumoPF(List<InsumoProdutoFinal> lista) {          
            foreach(InsumoProdutoFinal insumoPF in lista)
            {
                dgvInsumoPF.Rows.Add(insumoPF.Id.ToString(),
                    insumoPF.Nome.ToString(),
                    insumoPF.Descricao.ToString(),
                    insumoPF.ValorCusto.ToString(),
                    insumoPF.QuantidadeInsumo.ToString());
            }
        }
    }
}

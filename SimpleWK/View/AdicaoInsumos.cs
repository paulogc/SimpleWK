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
        public AdicaoInsumos(ProdutoFinal produtof) {
            InitializeComponent();
        }

        ProdutoFinal produto = new ProdutoFinal();

        private void btnAdd_Click(object sender, EventArgs e) {
            Insumo insumo = new Insumo();
            foreach(DataGridViewRow row in dgvInsumos.Rows) {
                if(row.Selected) {
                    insumo.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    insumo.Nome = row.Cells[1].Value.ToString();
                    insumo.Descricao = row.Cells[2].Value.ToString();
                }
            }
            produto.AddItem(insumo);

            int quantidade=0;
            QuantidadeView qtd = new QuantidadeView(quantidade);
            qtd.Show();
            produto.AddQtd(quantidade);
            dgvInsumoPF.Rows.Clear();
            ListarProdutoFinal();

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e) {            
            MessageBox.Show("Tem certeza que deseja excluir este item?", "Atenção!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Close();
        }

        private void AdicaoInsumos_Load(object sender, EventArgs e) {
            ListarInsumos();
        }

        private void ListarInsumos() {
            InsumoDAO idao = new InsumoDAO();
            dgvInsumos.DataSource = idao.ListAllInsumo();
        }

        private void ListarProdutoFinal() {
            for(int i=0; i<produto.CountItem(); i++) {
                dgvInsumoPF.Rows.Add((produto.Insumos[i].Id).ToString(),
                    (produto.Insumos[i].Nome).ToString(),
                    (produto.Insumos[i].Descricao).ToString(),
                    (produto.QtdeItem[i].ToString()));
            }
        }
    }
}

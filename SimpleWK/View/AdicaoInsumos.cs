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

        int idfPF = 0;
        public AdicaoInsumos(int idProdutoFinal) {
            ListaInsumoPFDAO lpfDao = new ListaInsumoPFDAO();
            dgvInsumos.DataSource = lpfDao.ListInsumoForaProdutoFinal(idProdutoFinal);
            dgvInsumoPF.DataSource = lpfDao.ListInsumosProdutoFinal(idProdutoFinal);
            idfPF = idProdutoFinal;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            
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
            
        }

        private void ListarProdutoFinal(ProdutoFinal produto) {
    

        }
    }
}

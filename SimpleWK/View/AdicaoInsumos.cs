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

namespace View {
    public partial class AdicaoInsumos : Form {
        public AdicaoInsumos(ProdutoFinal produtof) {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            QuantidadeView qtd = new QuantidadeView();
            qtd.Show();
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
    }
}

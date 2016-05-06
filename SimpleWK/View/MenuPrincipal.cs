using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View {
    public partial class MenuPrincipal : Form {
        public MenuPrincipal() {
            InitializeComponent();
        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insumo i = new Insumo();
            i.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoFinal pf = new ProdutoFinal();
            pf.Show();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Show();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaJuridica pj = new PessoaJuridica();
            pj.Show();
        }
    }
}

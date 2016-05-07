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
            i.ShowDialog();
            i.Dispose();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoFinal pf = new ProdutoFinal();
            pf.ShowDialog();
            pf.Dispose();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.ShowDialog();
            pf.Dispose();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaJuridica pj = new PessoaJuridica();
            pj.ShowDialog();
            pj.Dispose();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra cp = new Compra();
            cp.ShowDialog();
            cp.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }
    }
}

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
    public partial class MenuPrincipalView : Form {
        public MenuPrincipalView() {
            InitializeComponent();
        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsumoView i = new InsumoView();
            i.ShowDialog();
            i.Dispose();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoFinalView pf = new ProdutoFinalView();
            pf.ShowDialog();
            pf.Dispose();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaFisicaView pf = new PessoaFisicaView();
            pf.ShowDialog();
            pf.Dispose();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaJuridicaView pj = new PessoaJuridicaView();
            pj.ShowDialog();
            pj.Dispose();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraView cp = new CompraView();
            cp.ShowDialog();
            cp.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            SobreView sobre = new SobreView();
            sobre.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaView cv = new VendaView();
            cv.ShowDialog();
            cv.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class ProdutoFinal : View.ModeloCadastroGeral
    {
        public ProdutoFinal()
        {
            InitializeComponent();
        }

        private void btnAddInsumo_Click(object sender, EventArgs e) {
            AdicaoInsumos addInsumo = new AdicaoInsumos();
            addInsumo.Show();
        }
    }
}

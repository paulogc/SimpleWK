using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ModeloCompraVenda : Form
    {
        public ModeloCompraVenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizarItem_Click(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e) {
            BuscarClienteFornecedor bcv = new BuscarClienteFornecedor();
            bcv.ShowDialog();
            bcv.Dispose();
        }
    }
}

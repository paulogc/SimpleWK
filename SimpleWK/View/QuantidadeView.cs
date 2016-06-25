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
    public partial class QuantidadeView : Form {

        int quantidade;

        public QuantidadeView() {
            InitializeComponent();
        }

        public QuantidadeView(int qtde) {
            InitializeComponent();
            quantidade = qtde;
        }


        private void btnOk_Click(object sender, EventArgs e) {
            quantidade = int.Parse(txtQuantidade.Text);
            this.Dispose();          
        }
    }
}

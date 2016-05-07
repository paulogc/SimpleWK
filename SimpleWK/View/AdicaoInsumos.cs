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

namespace View {
    public partial class AdicaoInsumos : Form {
        public AdicaoInsumos() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Quantidade qtd = new Quantidade();
            qtd.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}

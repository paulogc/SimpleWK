using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAO;

namespace View {
    public partial class ListaFornecedores : Form {
        Juridica pessoaJuridica = new Juridica();

        public ListaFornecedores(Juridica juridica) {
            InitializeComponent();
        }

        private void ListaFornecedores_Load(object sender, EventArgs e) {
            PessoaJuridicaDAO  pjDao = new PessoaJuridicaDAO();
            dgvFornecedor.DataSource = pjDao.ListAllJuridica();

        }
    }
}

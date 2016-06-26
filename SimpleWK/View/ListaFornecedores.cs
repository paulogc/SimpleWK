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

        public ListaFornecedores() {
            InitializeComponent();
            PreencherGrid();
        }

        public ListaFornecedores(String buscarPor) {
            InitializeComponent();
            PreencherGrid(buscarPor);
        }

        private void PreencherGrid() {
            PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();
            dgvFornecedor.DataSource = pjDao.ListAllJuridica();
            DefinirHeader();
        }

        private void PreencherGrid(String buscar) {
            PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();
            dgvFornecedor.DataSource = pjDao.ListAllJuridica(buscar);
            DefinirHeader();
        }

        private void DefinirHeader() {            
            dgvFornecedor.Columns [0].HeaderText = "ID";
            dgvFornecedor.Columns [1].HeaderText = "Nome";
            dgvFornecedor.Columns [2].HeaderText = "Razão Social";
            dgvFornecedor.Columns [3].HeaderText = "CNPJ";
            dgvFornecedor.Columns [4].HeaderText = "E-mail";
            dgvFornecedor.Columns [5].HeaderText = "Telefone";
        }

        private void ListaFornecedores_Load(object sender, EventArgs e) {            

        }
    }
}

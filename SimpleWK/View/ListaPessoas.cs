﻿using System;
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
    public partial class ListaPessoas : Form {
        Pessoa pessoaJuridicaLista = new Juridica();
        

        public ListaPessoas(Pessoa pessoaJuridica, String nomeForm) {
            InitializeComponent();
            this.Text = nomeForm;
            if(nomeForm == "Fornecedores")
            {
                PreencherGridPJ();
            }
            if (nomeForm == "Clientes")
            {
                PreencherGridPF();
            }
            pessoaJuridicaLista = pessoaJuridica;
        }

        public ListaPessoas(String buscarPor, Pessoa pessoaJuridica, String nomeForm) {
            InitializeComponent();
            this.Text = nomeForm;
            if (nomeForm == "Fornecedores")
            {
                PreencherGridPJ(buscarPor);
            }
            if (nomeForm == "Clientes")
            {
                PreencherGridPF(buscarPor);
            }
            pessoaJuridicaLista = pessoaJuridica;
        }

        private void PreencherGridPJ() {
            PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();
            dgvFornecedor.DataSource = pjDao.ListAllJuridica();
            DefinirHeaderPJ();
        }

        private void PreencherGridPJ(String buscar) {
            PessoaJuridicaDAO pjDao = new PessoaJuridicaDAO();
            dgvFornecedor.DataSource = pjDao.ListAllJuridica(buscar);
            DefinirHeaderPJ();
        }

        private void PreencherGridPF() {
            PessoaFisicaDAO pfDao = new PessoaFisicaDAO();
            dgvFornecedor.DataSource = pfDao.ListAllFisica();
            DefinirHeaderPF();
        }

        private void PreencherGridPF(String buscar) {
            PessoaFisicaDAO pfDao = new PessoaFisicaDAO();
            dgvFornecedor.DataSource = pfDao.ListAllFisica(buscar);
            DefinirHeaderPF();
        }

        private void DefinirHeaderPJ() {            
            dgvFornecedor.Columns [0].HeaderText = "ID";
            dgvFornecedor.Columns [1].HeaderText = "Nome";
            dgvFornecedor.Columns [2].HeaderText = "Razão Social";
            dgvFornecedor.Columns [3].HeaderText = "CNPJ";
            dgvFornecedor.Columns [4].HeaderText = "E-mail";
            dgvFornecedor.Columns [5].HeaderText = "Telefone";
        }

        private void DefinirHeaderPF() {
            dgvFornecedor.Columns[0].HeaderText = "ID";
            dgvFornecedor.Columns[1].HeaderText = "Nome";
            dgvFornecedor.Columns[2].HeaderText = "Sobrenome";
            dgvFornecedor.Columns[3].HeaderText = "CPF";
            dgvFornecedor.Columns[4].HeaderText = "E-mail";
            dgvFornecedor.Columns[5].HeaderText = "Telefone";
        }

        private void ListaFornecedores_Load(object sender, EventArgs e) {            

        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            String menssagem = "Você deve selecionar um intem na tabela antes!";

            foreach(DataGridViewRow row in dgvFornecedor.Rows)
            {
                if (row.Selected)
                {
                    pessoaJuridicaLista.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    menssagem = "";
                }
            }

            if(menssagem != "")
            {
                MessageBox.Show(menssagem);
            }
            else
            {
                Close();
            }
            
        }
    }
}

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

namespace View
{
    public partial class EnderecoView : Form
    {
        Localizacao localizacao = new Localizacao();
        public EnderecoView(Localizacao end)
        {
            localizacao = end;
            InitializeComponent();
        }

        public EnderecoView() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            CriarObjeto();
        }

        private void CriarObjeto() {
            localizacao.Logradouro = txtLogradouro.Text;
            localizacao.Numero = Int32.Parse(txtNum.Text);
            localizacao.Complemento = txtComplemento.Text;
            localizacao.Bairro = txtBairro.Text;
            localizacao.Cep = txtCep.Text;
            localizacao.Cidade = txtCidade.Text;
            localizacao.Uf = cbUf.Text;
            localizacao.Pais = txtPais.Text;
        }
    }
}

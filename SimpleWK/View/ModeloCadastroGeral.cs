﻿using System;
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
    public partial class ModeloCadastroGeral : Form
    {

        public ModeloCadastroGeral()
        {
            InitializeComponent();
        }

        private void ModeloCadastroGeral_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

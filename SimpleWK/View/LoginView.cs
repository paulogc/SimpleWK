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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        string usuario = "admin";
        string senha = "admin";

        private void EfetuarLogin() {
            if((tbUsuario.Text == usuario) && (tbSenha.Text == senha)) {
                MenuPrincipalView menu = new MenuPrincipalView();
                this.Hide();
                menu.ShowDialog(); //Abre a interface e espera usuario interagir
                menu.Dispose(); // Libera recurso do Menu
                Dispose(); // Libera recurso Login e fecha apliacação
            }
            else {
                MessageBox.Show("Usuario e/ou senha incorretos!", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Text = tbSenha.Text = "";
                tbUsuario.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == 13) {
                EfetuarLogin();
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == 13) {
                EfetuarLogin();
            }
        }
    }
}

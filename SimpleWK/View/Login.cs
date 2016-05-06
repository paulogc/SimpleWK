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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string usuario = "admin";
        string senha = "admin";

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((tbUsuario.Text == usuario) && (tbSenha.Text == senha))
            {
                MessageBox.Show("Login efetuado com sucesso!");
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.ShowDialog(); //Abre a interface e espera usuario interagir
                menu.Dispose(); // Libera recurso do Menu
                Dispose(); // Libera recurso Login e fecha apliacação
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha estão incorretos!");
                tbUsuario.Text = tbSenha.Text = "";
            }
        }
        //Código para funcionar botão enter
        private void btnOk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((tbUsuario.Text == usuario) && (tbSenha.Text == senha))
                {
                    MessageBox.Show("Login efetuado com sucesso!");
                    MenuPrincipal menu = new MenuPrincipal();
                    this.Hide();
                    menu.ShowDialog(); //Abre a interface e espera usuario interagir
                    menu.Dispose(); // Libera recurso do Menu
                    Dispose(); // Libera recurso Login e fecha apliacação
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha estão incorretos!");
                    tbUsuario.Text = tbSenha.Text = "";
                }
            }
        }
    }
}

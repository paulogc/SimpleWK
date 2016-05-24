using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class ProdutoFinal : View.ModeloCadastroGeral
    {
        ProdutoFinalCtrl pfCtrl = new ProdutoFinalCtrl();
       
        public void InserirCB() {
            String[] cbValues = { "Nome", "Descrição", "Quantidade", "Valor final", "Valor custo" };
            foreach (String valor in cbValues)

            foreach(String valor in cbValues)
            {
                cbCampo.Items.Add(valor);
            }
        }        

        public ProdutoFinal()
        {
            InitializeComponent();
            InserirCB();
        }

        string str;

        private bool IsNumeric(int Val) {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void Formata(object sender, KeyEventArgs e, object x) {
            
            int KeyCode = e.KeyValue;

            if(!IsNumeric(KeyCode)) {
                e.Handled = true;
                return;
            }
            else {
                e.Handled = true;
            }
            if(((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0)) {
                str = str.Substring(0, str.Length - 1);
            }
            else if(!((KeyCode == 8) || (KeyCode == 46))) {
                str = str + Convert.ToChar(KeyCode);
            }
            if(str.Length == 0) {
                ((TextBox)x).Text = "R$";
            }
            if(str.Length == 1) {
                ((TextBox)x).Text = "R$ 0,0" + str;
            }
            else if(str.Length == 2) {
                ((TextBox)x).Text = "R$ 0," + str;
            }
            else if(str.Length > 2) {
                ((TextBox)x).Text = "R$ " + str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }

        private void ValorKeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtValorCusto_KeyDown(object sender, KeyEventArgs e) {
            Formata(sender, e, txtValorCusto);
        }

        private void txtValorFinal_KeyDown(object sender, KeyEventArgs e) {
            Formata(sender, e, txtValorFinal);
        }

        private void txtValorCusto_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void txtValorFinal_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void btnAddInsumo_Click(object sender, EventArgs e) {
            AdicaoInsumos add = new AdicaoInsumos();
            add.ShowDialog();
            add.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {

        }

        private void btnBusca_Click(object sender, EventArgs e) {
            pfCtrl.getNomeColuna(cbCampo.Text);
            pfCtrl.getValorBusca(txtBusca.Text);
        }
    }
}

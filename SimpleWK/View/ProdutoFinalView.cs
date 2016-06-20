using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class ProdutoFinalView : View.ModeloCadastroGeral
    {
        ProdutoFinal produtoLista = new ProdutoFinal();

        public ProdutoFinalView()
        {
            InitializeComponent();
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
            Formata(sender, e, txtValorVenda);
        }

        private void txtValorCusto_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void txtValorFinal_Enter(object sender, EventArgs e) {
            str = "";
        }

        private void btnAddInsumo_Click(object sender, EventArgs e) {            
            AdicaoInsumos add = new AdicaoInsumos(produtoLista);
            add.ShowDialog();
            add.Dispose();
            if(produtoLista.InsumosLenght() > 0) { 
                Decimal custoTotal = somaCusto(produtoLista);
                txtValorCusto.Text = custoTotal.ToString();
                txtValorVenda.Text = (custoTotal + (custoTotal * (30 / 100))).ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            try
            {
                ProdutoFinal produtof = produtoLista;               
                ProdutofCreate(produtof);

            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btnBusca_Click(object sender, EventArgs e) {
        }

        private Decimal somaCusto(ProdutoFinal produtof) {
            Decimal somaCusto = 0;
            foreach (Item item in produtof.Insumos)
            {
                somaCusto += item.ValorCusto;
            }
            return somaCusto;
        }

        private void ProdutofCreate(ProdutoFinal produtof) {
            
            if (produtof.InsumosLenght() > 0) { 
                produtof.Nome = txtNome.Text;
                produtof.Descricao = txtDescricao.Text;
                produtof.PrecoVenda = Decimal.Parse(txtValorVenda.Text);
                produtof.Quantidade = Int32.Parse(txtQuantidade.Text);
                produtof.ValorCusto = Decimal.Parse(txtValorCusto.Text);
            }
            else
            {
                MessageBox.Show("Para Inserir um Produdo ele precisa no mínimo de um Insumo cadastrado na 'Lista de insumos'");
            }
        }
    }
}

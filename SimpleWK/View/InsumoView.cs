using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using DAO;



namespace View
{
    public partial class InsumoView : ModeloCadastroGeral {
      
        
        public InsumoView()
        {
            InitializeComponent();                    
        }

        private void tbValor_TextChanged(object sender, EventArgs e) {

        }

        /*string str;

        private bool IsNumeric(int Val) {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void tbValor_KeyDown(object sender, KeyEventArgs e) {
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
                tbValor.Text = "R$";
            }
            if(str.Length == 1) {
                tbValor.Text = "R$ 0,0" + str;
            }
            else if(str.Length == 2) {
                tbValor.Text = "R$ 0," + str;
            }
            else if(str.Length > 2) {
                tbValor.Text = "R$ " + str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }*/

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            try
            {
                Insumo insumo = CreateInsumo();
                InsumoDAO iDAO = new InsumoDAO();
                iDAO.Create(insumo);
            }
            catch(Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e) {

        }

        private Insumo CreateInsumo() {
            Insumo insumo = new Insumo();
            insumo.Nome = tbNome.Text;
            insumo.Descricao = tbDescricao.Text;
            insumo.Quantidade = Int32.Parse(tbQuantidade.Text);
            insumo.ValorCusto = Double.Parse( tbValor.Text);

            return insumo;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            String message = "Você deve selecionar um Insumo na tabela!";
            
            Insumo insumo = new Insumo();
            foreach (DataGridViewRow row in dgvInsumo.Rows)
            {
                if (row.Selected)
                {
                    insumo.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    insumo.Nome = row.Cells[1].Value.ToString();
                    insumo.Descricao = row.Cells[2].Value.ToString();
                    insumo.Quantidade = Int32.Parse(row.Cells[3].Value.ToString());
                    insumo.ValorCusto = Double.Parse(row.Cells[4].Value.ToString());
                    message = "";
                }
            }
            if(message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                InsumoDAO iDAO = new InsumoDAO();
                iDAO.Update(insumo);
            }
        }
    }
}

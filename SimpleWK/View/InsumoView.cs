using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using DAO;
using System.Globalization;

namespace View
{
    public partial class InsumoView : ModeloCadastroGeral {
        CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");

        public InsumoView()
        {
            InitializeComponent();                    
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            
                try {
                    Insumo insumo = CreateInsumo();
                    InsumoDAO iDAO = new InsumoDAO();
                    if(insumo.Id != 0) {
                        iDAO.Update(insumo);
                    }
                    else {
                        iDAO.Create(insumo);
                    }
                    this.itemTableAdapter.Fill(this.dsInsumo.item);
                    AtualizarGrid();
                    LimparCampos();
                }
                catch(FormatException fe) {
                    int v = 0;
                    try {
                        Convert.ToInt32(tbQuantidade.Text);
                    }
                    catch {
                        v = 1;
                    }
                    try {
                        Convert.ToDecimal(tbValor.Text);
                    }
                    catch {
                        v += 2;
                    }
                    finally {
                        if(v == 1) {
                            MessageBox.Show("O campo 'quantidade' deve ser preenchido com um valor numérico e inteiro!");
                            tbQuantidade.Text = "";
                        }
                        else if(v == 2) {
                            MessageBox.Show("O campo 'valor' deve ser preenchido com um valor numérico!");
                            tbValor.Text = "";
                        }
                        else if(v == 3) {
                            MessageBox.Show("Os campos 'valor' e 'quantidade' devem ser preenchidos com valores numéricos!");
                            tbValor.Text = tbQuantidade.Text = "";
                        }
                    }
                }
                catch(Exception p) {
                    MessageBox.Show(p.ToString());
                }
            
        }

        private void btnBusca_Click(object sender, EventArgs e) {

        }

        private Insumo CreateInsumo() {
            Insumo insumo = new Insumo();
            if (lbID.Text != "")
            {
                insumo.Id = Int32.Parse(lbID.Text);
            }
            insumo.Nome = tbNome.Text;
            insumo.Descricao = tbDescricao.Text;
            insumo.Quantidade = Int32.Parse(tbQuantidade.Text);
            insumo.ValorCusto = Convert.ToDecimal((tbValor.Text.Replace(",", ".")),new CultureInfo("en-US"));

            return insumo;
        }

        private void InsumoView_Load(object sender, EventArgs e) {
            AtualizarGrid();
        }

        private void LimparCampos() {
            lbID.Text = tbNome.Text = tbDescricao.Text = tbQuantidade.Text = tbValor.Text = "";
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
                    insumo.ValorCusto = Decimal.Parse(row.Cells[4].Value.ToString());
                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                lbID.Text = insumo.Id.ToString();
                tbNome.Text = insumo.Nome;
                tbDescricao.Text = insumo.Descricao;
                tbQuantidade.Text = insumo.Quantidade.ToString();
                tbValor.Text = insumo.ValorCusto.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            
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
                    insumo.ValorCusto = Decimal.Parse(row.Cells[4].Value.ToString());
                    message = "";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                try
                {
                    if (insumo != null) {
                        DialogResult di = MessageBox.Show("Deseja realmente o item selecionado?", "Excluir",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (di == DialogResult.Yes) {
                            try {
                                InsumoDAO iDao = new InsumoDAO();
                                iDao.Delete(insumo);
                            }
                            catch(MySql.Data.MySqlClient.MySqlException p) {
                                MessageBox.Show("Este insumo faz parte de um produto final, não é possível excluí-lo!");
                            }
                            catch(Exception p) {
                                MessageBox.Show(p.ToString());
                            }
                            this.itemTableAdapter.Fill(this.dsInsumo.item);
                            AtualizarGrid();                            
                        }
                    }
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
            }
        }

        public void Moeda (ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if(n.Length > 3 & n.Substring (0,1) == "0")
                    n = n.Substring(1, n.Length - 1);
               v = Convert.ToDouble(n) / 100;
               txt.Text = string.Format(ptBR,"{0:0.00}", v);
               txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }
        }
        private void AtualizarGrid()
        {
            InsumoDAO insumo = new InsumoDAO();
            dgvInsumo.DataSource = insumo.ListAllInsumo();
            dgvInsumo.Columns[0].HeaderText = "ID";
            dgvInsumo.Columns[1].HeaderText = "Nome";
            dgvInsumo.Columns[2].HeaderText = "Descrição";
            dgvInsumo.Columns[3].HeaderText = "Quantidade";
            dgvInsumo.Columns[4].HeaderText = "Valor";
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValor);
        }
    }
}

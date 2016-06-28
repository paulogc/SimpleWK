namespace View
{
    partial class VendaView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produtos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalProdutos = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Enabled = false;
            this.txtCPFCNPJ.Location = new System.Drawing.Point(95, 79);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(25, 82);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.Text = "Nome Cliente:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.Text = "Nota Fiscal";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(95, 50);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(376, 20);
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(95, 22);
            // 
            // txtIDItem
            // 
            this.txtIDItem.Enabled = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 24);
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(472, 43);
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Enabled = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProdutos);
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.Click += new System.EventHandler(this.btnLocalizarItem_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Location = new System.Drawing.Point(711, 318);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(49, 13);
            this.Produtos.TabIndex = 11;
            this.Produtos.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total";
            // 
            // txtTotalProdutos
            // 
            this.txtTotalProdutos.Enabled = false;
            this.txtTotalProdutos.Location = new System.Drawing.Point(693, 334);
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.Size = new System.Drawing.Size(92, 20);
            this.txtTotalProdutos.TabIndex = 13;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(695, 383);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(90, 20);
            this.txtValorTotal.TabIndex = 14;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProdutos.Location = new System.Drawing.Point(11, 18);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(654, 226);
            this.dgvProdutos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Unitário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // VendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Produtos);
            this.Name = "VendaView";
            this.Text = "Venda";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.Produtos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtTotalProdutos, 0);
            this.Controls.SetChildIndex(this.txtValorTotal, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalProdutos;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

namespace View
{
    partial class CompraView
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
            this.dgvItensInseridos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalInsumo = new System.Windows.Forms.TextBox();
            this.txtToralCompra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensInseridos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Enabled = false;
            this.txtCPFCNPJ.Location = new System.Drawing.Point(117, 79);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPFCNPJ.Size = new System.Drawing.Size(150, 21);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(72, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.Text = "CNPJ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.Text = "Nome Fornecedor:";
            // 
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(117, 51);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(361, 21);
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(117, 21);
            this.txtNumNF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumNF.Size = new System.Drawing.Size(150, 21);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(271, 22);
            this.txtNomeItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(197, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // txtIDItem
            // 
            this.txtIDItem.Enabled = false;
            this.txtIDItem.Location = new System.Drawing.Point(88, 22);
            this.txtIDItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(479, 45);
            this.btnLocalizarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Enabled = false;
            this.txtItemValorUnitario.Location = new System.Drawing.Point(271, 50);
            this.txtItemValorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(186, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(88, 49);
            this.txtItemQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvItensInseridos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Controls.SetChildIndex(this.dgvItensInseridos, 0);
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.Location = new System.Drawing.Point(498, 16);
            this.btnLocalizarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // 
            // dgvItensInseridos
            // 
            this.dgvItensInseridos.AllowUserToAddRows = false;
            this.dgvItensInseridos.AllowUserToDeleteRows = false;
            this.dgvItensInseridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItensInseridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensInseridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvItensInseridos.Location = new System.Drawing.Point(15, 53);
            this.dgvItensInseridos.Name = "dgvItensInseridos";
            this.dgvItensInseridos.ReadOnly = true;
            this.dgvItensInseridos.Size = new System.Drawing.Size(650, 191);
            this.dgvItensInseridos.TabIndex = 6;
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
            this.Column4.HeaderText = "Qunatidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Unitário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(695, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total de insumos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(712, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Valor total";
            // 
            // txtTotalInsumo
            // 
            this.txtTotalInsumo.Enabled = false;
            this.txtTotalInsumo.Location = new System.Drawing.Point(693, 318);
            this.txtTotalInsumo.Name = "txtTotalInsumo";
            this.txtTotalInsumo.Size = new System.Drawing.Size(92, 20);
            this.txtTotalInsumo.TabIndex = 13;
            // 
            // txtToralCompra
            // 
            this.txtToralCompra.Enabled = false;
            this.txtToralCompra.Location = new System.Drawing.Point(693, 368);
            this.txtToralCompra.Name = "txtToralCompra";
            this.txtToralCompra.Size = new System.Drawing.Size(92, 20);
            this.txtToralCompra.TabIndex = 14;
            // 
            // CompraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Controls.Add(this.txtToralCompra);
            this.Controls.Add(this.txtTotalInsumo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompraView";
            this.Text = "Compra";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtTotalInsumo, 0);
            this.Controls.SetChildIndex(this.txtToralCompra, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensInseridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItensInseridos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalInsumo;
        private System.Windows.Forms.TextBox txtToralCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

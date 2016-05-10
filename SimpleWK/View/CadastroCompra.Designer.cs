namespace View
{
    partial class CadastroCompra
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(156, 97);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCPFCNPJ.Size = new System.Drawing.Size(199, 24);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(96, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.Text = "CNPJ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.Text = "Nome Fornecedor:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(453, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(156, 63);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(300, 24);
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // txtDataNF
            // 
            this.txtDataNF.Location = new System.Drawing.Point(505, 22);
            this.txtDataNF.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDataNF.Size = new System.Drawing.Size(131, 24);
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(156, 26);
            this.txtNumNF.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumNF.Size = new System.Drawing.Size(199, 24);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(361, 27);
            this.txtNomeItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(263, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // txtIDItem
            // 
            this.txtIDItem.Location = new System.Drawing.Point(117, 27);
            this.txtIDItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(464, 56);
            this.btnLocalizarFornecedor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLocalizarFornecedor.Text = "/";
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Location = new System.Drawing.Point(361, 62);
            this.txtItemValorUnitario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(248, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(117, 60);
            this.txtItemQuantidade.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.Location = new System.Drawing.Point(664, 20);
            this.btnLocalizarItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar Compra";
            // 
            // CadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1059, 644);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "CadastroCompra";
            this.Text = "Cadastro de Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

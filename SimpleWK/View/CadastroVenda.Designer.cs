namespace View
{
    partial class CadastroVenda
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
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.Text = "Nº Pedido:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(95, 50);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(376, 20);
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(95, 22);
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
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.Click += new System.EventHandler(this.btnLocalizarItem_Click);
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
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Name = "CadastroVenda";
            this.Text = "Venda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

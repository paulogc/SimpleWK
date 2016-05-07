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
            this.txtCPFCNPJ.Location = new System.Drawing.Point(114, 100);
            this.txtCPFCNPJ.Size = new System.Drawing.Size(200, 24);
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.Text = "CNPJ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(223, 70);
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.Text = "Nome Fornecedor:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.Text = "ID Fornecedor:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(224, 29);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 30);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(364, 67);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(300, 24);
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Location = new System.Drawing.Point(118, 64);
            this.txtIDFornecedor.Size = new System.Drawing.Size(100, 24);
            // 
            // txtDataNF
            // 
            this.txtDataNF.Location = new System.Drawing.Point(270, 26);
            this.txtDataNF.Size = new System.Drawing.Size(100, 24);
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(115, 27);
            this.txtNumNF.Size = new System.Drawing.Size(100, 24);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(305, 29);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 27);
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(672, 62);
            this.btnLocalizarFornecedor.Text = "/";
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Location = new System.Drawing.Point(319, 66);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 65);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
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
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar Compra";
            // 
            // CadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1059, 644);
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

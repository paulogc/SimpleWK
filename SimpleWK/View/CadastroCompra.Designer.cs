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
            this.txtCPFCNPJ.Location = new System.Drawing.Point(116, 79);
            this.txtCPFCNPJ.Size = new System.Drawing.Size(151, 21);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(72, 82);
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
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.Text = "Nome Fornecedor:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(340, 21);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(117, 51);
            this.txtNomeFornecedor.Size = new System.Drawing.Size(226, 21);
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // txtDataNF
            // 
            this.txtDataNF.Location = new System.Drawing.Point(379, 18);
            this.txtDataNF.Size = new System.Drawing.Size(99, 21);
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(117, 21);
            this.txtNumNF.Size = new System.Drawing.Size(150, 21);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(271, 22);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(197, 24);
            // 
            // txtIDItem
            // 
            this.txtIDItem.Location = new System.Drawing.Point(88, 22);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 25);
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(347, 51);
            this.btnLocalizarFornecedor.Text = "/";
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Location = new System.Drawing.Point(271, 50);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(186, 52);
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(88, 49);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 51);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.Location = new System.Drawing.Point(501, 17);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 523);
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

namespace View
{
    partial class ModeloCompraVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLocalizarItem = new System.Windows.Forms.Button();
            this.txtItemValorUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtDataNF = new System.Windows.Forms.TextBox();
            this.txtNumNF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.btnLocalizarItem);
            this.groupBox2.Controls.Add(this.txtItemValorUnitario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtItemQuantidade);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNomeItem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIDItem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(679, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Nota Fiscal";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = global::View.Properties.Resources.delete;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(582, 76);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(92, 41);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::View.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(484, 76);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 41);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarItem.Location = new System.Drawing.Point(510, 22);
            this.btnLocalizarItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLocalizarItem.Name = "btnLocalizarItem";
            this.btnLocalizarItem.Size = new System.Drawing.Size(30, 32);
            this.btnLocalizarItem.TabIndex = 8;
            this.btnLocalizarItem.UseVisualStyleBackColor = true;
            this.btnLocalizarItem.Click += new System.EventHandler(this.btnLocalizarItem_Click);
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Location = new System.Drawing.Point(270, 49);
            this.txtItemValorUnitario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemValorUnitario.Name = "txtItemValorUnitario";
            this.txtItemValorUnitario.Size = new System.Drawing.Size(76, 20);
            this.txtItemValorUnitario.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor unitário:";
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(79, 48);
            this.txtItemQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemQuantidade.Name = "txtItemQuantidade";
            this.txtItemQuantidade.Size = new System.Drawing.Size(76, 20);
            this.txtItemQuantidade.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(270, 22);
            this.txtNomeItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(226, 20);
            this.txtNomeItem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome Item:";
            // 
            // txtIDItem
            // 
            this.txtIDItem.Location = new System.Drawing.Point(71, 22);
            this.txtIDItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDItem.Name = "txtIDItem";
            this.txtIDItem.Size = new System.Drawing.Size(84, 20);
            this.txtIDItem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Item:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 265);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(679, 249);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens inseridos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNome,
            this.dgvQuantidade,
            this.dgvValorUnitario,
            this.dgvValorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.ReadOnly = true;
            // 
            // dgvQuantidade
            // 
            this.dgvQuantidade.HeaderText = "Quantidade";
            this.dgvQuantidade.Name = "dgvQuantidade";
            this.dgvQuantidade.ReadOnly = true;
            // 
            // dgvValorUnitario
            // 
            this.dgvValorUnitario.HeaderText = "Valor Unitário";
            this.dgvValorUnitario.Name = "dgvValorUnitario";
            this.dgvValorUnitario.ReadOnly = true;
            // 
            // dgvValorTotal
            // 
            this.dgvValorTotal.HeaderText = "Valor Total";
            this.dgvValorTotal.Name = "dgvValorTotal";
            this.dgvValorTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPFCNPJ);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnLocalizarFornecedor);
            this.groupBox1.Controls.Add(this.txtNomeFornecedor);
            this.groupBox1.Controls.Add(this.txtDataNF);
            this.groupBox1.Controls.Add(this.txtNumNF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Nota Fiscal";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(117, 82);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(107, 20);
            this.txtCPFCNPJ.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "CPF/CNPJ:";
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(356, 50);
            this.btnLocalizarFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(30, 32);
            this.btnLocalizarFornecedor.TabIndex = 8;
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(117, 54);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(235, 20);
            this.txtNomeFornecedor.TabIndex = 7;
            // 
            // txtDataNF
            // 
            this.txtDataNF.Location = new System.Drawing.Point(395, 22);
            this.txtDataNF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataNF.Name = "txtDataNF";
            this.txtDataNF.Size = new System.Drawing.Size(76, 20);
            this.txtDataNF.TabIndex = 5;
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(117, 22);
            this.txtNumNF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumNF.Name = "txtNumNF";
            this.txtNumNF.Size = new System.Drawing.Size(235, 20);
            this.txtNumNF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Nota Fiscal:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(693, 425);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(693, 470);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(92, 41);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // ModeloCompraVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ModeloCompraVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloCompraVenda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorTotal;
        protected System.Windows.Forms.TextBox txtCPFCNPJ;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtNomeFornecedor;
        protected System.Windows.Forms.TextBox txtDataNF;
        protected System.Windows.Forms.TextBox txtNumNF;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.TextBox txtNomeItem;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtIDItem;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnLocalizarFornecedor;
        protected System.Windows.Forms.TextBox txtItemValorUnitario;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtItemQuantidade;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button btnLocalizarItem;
        protected System.Windows.Forms.Button btnDeletar;
        protected System.Windows.Forms.Button btnAdicionar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnFinalizar;
    }
}
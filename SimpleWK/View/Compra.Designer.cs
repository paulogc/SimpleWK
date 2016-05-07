﻿namespace View
{
    partial class Compra
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemValorUnitario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.txtDataNF = new System.Windows.Forms.TextBox();
            this.txtNumNF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalizarItem = new System.Windows.Forms.Button();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
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
            this.groupBox2.Location = new System.Drawing.Point(13, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Nota Fiscal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Item:";
            // 
            // txtIDItem
            // 
            this.txtIDItem.Location = new System.Drawing.Point(95, 27);
            this.txtIDItem.Name = "txtIDItem";
            this.txtIDItem.Size = new System.Drawing.Size(100, 22);
            this.txtIDItem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome Item:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(319, 27);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(300, 22);
            this.txtNomeItem.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade:";
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(95, 64);
            this.txtItemQuantidade.Name = "txtItemQuantidade";
            this.txtItemQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtItemQuantidade.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor unitário:";
            // 
            // txtItemValorUnitario
            // 
            this.txtItemValorUnitario.Location = new System.Drawing.Point(319, 63);
            this.txtItemValorUnitario.Name = "txtItemValorUnitario";
            this.txtItemValorUnitario.Size = new System.Drawing.Size(100, 22);
            this.txtItemValorUnitario.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 306);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocalizarFornecedor);
            this.groupBox1.Controls.Add(this.txtNomeFornecedor);
            this.groupBox1.Controls.Add(this.txtIDFornecedor);
            this.groupBox1.Controls.Add(this.txtDataNF);
            this.groupBox1.Controls.Add(this.txtNumNF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Nota Fiscal";
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(659, 62);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(30, 30);
            this.btnLocalizarFornecedor.TabIndex = 8;
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(353, 67);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(300, 22);
            this.txtNomeFornecedor.TabIndex = 7;
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Location = new System.Drawing.Point(114, 64);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Size = new System.Drawing.Size(100, 22);
            this.txtIDFornecedor.TabIndex = 6;
            // 
            // txtDataNF
            // 
            this.txtDataNF.Location = new System.Drawing.Point(268, 26);
            this.txtDataNF.Name = "txtDataNF";
            this.txtDataNF.Size = new System.Drawing.Size(100, 22);
            this.txtDataNF.TabIndex = 5;
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(113, 27);
            this.txtNumNF.Name = "txtNumNF";
            this.txtNumNF.Size = new System.Drawing.Size(100, 22);
            this.txtNumNF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Nota Fiscal:";
            // 
            // btnLocalizarItem
            // 
            this.btnLocalizarItem.BackgroundImage = global::View.Properties.Resources.search2;
            this.btnLocalizarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarItem.FlatAppearance.BorderSize = 0;
            this.btnLocalizarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarItem.Location = new System.Drawing.Point(626, 25);
            this.btnLocalizarItem.Name = "btnLocalizarItem";
            this.btnLocalizarItem.Size = new System.Drawing.Size(30, 30);
            this.btnLocalizarItem.TabIndex = 8;
            this.btnLocalizarItem.UseVisualStyleBackColor = true;
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
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::View.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(645, 94);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 50);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = global::View.Properties.Resources.delete;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(776, 94);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(123, 50);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(924, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(924, 579);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(123, 50);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 644);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Compra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtIDFornecedor;
        private System.Windows.Forms.TextBox txtDataNF;
        private System.Windows.Forms.TextBox txtNumNF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        private System.Windows.Forms.TextBox txtItemValorUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLocalizarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorTotal;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
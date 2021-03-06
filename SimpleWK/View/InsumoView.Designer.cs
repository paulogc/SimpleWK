﻿namespace View
{
    partial class InsumoView
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInsumo = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInsumo = new View.dsInsumo();
            this.itemTableAdapter = new View.dsInsumoTableAdapters.itemTableAdapter();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbValor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.tbQuantidade);
            this.groupBox1.Controls.Add(this.tbDescricao);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.SetChildIndex(this.lbID, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbNome, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbDescricao, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbQuantidade, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbValor, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInsumo);
            this.groupBox2.Controls.SetChildIndex(this.txtBusca, 0);
            this.groupBox2.Controls.SetChildIndex(this.cbCampo, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnBusca, 0);
            this.groupBox2.Controls.SetChildIndex(this.dgvInsumo, 0);
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // cbCampo
            // 
            this.cbCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.Items.AddRange(new object[] {
            "Nome",
            "Descrição"});
            // 
            // txtBusca
            // 
            this.txtBusca.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantidade:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(133, 92);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 24);
            this.tbNome.TabIndex = 7;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(133, 137);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(200, 24);
            this.tbDescricao.TabIndex = 8;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(573, 91);
            this.tbQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(151, 24);
            this.tbQuantidade.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgID,
            this.dvgNome,
            this.dvgDescricao,
            this.dvgCategoria,
            this.dvgQuantidade,
            this.dvgValor});
            this.dataGridView1.Location = new System.Drawing.Point(19, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // dvgID
            // 
            this.dvgID.HeaderText = "ID";
            this.dvgID.Name = "dvgID";
            // 
            // dvgNome
            // 
            this.dvgNome.HeaderText = "Nome";
            this.dvgNome.Name = "dvgNome";
            // 
            // dvgDescricao
            // 
            this.dvgDescricao.HeaderText = "Descrição";
            this.dvgDescricao.Name = "dvgDescricao";
            // 
            // dvgCategoria
            // 
            this.dvgCategoria.HeaderText = "Categoria";
            this.dvgCategoria.Name = "dvgCategoria";
            // 
            // dvgQuantidade
            // 
            this.dvgQuantidade.HeaderText = "Quantidade";
            this.dvgQuantidade.Name = "dvgQuantidade";
            // 
            // dvgValor
            // 
            this.dvgValor.HeaderText = "Valor";
            this.dvgValor.Name = "dvgValor";
            // 
            // dgvInsumo
            // 
            this.dgvInsumo.AllowUserToAddRows = false;
            this.dgvInsumo.AllowUserToDeleteRows = false;
            this.dgvInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumo.Location = new System.Drawing.Point(15, 92);
            this.dgvInsumo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvInsumo.Name = "dgvInsumo";
            this.dgvInsumo.ReadOnly = true;
            this.dgvInsumo.Size = new System.Drawing.Size(1013, 254);
            this.dgvInsumo.TabIndex = 0;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.dsInsumo;
            // 
            // dsInsumo
            // 
            this.dsInsumo.DataSetName = "dsInsumo";
            this.dsInsumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.dsInsumo;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(573, 134);
            this.tbValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 24);
            this.tbValor.TabIndex = 11;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            // 
            // InsumoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1059, 644);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "InsumoView";
            this.Text = "Cadastro de Insumo";
            this.Load += new System.EventHandler(this.InsumoView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgValor;
        private System.Windows.Forms.DataGridView dgvInsumo;
        private dsInsumo dsInsumo;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private dsInsumoTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.TextBox tbValor;
    }
}

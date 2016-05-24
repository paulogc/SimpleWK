namespace View
{
    partial class PessoaJuridica
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
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizacao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPessoaJuridica = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaJuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btnLocalizacao);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNome, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEmail, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtRazaoSocial, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnLocalizacao, 0);
            this.groupBox1.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.maskedTextBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label9, 0);
            this.groupBox1.Controls.SetChildIndex(this.maskedTextBox3, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPessoaJuridica);
            this.groupBox2.Controls.SetChildIndex(this.dgvPessoaJuridica, 0);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(119, 92);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(312, 21);
            this.txtRazaoSocial.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Razão Social:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 21);
            this.txtEmail.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 61);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 21);
            this.txtNome.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "CNPJ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefone fixo:";
            // 
            // btnLocalizacao
            // 
            this.btnLocalizacao.Location = new System.Drawing.Point(531, 22);
            this.btnLocalizacao.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalizacao.Name = "btnLocalizacao";
            this.btnLocalizacao.Size = new System.Drawing.Size(120, 31);
            this.btnLocalizacao.TabIndex = 24;
            this.btnLocalizacao.Text = "Localização";
            this.btnLocalizacao.UseVisualStyleBackColor = true;
            this.btnLocalizacao.Click += new System.EventHandler(this.btnLocalizacao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNome,
            this.dgvRazaoSocial,
            this.dgvCNPJ});
            this.dataGridView1.Location = new System.Drawing.Point(18, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.Width = 239;
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.Width = 240;
            // 
            // dgvRazaoSocial
            // 
            this.dgvRazaoSocial.HeaderText = "Razão Social:";
            this.dgvRazaoSocial.Name = "dgvRazaoSocial";
            this.dgvRazaoSocial.Width = 239;
            // 
            // dgvCNPJ
            // 
            this.dgvCNPJ.HeaderText = "CNPJ";
            this.dgvCNPJ.Name = "dgvCNPJ";
            this.dgvCNPJ.Width = 239;
            // 
            // dgvPessoaJuridica
            // 
            this.dgvPessoaJuridica.AllowUserToAddRows = false;
            this.dgvPessoaJuridica.AllowUserToDeleteRows = false;
            this.dgvPessoaJuridica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoaJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaJuridica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.RazaoSocial,
            this.CNPJ,
            this.Telefone,
            this.Email});
            this.dgvPessoaJuridica.Location = new System.Drawing.Point(8, 61);
            this.dgvPessoaJuridica.Name = "dgvPessoaJuridica";
            this.dgvPessoaJuridica.ReadOnly = true;
            this.dgvPessoaJuridica.Size = new System.Drawing.Size(760, 206);
            this.dgvPessoaJuridica.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = "RazaoSocial";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 157);
            this.maskedTextBox1.Mask = "(__) ____-____";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 21);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(119, 124);
            this.maskedTextBox2.Mask = "__,___,___/____-__";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(123, 21);
            this.maskedTextBox2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Telefone Móvel:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(331, 157);
            this.maskedTextBox3.Mask = "(00) 00000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox3.TabIndex = 22;
            // 
            // PessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PessoaJuridica";
            this.Text = "Cadastro Pessoa Juridica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaJuridica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCNPJ;
        private System.Windows.Forms.DataGridView dgvPessoaJuridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}

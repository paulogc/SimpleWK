namespace View
{
    partial class EnderecoView
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
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.cbUf);
            this.gbEndereco.Controls.Add(this.txtCep);
            this.gbEndereco.Controls.Add(this.btnCancelar);
            this.gbEndereco.Controls.Add(this.btnSalvar);
            this.gbEndereco.Controls.Add(this.txtPais);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtNum);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.label7);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.label2);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.Location = new System.Drawing.Point(10, 11);
            this.gbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Padding = new System.Windows.Forms.Padding(2);
            this.gbEndereco.Size = new System.Drawing.Size(577, 205);
            this.gbEndereco.TabIndex = 0;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Dados da localização";
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(350, 101);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(65, 23);
            this.cbUf.TabIndex = 12;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(462, 67);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(102, 21);
            this.txtCep.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::View.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(483, 144);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::View.Properties.Resources.save;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(386, 144);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 41);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(461, 101);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(103, 21);
            this.txtPais.TabIndex = 13;
            this.txtPais.Text = "Brasil";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(97, 101);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(199, 21);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(291, 67);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(124, 21);
            this.txtBairro.TabIndex = 9;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(483, 31);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(81, 21);
            this.txtNum.TabIndex = 8;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(97, 31);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(352, 21);
            this.txtLogradouro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "País:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logradouro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(97, 67);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(139, 21);
            this.txtComplemento.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Complemento:";
            // 
            // EnderecoView
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(595, 225);
            this.Controls.Add(this.gbEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EnderecoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço";
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
    }
}
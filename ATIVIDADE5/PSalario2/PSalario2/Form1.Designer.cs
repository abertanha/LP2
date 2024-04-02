namespace PSalario2
{
    partial class Form1
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
            this.mskAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.numpFilhos = new System.Windows.Forms.NumericUpDown();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.mskSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numpFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // mskAliqIRPF
            // 
            this.mskAliqIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAliqIRPF.Location = new System.Drawing.Point(170, 299);
            this.mskAliqIRPF.Mask = "00.00%";
            this.mskAliqIRPF.Name = "mskAliqIRPF";
            this.mskAliqIRPF.ReadOnly = true;
            this.mskAliqIRPF.Size = new System.Drawing.Size(241, 26);
            this.mskAliqIRPF.TabIndex = 66;
            // 
            // mskAliqINSS
            // 
            this.mskAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAliqINSS.Location = new System.Drawing.Point(170, 256);
            this.mskAliqINSS.Mask = "00.00%";
            this.mskAliqINSS.Name = "mskAliqINSS";
            this.mskAliqINSS.ReadOnly = true;
            this.mskAliqINSS.Size = new System.Drawing.Size(240, 26);
            this.mskAliqINSS.TabIndex = 65;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(543, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(241, 36);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(543, 370);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(241, 36);
            this.btnFechar.TabIndex = 63;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // numpFilhos
            // 
            this.numpFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpFilhos.Location = new System.Drawing.Point(170, 126);
            this.numpFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numpFilhos.Name = "numpFilhos";
            this.numpFilhos.Size = new System.Drawing.Size(120, 26);
            this.numpFilhos.TabIndex = 62;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIRPF.Location = new System.Drawing.Point(543, 299);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.ReadOnly = true;
            this.txtDescIRPF.Size = new System.Drawing.Size(241, 26);
            this.txtDescIRPF.TabIndex = 61;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescINSS.Location = new System.Drawing.Point(543, 256);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.ReadOnly = true;
            this.txtDescINSS.Size = new System.Drawing.Size(241, 26);
            this.txtDescINSS.TabIndex = 60;
            this.txtDescINSS.Text = "\'";
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiquido.Location = new System.Drawing.Point(170, 380);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.ReadOnly = true;
            this.txtSalLiquido.Size = new System.Drawing.Size(241, 26);
            this.txtSalLiquido.TabIndex = 59;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(170, 336);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.ReadOnly = true;
            this.txtSalFamilia.Size = new System.Drawing.Size(241, 26);
            this.txtSalFamilia.TabIndex = 58;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconto.Location = new System.Drawing.Point(170, 175);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(223, 36);
            this.btnDesconto.TabIndex = 57;
            this.btnDesconto.Text = "Verifica Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // mskSalBruto
            // 
            this.mskSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSalBruto.Location = new System.Drawing.Point(170, 83);
            this.mskSalBruto.Mask = "0000.00";
            this.mskSalBruto.Name = "mskSalBruto";
            this.mskSalBruto.Size = new System.Drawing.Size(165, 26);
            this.mskSalBruto.TabIndex = 56;
            this.mskSalBruto.Validated += new System.EventHandler(this.mskSalBruto_Validated);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.Location = new System.Drawing.Point(170, 44);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(335, 26);
            this.txtFuncionario.TabIndex = 55;
            this.txtFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuncionario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Desconto IRPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Desconto INSS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Salário Líquido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Salário Família";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Alíquota IRPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Alíquota INSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Número de Filhos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Salário Bruto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nome Funcionário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskAliqIRPF);
            this.Controls.Add(this.mskAliqINSS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.numpFilhos);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.mskSalBruto);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numpFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskAliqINSS;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.NumericUpDown numpFilhos;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.MaskedTextBox mskSalBruto;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


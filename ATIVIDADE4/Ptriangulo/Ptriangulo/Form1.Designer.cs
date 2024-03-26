namespace Ptriangulo
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
            this.lbDimensaoA = new System.Windows.Forms.Label();
            this.lbDimensaoB = new System.Windows.Forms.Label();
            this.lbDimensaoC = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDimensaoA = new System.Windows.Forms.TextBox();
            this.txtDimensaoB = new System.Windows.Forms.TextBox();
            this.txtDimensaoC = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDimensaoA
            // 
            this.lbDimensaoA.AutoSize = true;
            this.lbDimensaoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDimensaoA.Location = new System.Drawing.Point(144, 79);
            this.lbDimensaoA.Name = "lbDimensaoA";
            this.lbDimensaoA.Size = new System.Drawing.Size(96, 20);
            this.lbDimensaoA.TabIndex = 0;
            this.lbDimensaoA.Text = "Dimensão A";
            // 
            // lbDimensaoB
            // 
            this.lbDimensaoB.AutoSize = true;
            this.lbDimensaoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDimensaoB.Location = new System.Drawing.Point(144, 134);
            this.lbDimensaoB.Name = "lbDimensaoB";
            this.lbDimensaoB.Size = new System.Drawing.Size(96, 20);
            this.lbDimensaoB.TabIndex = 1;
            this.lbDimensaoB.Text = "Dimensão B";
            // 
            // lbDimensaoC
            // 
            this.lbDimensaoC.AutoSize = true;
            this.lbDimensaoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDimensaoC.Location = new System.Drawing.Point(144, 199);
            this.lbDimensaoC.Name = "lbDimensaoC";
            this.lbDimensaoC.Size = new System.Drawing.Size(96, 20);
            this.lbDimensaoC.TabIndex = 2;
            this.lbDimensaoC.Text = "Dimensão C";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(147, 351);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(101, 49);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(353, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 49);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(566, 351);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 49);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDimensaoA
            // 
            this.txtDimensaoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensaoA.Location = new System.Drawing.Point(336, 79);
            this.txtDimensaoA.Name = "txtDimensaoA";
            this.txtDimensaoA.Size = new System.Drawing.Size(207, 26);
            this.txtDimensaoA.TabIndex = 6;
            this.txtDimensaoA.Validated += new System.EventHandler(this.txtDimensaoA_Validated);
            // 
            // txtDimensaoB
            // 
            this.txtDimensaoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensaoB.Location = new System.Drawing.Point(336, 134);
            this.txtDimensaoB.Name = "txtDimensaoB";
            this.txtDimensaoB.Size = new System.Drawing.Size(207, 26);
            this.txtDimensaoB.TabIndex = 7;
            this.txtDimensaoB.Validated += new System.EventHandler(this.txtDimensaoB_Validated);
            // 
            // txtDimensaoC
            // 
            this.txtDimensaoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensaoC.Location = new System.Drawing.Point(336, 199);
            this.txtDimensaoC.Name = "txtDimensaoC";
            this.txtDimensaoC.Size = new System.Drawing.Size(207, 26);
            this.txtDimensaoC.TabIndex = 8;
            this.txtDimensaoC.Validated += new System.EventHandler(this.txtDimensaoC_Validated);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(336, 249);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(207, 26);
            this.txtCategoria.TabIndex = 9;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(144, 255);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(78, 20);
            this.lbCategoria.TabIndex = 10;
            this.lbCategoria.Text = "Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDimensaoC);
            this.Controls.Add(this.txtDimensaoB);
            this.Controls.Add(this.txtDimensaoA);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lbDimensaoC);
            this.Controls.Add(this.lbDimensaoB);
            this.Controls.Add(this.lbDimensaoA);
            this.Name = "Form1";
            this.Text = "Aplicação Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDimensaoA;
        private System.Windows.Forms.Label lbDimensaoB;
        private System.Windows.Forms.Label lbDimensaoC;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDimensaoA;
        private System.Windows.Forms.TextBox txtDimensaoB;
        private System.Windows.Forms.TextBox txtDimensaoC;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lbCategoria;
    }
}


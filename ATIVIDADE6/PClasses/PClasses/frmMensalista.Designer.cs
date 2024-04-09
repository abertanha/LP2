namespace PClasses
{
    partial class frmMensalista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnMensalistaParametros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(380, 68);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(275, 29);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(380, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 29);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMensal.Location = new System.Drawing.Point(380, 146);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(275, 29);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrada.Location = new System.Drawing.Point(380, 181);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(275, 29);
            this.txtDataEntrada.TabIndex = 7;
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(165, 295);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(130, 69);
            this.btnInstanciarMensalista.TabIndex = 8;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.btnInstanciarMensalista_Click);
            // 
            // btnMensalistaParametros
            // 
            this.btnMensalistaParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalistaParametros.Location = new System.Drawing.Point(380, 295);
            this.btnMensalistaParametros.Name = "btnMensalistaParametros";
            this.btnMensalistaParametros.Size = new System.Drawing.Size(200, 69);
            this.btnMensalistaParametros.TabIndex = 9;
            this.btnMensalistaParametros.Text = "Instanciar Mensalista com parâmetros";
            this.btnMensalistaParametros.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMensalistaParametros);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnMensalistaParametros;
    }
}
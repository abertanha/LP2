namespace PClasses
{
    partial class frmHorista
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
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalarioPHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiasdeFalta = new System.Windows.Forms.TextBox();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciarHorista.Location = new System.Drawing.Point(255, 355);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(300, 43);
            this.btnInstanciarHorista.TabIndex = 18;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.btnInstanciarHorista_Click);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrada.Location = new System.Drawing.Point(417, 190);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(275, 29);
            this.txtDataEntrada.TabIndex = 17;
            // 
            // txtSalarioPHora
            // 
            this.txtSalarioPHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioPHora.Location = new System.Drawing.Point(417, 155);
            this.txtSalarioPHora.Name = "txtSalarioPHora";
            this.txtSalarioPHora.Size = new System.Drawing.Size(275, 29);
            this.txtSalarioPHora.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(417, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 29);
            this.txtNome.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(417, 77);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(275, 29);
            this.txtMatricula.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salário Por Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matrícula";
            // 
            // txtDiasdeFalta
            // 
            this.txtDiasdeFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasdeFalta.Location = new System.Drawing.Point(417, 265);
            this.txtDiasdeFalta.Name = "txtDiasdeFalta";
            this.txtDiasdeFalta.Size = new System.Drawing.Size(275, 29);
            this.txtDiasdeFalta.TabIndex = 21;
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumHoras.Location = new System.Drawing.Point(417, 230);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(275, 29);
            this.txtNumHoras.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Número de Horas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dias de Faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiasdeFalta);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalarioPHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalarioPHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiasdeFalta;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
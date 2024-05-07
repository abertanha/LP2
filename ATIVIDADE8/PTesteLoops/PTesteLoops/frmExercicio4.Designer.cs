namespace PTesteLoops
{
    partial class frmExercicio4
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
            textProd = new TextBox();
            txtGrat = new TextBox();
            txtSalBrut = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalBrut = new Button();
            txtNome = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMat = new TextBox();
            txtSal = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textProd
            // 
            textProd.Font = new Font("Segoe UI", 14.25F);
            textProd.Location = new Point(257, 116);
            textProd.Name = "textProd";
            textProd.Size = new Size(178, 33);
            textProd.TabIndex = 0;
            textProd.TextChanged += textProd_TextChanged;
            // 
            // txtGrat
            // 
            txtGrat.Font = new Font("Segoe UI", 14.25F);
            txtGrat.Location = new Point(257, 190);
            txtGrat.Name = "txtGrat";
            txtGrat.Size = new Size(178, 33);
            txtGrat.TabIndex = 1;
            txtGrat.TextChanged += txtGrat_TextChanged;
            // 
            // txtSalBrut
            // 
            txtSalBrut.Font = new Font("Segoe UI", 14.25F);
            txtSalBrut.Location = new Point(257, 269);
            txtSalBrut.Name = "txtSalBrut";
            txtSalBrut.ReadOnly = true;
            txtSalBrut.Size = new Size(178, 33);
            txtSalBrut.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(131, 119);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 3;
            label1.Text = "Produção";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(131, 193);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 4;
            label2.Text = "Gratificação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(131, 272);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 5;
            label3.Text = "Salário Bruto";
            // 
            // btnSalBrut
            // 
            btnSalBrut.Font = new Font("Segoe UI", 14.25F);
            btnSalBrut.Location = new Point(257, 357);
            btnSalBrut.Name = "btnSalBrut";
            btnSalBrut.Size = new Size(178, 61);
            btnSalBrut.TabIndex = 6;
            btnSalBrut.Text = "Calcular Salario Bruto";
            btnSalBrut.UseVisualStyleBackColor = true;
            btnSalBrut.Click += btnSalBrut_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F);
            txtNome.Location = new Point(257, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(178, 33);
            txtNome.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(131, 58);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(457, 58);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 9;
            label5.Text = "Matricula";
            label5.Click += label5_Click;
            // 
            // txtMat
            // 
            txtMat.Font = new Font("Segoe UI", 14.25F);
            txtMat.Location = new Point(562, 55);
            txtMat.Name = "txtMat";
            txtMat.Size = new Size(215, 33);
            txtMat.TabIndex = 10;
            // 
            // txtSal
            // 
            txtSal.Font = new Font("Segoe UI", 14.25F);
            txtSal.Location = new Point(562, 119);
            txtSal.Name = "txtSal";
            txtSal.Size = new Size(215, 33);
            txtSal.TabIndex = 11;
            txtSal.TextChanged += txtSal_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(457, 124);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 12;
            label6.Text = "Salário";
            // 
            // frmExercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtSal);
            Controls.Add(txtMat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(btnSalBrut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalBrut);
            Controls.Add(txtGrat);
            Controls.Add(textProd);
            Name = "frmExercicio4";
            Text = "frmExercicio4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textProd;
        private TextBox txtGrat;
        private TextBox txtSalBrut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalBrut;
        private TextBox txtNome;
        private Label label4;
        private Label label5;
        private TextBox txtMat;
        private TextBox txtSal;
        private Label label6;
    }
}
namespace PTesteLoops
{
    partial class frmExercicio2
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
            txtNumN = new TextBox();
            btnGerar = new Button();
            txtNumH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNumN
            // 
            txtNumN.Font = new Font("Segoe UI", 14.25F);
            txtNumN.Location = new Point(279, 59);
            txtNumN.Name = "txtNumN";
            txtNumN.Size = new Size(249, 33);
            txtNumN.TabIndex = 0;
            txtNumN.Validated += txtNumN_Validated;
            // 
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI", 14.25F);
            btnGerar.Location = new Point(329, 176);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(147, 56);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "Gerar Número";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // txtNumH
            // 
            txtNumH.Font = new Font("Segoe UI", 14.25F);
            txtNumH.Location = new Point(279, 303);
            txtNumH.Name = "txtNumH";
            txtNumH.Size = new Size(249, 33);
            txtNumH.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(151, 59);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "Número N";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(151, 311);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 4;
            label2.Text = "Numero H";
            // 
            // frmExercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumH);
            Controls.Add(btnGerar);
            Controls.Add(txtNumN);
            Name = "frmExercicio2";
            Text = "frmExercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumN;
        private Button btnGerar;
        private TextBox txtNumH;
        private Label label1;
        private Label label2;
    }
}
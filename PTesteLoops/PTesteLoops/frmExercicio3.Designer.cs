namespace PTesteLoops
{
    partial class frmExercicio3
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
            txtPalavra = new TextBox();
            btnPalin = new Button();
            SuspendLayout();
            // 
            // txtPalavra
            // 
            txtPalavra.Font = new Font("Segoe UI", 14.25F);
            txtPalavra.Location = new Point(300, 192);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(425, 33);
            txtPalavra.TabIndex = 0;
            txtPalavra.TextChanged += txtPalavra_TextChanged;
            // 
            // btnPalin
            // 
            btnPalin.Font = new Font("Segoe UI", 14.25F);
            btnPalin.Location = new Point(59, 187);
            btnPalin.Name = "btnPalin";
            btnPalin.Size = new Size(156, 41);
            btnPalin.TabIndex = 1;
            btnPalin.Text = "é palíndromo?";
            btnPalin.UseVisualStyleBackColor = true;
            btnPalin.Click += button1_Click;
            // 
            // frmExercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPalin);
            Controls.Add(txtPalavra);
            Name = "frmExercicio3";
            Text = "frmExercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalavra;
        private Button btnPalin;
    }
}
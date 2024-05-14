namespace ATIVIDADE9
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
            this.btnExec = new System.Windows.Forms.Button();
            this.lstbResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec.Location = new System.Drawing.Point(102, 197);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(144, 58);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // lstbResultado
            // 
            this.lstbResultado.FormattingEnabled = true;
            this.lstbResultado.Location = new System.Drawing.Point(387, 61);
            this.lstbResultado.Name = "lstbResultado";
            this.lstbResultado.Size = new System.Drawing.Size(376, 368);
            this.lstbResultado.TabIndex = 1;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbResultado);
            this.Controls.Add(this.btnExec);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ListBox lstbResultado;
    }
}
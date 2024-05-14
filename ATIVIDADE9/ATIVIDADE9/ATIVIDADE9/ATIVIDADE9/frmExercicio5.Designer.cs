namespace ATIVIDADE9
{
    partial class frmExercicio5
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
            this.listBoxGabarito = new System.Windows.Forms.ListBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGabarito
            // 
            this.listBoxGabarito.FormattingEnabled = true;
            this.listBoxGabarito.Location = new System.Drawing.Point(271, 78);
            this.listBoxGabarito.Name = "listBoxGabarito";
            this.listBoxGabarito.Size = new System.Drawing.Size(438, 264);
            this.listBoxGabarito.TabIndex = 0;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(67, 181);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(148, 69);
            this.btnComparar.TabIndex = 1;
            this.btnComparar.Text = "Comparar com o Gabarito";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.listBoxGabarito);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGabarito;
        private System.Windows.Forms.Button btnComparar;
    }
}
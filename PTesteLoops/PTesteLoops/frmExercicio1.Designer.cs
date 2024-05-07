namespace PTesteLoops
{
    partial class frmExercicio1
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
            rchtxtFrase = new RichTextBox();
            btnFor = new Button();
            btnWhile = new Button();
            btnForeach = new Button();
            SuspendLayout();
            // 
            // rchtxtFrase
            // 
            rchtxtFrase.Font = new Font("Segoe UI", 14.25F);
            rchtxtFrase.Location = new Point(277, 93);
            rchtxtFrase.Name = "rchtxtFrase";
            rchtxtFrase.Size = new Size(403, 219);
            rchtxtFrase.TabIndex = 0;
            rchtxtFrase.Text = "";
            // 
            // btnFor
            // 
            btnFor.Font = new Font("Segoe UI", 14.25F);
            btnFor.Location = new Point(96, 93);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(157, 58);
            btnFor.TabIndex = 1;
            btnFor.Text = "Usando FOR";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Font = new Font("Segoe UI", 14.25F);
            btnWhile.Location = new Point(96, 177);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(157, 58);
            btnWhile.TabIndex = 2;
            btnWhile.Text = "Usando WHILE";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnForeach
            // 
            btnForeach.Font = new Font("Segoe UI", 14.25F);
            btnForeach.Location = new Point(96, 254);
            btnForeach.Name = "btnForeach";
            btnForeach.Size = new Size(157, 58);
            btnForeach.TabIndex = 3;
            btnForeach.Text = "Usando DO-WHILE";
            btnForeach.UseVisualStyleBackColor = true;
            btnForeach.Click += btnForeach_Click;
            // 
            // frmExercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForeach);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(rchtxtFrase);
            Name = "frmExercicio1";
            Text = "frmExercicio1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rchtxtFrase;
        private Button btnFor;
        private Button btnWhile;
        private Button btnForeach;
    }
}
namespace PDisastre030482321026
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.outrosCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTiposDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outrosCadastrosToolStripMenuItem,
            this.cadastroEventosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // outrosCadastrosToolStripMenuItem
            // 
            this.outrosCadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCidadesToolStripMenuItem,
            this.cadastroTiposDeEventosToolStripMenuItem});
            this.outrosCadastrosToolStripMenuItem.Name = "outrosCadastrosToolStripMenuItem";
            this.outrosCadastrosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.outrosCadastrosToolStripMenuItem.Text = "Outros Cadastros";
            // 
            // cadastroCidadesToolStripMenuItem
            // 
            this.cadastroCidadesToolStripMenuItem.Name = "cadastroCidadesToolStripMenuItem";
            this.cadastroCidadesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cadastroCidadesToolStripMenuItem.Text = "Cadastro Cidades";
            this.cadastroCidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastroCidadesToolStripMenuItem_Click);
            // 
            // cadastroTiposDeEventosToolStripMenuItem
            // 
            this.cadastroTiposDeEventosToolStripMenuItem.Name = "cadastroTiposDeEventosToolStripMenuItem";
            this.cadastroTiposDeEventosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cadastroTiposDeEventosToolStripMenuItem.Text = "Cadastro Tipos de Eventos";
            this.cadastroTiposDeEventosToolStripMenuItem.Click += new System.EventHandler(this.cadastroTiposDeEventosToolStripMenuItem_Click);
            // 
            // cadastroEventosToolStripMenuItem
            // 
            this.cadastroEventosToolStripMenuItem.Name = "cadastroEventosToolStripMenuItem";
            this.cadastroEventosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.cadastroEventosToolStripMenuItem.Text = "Cadastro Eventos";
            this.cadastroEventosToolStripMenuItem.Click += new System.EventHandler(this.cadastroEventosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem outrosCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTiposDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}


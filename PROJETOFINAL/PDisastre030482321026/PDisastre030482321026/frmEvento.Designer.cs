namespace PDisastre030482321026
{
    partial class frmEvento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.label2 = new System.Windows.Forms.Label();
            this.mskPopAfetada = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSeveridade = new System.Windows.Forms.ComboBox();
            this.bnvEvento = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.dtpDataOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskAreaAfetada = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.lblIdCidade = new System.Windows.Forms.Label();
            this.tbEvento = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bnvEvento)).BeginInit();
            this.bnvEvento.SuspendLayout();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            this.tbEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // mskPopAfetada
            // 
            this.mskPopAfetada.Enabled = false;
            this.mskPopAfetada.Location = new System.Drawing.Point(236, 252);
            this.mskPopAfetada.Mask = "99999999";
            this.mskPopAfetada.Name = "mskPopAfetada";
            this.mskPopAfetada.Size = new System.Drawing.Size(121, 26);
            this.mskPopAfetada.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Severidade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxSeveridade
            // 
            this.cbxSeveridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeveridade.Enabled = false;
            this.cbxSeveridade.FormattingEnabled = true;
            this.cbxSeveridade.Items.AddRange(new object[] {
            "L",
            "M",
            "G"});
            this.cbxSeveridade.Location = new System.Drawing.Point(236, 155);
            this.cbxSeveridade.Name = "cbxSeveridade";
            this.cbxSeveridade.Size = new System.Drawing.Size(121, 28);
            this.cbxSeveridade.TabIndex = 4;
            // 
            // bnvEvento
            // 
            this.bnvEvento.AddNewItem = null;
            this.bnvEvento.CountItem = this.bindingNavigatorCountItem;
            this.bnvEvento.DeleteItem = null;
            this.bnvEvento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnAlterar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnFechar});
            this.bnvEvento.Location = new System.Drawing.Point(0, 0);
            this.bnvEvento.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvEvento.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvEvento.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvEvento.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvEvento.Name = "bnvEvento";
            this.bnvEvento.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvEvento.Size = new System.Drawing.Size(800, 25);
            this.bnvEvento.TabIndex = 4;
            this.bnvEvento.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 22);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.dgvEvento);
            this.tbDados.Location = new System.Drawing.Point(4, 29);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(611, 335);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // dgvEvento
            // 
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Enabled = false;
            this.dgvEvento.Location = new System.Drawing.Point(3, 3);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.ReadOnly = true;
            this.dgvEvento.Size = new System.Drawing.Size(605, 329);
            this.dgvEvento.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 252);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(215, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Pop. Afetada [nº de pessoas]";
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.Controls.Add(this.dtpDataOcorrencia);
            this.tbDetalhes.Controls.Add(this.label6);
            this.tbDetalhes.Controls.Add(this.txtObservacao);
            this.tbDetalhes.Controls.Add(this.label5);
            this.tbDetalhes.Controls.Add(this.mskAreaAfetada);
            this.tbDetalhes.Controls.Add(this.label4);
            this.tbDetalhes.Controls.Add(this.cbxCidade);
            this.tbDetalhes.Controls.Add(this.label3);
            this.tbDetalhes.Controls.Add(this.cbxTipo);
            this.tbDetalhes.Controls.Add(this.label2);
            this.tbDetalhes.Controls.Add(this.mskPopAfetada);
            this.tbDetalhes.Controls.Add(this.label1);
            this.tbDetalhes.Controls.Add(this.cbxSeveridade);
            this.tbDetalhes.Controls.Add(this.txtIdEvento);
            this.tbDetalhes.Controls.Add(this.lblDescricao);
            this.tbDetalhes.Controls.Add(this.lblIdCidade);
            this.tbDetalhes.Location = new System.Drawing.Point(4, 29);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetalhes.Size = new System.Drawing.Size(611, 335);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            // 
            // dtpDataOcorrencia
            // 
            this.dtpDataOcorrencia.CustomFormat = "dd/MM/yyyy";
            this.dtpDataOcorrencia.Enabled = false;
            this.dtpDataOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOcorrencia.Location = new System.Drawing.Point(425, 63);
            this.dtpDataOcorrencia.Name = "dtpDataOcorrencia";
            this.dtpDataOcorrencia.Size = new System.Drawing.Size(117, 26);
            this.dtpDataOcorrencia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data Ocorrência";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(236, 300);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(185, 26);
            this.txtObservacao.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Observação";
            // 
            // mskAreaAfetada
            // 
            this.mskAreaAfetada.Enabled = false;
            this.mskAreaAfetada.Location = new System.Drawing.Point(236, 206);
            this.mskAreaAfetada.Mask = "9999";
            this.mskAreaAfetada.Name = "mskAreaAfetada";
            this.mskAreaAfetada.Size = new System.Drawing.Size(121, 26);
            this.mskAreaAfetada.TabIndex = 13;
            this.mskAreaAfetada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Area Afetada [Km²]";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxCidade.Location = new System.Drawing.Point(236, 109);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(121, 28);
            this.cbxCidade.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cidade";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.Enabled = false;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxTipo.Location = new System.Drawing.Point(236, 63);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 28);
            this.cbxTipo.TabIndex = 9;
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Enabled = false;
            this.txtIdEvento.Location = new System.Drawing.Point(257, 16);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(100, 26);
            this.txtIdEvento.TabIndex = 2;
            // 
            // lblIdCidade
            // 
            this.lblIdCidade.AutoSize = true;
            this.lblIdCidade.Location = new System.Drawing.Point(6, 16);
            this.lblIdCidade.Name = "lblIdCidade";
            this.lblIdCidade.Size = new System.Drawing.Size(26, 20);
            this.lblIdCidade.TabIndex = 0;
            this.lblIdCidade.Text = "ID";
            // 
            // tbEvento
            // 
            this.tbEvento.Controls.Add(this.tbDados);
            this.tbEvento.Controls.Add(this.tbDetalhes);
            this.tbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvento.Location = new System.Drawing.Point(91, 28);
            this.tbEvento.Name = "tbEvento";
            this.tbEvento.SelectedIndex = 0;
            this.tbEvento.Size = new System.Drawing.Size(619, 368);
            this.tbEvento.TabIndex = 5;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnvEvento);
            this.Controls.Add(this.tbEvento);
            this.Name = "frmEvento";
            this.Text = "frmEvento";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvEvento)).EndInit();
            this.bnvEvento.ResumeLayout(false);
            this.bnvEvento.PerformLayout();
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            this.tbEvento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPopAfetada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSeveridade;
        private System.Windows.Forms.BindingNavigator bnvEvento;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.Label lblIdCidade;
        private System.Windows.Forms.TabControl tbEvento;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.MaskedTextBox mskAreaAfetada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataOcorrencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label5;
    }
}
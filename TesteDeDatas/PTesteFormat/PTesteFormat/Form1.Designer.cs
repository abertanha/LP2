namespace PTesteFormat
{
    partial class Form1
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
            this.btnToString = new System.Windows.Forms.Button();
            this.btnMetDT = new System.Windows.Forms.Button();
            this.btnStrFrmt = new System.Windows.Forms.Button();
            this.btnFrmtValtS = new System.Windows.Forms.Button();
            this.btnFrmtValStrFmrt = new System.Windows.Forms.Button();
            this.btnOpDatas = new System.Windows.Forms.Button();
            this.btnDatasCalend = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnToString
            // 
            this.btnToString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToString.Location = new System.Drawing.Point(75, 68);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(145, 61);
            this.btnToString.TabIndex = 0;
            this.btnToString.Text = "To String";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // btnMetDT
            // 
            this.btnMetDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetDT.Location = new System.Drawing.Point(325, 68);
            this.btnMetDT.Name = "btnMetDT";
            this.btnMetDT.Size = new System.Drawing.Size(145, 61);
            this.btnMetDT.TabIndex = 1;
            this.btnMetDT.Text = "Métodos DateTime";
            this.btnMetDT.UseVisualStyleBackColor = true;
            this.btnMetDT.Click += new System.EventHandler(this.btnMetDT_Click);
            // 
            // btnStrFrmt
            // 
            this.btnStrFrmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrFrmt.Location = new System.Drawing.Point(573, 68);
            this.btnStrFrmt.Name = "btnStrFrmt";
            this.btnStrFrmt.Size = new System.Drawing.Size(145, 61);
            this.btnStrFrmt.TabIndex = 2;
            this.btnStrFrmt.Text = "String.Format";
            this.btnStrFrmt.UseVisualStyleBackColor = true;
            this.btnStrFrmt.Click += new System.EventHandler(this.btnStrFrmt_Click);
            // 
            // btnFrmtValtS
            // 
            this.btnFrmtValtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmtValtS.Location = new System.Drawing.Point(75, 350);
            this.btnFrmtValtS.Name = "btnFrmtValtS";
            this.btnFrmtValtS.Size = new System.Drawing.Size(145, 82);
            this.btnFrmtValtS.TabIndex = 3;
            this.btnFrmtValtS.Text = "Formatação Valores - ToString";
            this.btnFrmtValtS.UseVisualStyleBackColor = true;
            this.btnFrmtValtS.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFrmtValStrFmrt
            // 
            this.btnFrmtValStrFmrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmtValStrFmrt.Location = new System.Drawing.Point(236, 350);
            this.btnFrmtValStrFmrt.Name = "btnFrmtValStrFmrt";
            this.btnFrmtValStrFmrt.Size = new System.Drawing.Size(145, 82);
            this.btnFrmtValStrFmrt.TabIndex = 4;
            this.btnFrmtValStrFmrt.Text = "Formatação Valores - String.Format";
            this.btnFrmtValStrFmrt.UseVisualStyleBackColor = true;
            this.btnFrmtValStrFmrt.Click += new System.EventHandler(this.btnFrmtValStrFmrt_Click);
            // 
            // btnOpDatas
            // 
            this.btnOpDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpDatas.Location = new System.Drawing.Point(405, 371);
            this.btnOpDatas.Name = "btnOpDatas";
            this.btnOpDatas.Size = new System.Drawing.Size(145, 61);
            this.btnOpDatas.TabIndex = 5;
            this.btnOpDatas.Text = "Operações com Datas";
            this.btnOpDatas.UseVisualStyleBackColor = true;
            this.btnOpDatas.Click += new System.EventHandler(this.btnOpDatas_Click);
            // 
            // btnDatasCalend
            // 
            this.btnDatasCalend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatasCalend.Location = new System.Drawing.Point(573, 371);
            this.btnDatasCalend.Name = "btnDatasCalend";
            this.btnDatasCalend.Size = new System.Drawing.Size(145, 61);
            this.btnDatasCalend.TabIndex = 6;
            this.btnDatasCalend.Text = "Datas Calendário";
            this.btnDatasCalend.UseVisualStyleBackColor = true;
            this.btnDatasCalend.Click += new System.EventHandler(this.btnDatasCalend_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(75, 161);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnDatasCalend);
            this.Controls.Add(this.btnOpDatas);
            this.Controls.Add(this.btnFrmtValStrFmrt);
            this.Controls.Add(this.btnFrmtValtS);
            this.Controls.Add(this.btnStrFrmt);
            this.Controls.Add(this.btnMetDT);
            this.Controls.Add(this.btnToString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Button btnMetDT;
        private System.Windows.Forms.Button btnStrFrmt;
        private System.Windows.Forms.Button btnFrmtValtS;
        private System.Windows.Forms.Button btnFrmtValStrFmrt;
        private System.Windows.Forms.Button btnOpDatas;
        private System.Windows.Forms.Button btnDatasCalend;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


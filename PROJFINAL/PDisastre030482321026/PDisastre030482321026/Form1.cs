﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDisastre030482321026
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=apolo;Initial Catalog=LP2;User ID=BD2321026;Encrypt=False;Password=cr1571@n0\r\n");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =(" + ex.Message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Outros Erros =(" + ex.Message);
            }
        }

        private void cadastroTiposDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTipo>().Count() > 0)
            {
                Application.OpenForms["frmTipo"].BringToFront();
            }
            else
            {
                frmTipo objFrm2 = new frmTipo();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Minimized;
                objFrm2.Show();
            }
        }
    }
}
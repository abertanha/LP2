using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDisastre030482321026
{
    public partial class frmTipo : Form
    {
        private BindingSource bnTipo = new BindingSource();
        private bool bInclusao = false; 
        private DataSet dsTipo = new DataSet();

        public frmTipo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmTipo_Load(object sender, EventArgs e)
                
        {
            try
            {
                Tipo Tip = new Tipo();
                dsTipo.Tables.Add(Tip.Listar());
                bnTipo.DataSource = dsTipo.Tables["Tipo"];
                dgvTipo.DataSource = bnTipo;
                bnvTipo.BindingSource = bnTipo;

                txtIdTipo.DataBindings.Add("TEXT", bnTipo, "idTipo");
                txtDescricao.DataBindings.Add("TEXT", bnTipo, "descricao");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbTipo.SelectedIndex == 0)
            {
                tbTipo.SelectTab(1);
            }
            bnTipo.AddNew();

            txtDescricao.Enabled = true;
            txtDescricao.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbTipo.SelectedIndex == 0)
            {
                tbTipo.SelectTab(1);
            }
            

            txtDescricao.Enabled = true;
            txtDescricao.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição inválida!");
            }
            else 
            {
                Tipo RegTip = new Tipo();

                RegTip.descricao = txtDescricao.Text;

                if (bInclusao)
                {
                    if (RegTip.Incluir() > 0)
                    {
                        MessageBox.Show("Tipo adicionado com sucesso!");

                        txtDescricao.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;
                        //recarregar o grid
                        dsTipo.Tables.Clear();
                        dsTipo.Tables.Add(RegTip.Listar());
                        bnTipo.DataSource = dsTipo.Tables["Tipo"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar tipo!");
                    }
                }
                else //alteração
                {
                    RegTip.idTipo = Convert.ToInt32(txtIdTipo.Text);

                    if (RegTip.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo alterado com sucesso!");

                        dsTipo.Tables.Clear();
                        dsTipo.Tables.Add(RegTip.Listar());
                        bnTipo.DataSource = dsTipo.Tables["Tipo"];

                        txtDescricao.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else 
                    {
                        MessageBox.Show("Erro ao gravar o tipo!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(tbTipo.SelectedIndex == 0)
            {
                tbTipo.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?","Sim ou não",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Tipo RegTip = new Tipo();

                RegTip.idTipo = Convert.ToInt16(txtIdTipo.Text);

                if(RegTip.Excluir () > 0) 
                {
                    MessageBox.Show("Tipo excluído com sucesso!");

                    Tipo R = new Tipo();
                    dsTipo.Tables.Clear();
                    dsTipo.Tables.Add(R.Listar());
                    bnTipo.DataSource = dsTipo.Tables["Tipo"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir tipo!");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnTipo.CancelEdit();

            txtDescricao.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

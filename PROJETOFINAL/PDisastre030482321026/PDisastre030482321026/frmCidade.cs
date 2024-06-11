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
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {

            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["Cidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtIdCidade.DataBindings.Add("TEXT", bnCidade, "idCidade");
                txtNome.DataBindings.Add("TEXT", bnCidade, "nome");
                cbxUF.DataBindings.Add("SelectedItem", bnCidade, "uf");
                mskbxPopulacao.DataBindings.Add("TEXT", bnCidade, "populacao");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();

            txtNome.Enabled = true;
            cbxUF.Enabled = true;
            cbxUF.SelectedIndex = 0;
            mskbxPopulacao.Enabled = true;

            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }


            txtNome.Enabled = true;
            cbxUF.Enabled = true;
            mskbxPopulacao.Enabled = true;

            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int aux;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome inválido!");
            }
            else if (!int.TryParse(mskbxPopulacao.Text, out aux) || aux <= 0)
            {
                MessageBox.Show("População inválida!");
            }
            else
            {
                Cidade RegCid = new Cidade();

                RegCid.nome = txtNome.Text;
                RegCid.uf = cbxUF.SelectedItem.ToString();
                RegCid.populacao = Convert.ToInt32(mskbxPopulacao.Text);

                if (bInclusao)
                {
                    if (RegCid.Incluir() > 0)
                    {
                        MessageBox.Show("Cidade adicionado com sucesso!");

                        txtIdCidade.Enabled = false;
                        txtNome.Enabled = false;
                        cbxUF.Enabled = false;
                        mskbxPopulacao.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        //recarregar o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Cidade!");
                    }
                }
                else //alteração
                {
                    RegCid.idCidade = Convert.ToInt32(txtIdCidade.Text);

                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterado com sucesso!");

                        txtIdCidade.Enabled = false;
                        txtNome.Enabled = false;
                        cbxUF.Enabled = false;
                        mskbxPopulacao.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        //recarregar o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o cidade!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Sim ou não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();

                RegCid.idCidade = Convert.ToInt16(txtIdCidade.Text);

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");

                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["Cidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            txtIdCidade.Enabled = false;
            txtNome.Enabled = false;
            cbxUF.Enabled = false;
            mskbxPopulacao.Enabled = false;

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
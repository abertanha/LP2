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
    public partial class frmEvento : Form
    {
        private BindingSource bnEvento = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsEvento = new DataSet();
        private DataSet dsCidade = new DataSet();
        private DataSet dsTipo = new DataSet();

        public frmEvento()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }
            bnEvento.AddNew();

            cbxCidade.Enabled = true;
            cbxTipo.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;
            cbxSeveridade.Enabled = true;
            cbxSeveridade.SelectedIndex = 0;
            mskAreaAfetada.Enabled = true;
            mskPopAfetada.Enabled = true;
            txtObservacao.Enabled = true;
            dtpDataOcorrencia.Enabled = true;

            cbxTipo.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }


            txtNome.Enabled = true;
            cbxSeveridade.Enabled = true;
            mskPopAfetada.Enabled = true;

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
            else if (!int.TryParse(mskPopAfetada.Text, out aux) || aux <= 0)
            {
                MessageBox.Show("População inválida!");
            }
            else
            {
                Evento RegEve = new Evento();

                RegEve.nome = txtNome.Text;
                RegEve.uf = cbxSeveridade.SelectedItem.ToString();
                RegEve.populacao = Convert.ToInt32(mskPopAfetada.Text);

                if (bInclusao)
                {
                    if (RegEve.Incluir() > 0)
                    {
                        MessageBox.Show("Evento adicionado com sucesso!");

                        txtIdEvento.Enabled = false;
                        txtNome.Enabled = false;
                        cbxSeveridade.Enabled = false;
                        mskPopAfetada.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        //recarregar o grid
                        dsEvento.Tables.Clear();
                        dsEvento.Tables.Add(RegEve.Listar());
                        bnEvento.DataSource = dsEvento.Tables["Evento"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Evento!");
                    }
                }
                else //alteração
                {
                    RegEve.idEvento = Convert.ToInt32(txtIdEvento.Text);

                    if (RegEve.Alterar() > 0)
                    {
                        MessageBox.Show("Evento alterado com sucesso!");

                        txtIdEvento.Enabled = false;
                        txtNome.Enabled = false;
                        cbxSeveridade.Enabled = false;
                        mskPopAfetada.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        //recarregar o grid
                        dsEvento.Tables.Clear();
                        dsEvento.Tables.Add(RegEve.Listar());
                        bnEvento.DataSource = dsEvento.Tables["Evento"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o Evento!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Sim ou não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Evento RegEve = new Evento();

                RegEve.idEvento = Convert.ToInt16(txtIdEvento.Text);

                if (RegEve.Excluir() > 0)
                {
                    MessageBox.Show("Evento excluída com sucesso!");

                    Evento R = new Evento();
                    dsEvento.Tables.Clear();
                    dsEvento.Tables.Add(R.Listar());
                    bnEvento.DataSource = dsEvento.Tables["Evento"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Evento!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnEvento.CancelEdit();

            txtIdEvento.Enabled = false;
            txtNome.Enabled = false;
            cbxSeveridade.Enabled = false;
            mskPopAfetada.Enabled = false;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            try
            {
                Evento Eve = new Evento();
                dsEvento.Tables.Add(Eve.Listar());
                bnEvento.DataSource = dsEvento.Tables["Evento"];
                dgvEvento.DataSource = bnEvento;
                bnvEvento.BindingSource = bnEvento;

                txtIdEvento.DataBindings.Add("TEXT", bnEvento, "idEvento");
                cbxSeveridade.DataBindings.Add("SelectedItem", bnEvento, "nivelseveridade");
                mskAreaAfetada.DataBindings.Add("TEXT", bnEvento, "areaafetada");
                mskPopAfetada.DataBindings.Add("TEXT", bnEvento, "pessoasafetadas");
                txtObservacao.DataBindings.Add("TEXT", bnEvento, "observacao");
                dtpDataOcorrencia.DataBindings.Add("TEXT", bnEvento, "dataocorrencia");

                // ligando com Cidade
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];
                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "idcidade";
                cbxCidade.DataBindings.Add("SelectedValue", bnEvento, "cidade_idcidade");

                // ligando com Tipo
                Tipo Tip = new Tipo();
                dsTipo.Tables.Add(Tip.Listar());
                cbxTipo.DataSource = dsTipo.Tables["Tipo"];
                cbxTipo.DisplayMember = "descricao";
                cbxTipo.ValueMember = "idtipo";
                cbxTipo.DataBindings.Add("SelectedValue", bnEvento, "tipo_idtipo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

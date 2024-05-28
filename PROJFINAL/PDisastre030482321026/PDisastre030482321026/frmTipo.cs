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
    }
}

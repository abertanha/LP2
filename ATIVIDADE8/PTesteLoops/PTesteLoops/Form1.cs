namespace PTesteLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"]?.BringToFront();
            }
            else
            {
                frmExercicio1 objFrm1 = new frmExercicio1();
                objFrm1.MdiParent = this;
                objFrm1.WindowState = FormWindowState.Maximized;
                objFrm1.Show();
            }
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"]?.BringToFront();
            }
            else
            {
                frmExercicio2 objFrm2 = new frmExercicio2();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }

        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"]?.BringToFront();
            }
            else
            {
                frmExercicio3 objFrm3 = new frmExercicio3();
                objFrm3.MdiParent = this;
                objFrm3.WindowState = FormWindowState.Maximized;
                objFrm3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"]?.BringToFront();
            }
            else
            {
                frmExercicio4 objFrm4 = new frmExercicio4();
                objFrm4.MdiParent = this;
                objFrm4.WindowState = FormWindowState.Maximized;
                objFrm4.Show();
            }
        }
    }
}

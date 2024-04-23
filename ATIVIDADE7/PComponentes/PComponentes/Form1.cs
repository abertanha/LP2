using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="") //if(textBox1.Text==String.Empty)
                MessageBox.Show("Por Favor preencha seu nome!");
            else
                MessageBox.Show("O nome do aluno é: "+textBox1.Text);
            //if (checkBox1.Checked)
            //    MessageBox.Show("Aluno de transferência");
            //else
            //    MessageBox.Show("Aluno não transferido");
            if(checkBox1.CheckState==CheckState.Checked)
                MessageBox.Show("Aluno de transferência");
            else if(checkBox1.CheckState==CheckState.Unchecked)
                MessageBox.Show("Aluno não transferido");
            else
                MessageBox.Show("Indeterminado");
            if (comboBox1.TabIndex == -1)
                MessageBox.Show("Curso não escolhido");
            else
                MessageBox.Show("Curso escolhido: " + comboBox1.SelectedItem);
            MessageBox.Show("Semestre Escolhido: " + listBox1.SelectedItem);

            if(radioButton1.Checked)
                MessageBox.Show("Turno Matutino");
            else if (radioButton2.Checked)
                MessageBox.Show("Turno Vespertino");
            else
                MessageBox.Show("Turno Noturno");

            /*for(int i = 0;i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }*/
            string stringona = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                stringona += "\n" + checkedListBox1.CheckedItems[i].ToString();
            }
            MessageBox.Show("Disciplinas selecionados:\n" + stringona);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1o Semestre");
            listBox1.Items.Add("2o Semestre");
            listBox1.Items.Add("3o Semestre");
            listBox1.Items.Add("4o Semestre");
            listBox1.Items.Add("5o Semestre");
            listBox1.Items.Add("6o Semestre");
            listBox1.SelectedIndex = 0;

        }
    }
}

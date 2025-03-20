using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;
using CapaDeEntidade;

namespace GerenciamentoEscolar
{
    public partial class FrmAluno: Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastrar f = new FrmCadastrar();
            f.ShowDialog();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            dataGridViewA.DataSource = clsNegocio.N_ListarAlunos();
            comboBoxC.DataSource = clsNegocio.N_ListarCursos();
            comboBoxC.DisplayMember = "curso";
            comboBoxC.ValueMember = "nome_curso";

            comboBoxTur.DataSource = clsNegocio.N_ListarTurmas();
            comboBoxTur.DisplayMember = "turma";
            comboBoxTur.ValueMember = "nome_turma";
        }

        void Limpar()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxTel.Text = "";
            textBoxM.Text = "";
            comboBoxC.Text = "";
            comboBoxTur.Text = "";
        }

        private void dataGridViewA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewA.CurrentCell.RowIndex;
            textBoxNome.Text = dataGridViewA[1, fila].Value.ToString();
            textBoxTel.Text = dataGridViewA[2, fila].Value.ToString();
            textBoxEmail.Text = dataGridViewA[3, fila].Value.ToString();
            textBoxM.Text = dataGridViewA[4, fila].Value.ToString();
            comboBoxTur.Text = dataGridViewA[5, fila].Value.ToString();
            comboBoxC.Text = dataGridViewA[6, fila].Value.ToString();
            
            clsEntidade.Id = dataGridViewA[0, fila].Value.ToString();
        }

        void CRUD(String action)
        {
            clsEntidade.Aluno = textBoxNome.Text;
            clsEntidade.Email = textBoxEmail.Text;
            clsEntidade.Tel = textBoxTel.Text;
            clsEntidade.Matricula = textBoxM.Text;
            clsEntidade.Turma = comboBoxTur.Text;
            clsEntidade.Curso = comboBoxC.Text;
            clsEntidade.Action = action;
            if (action == "1")
            {
                clsEntidade.Id = "";
            }
            MessageBox.Show(clsNegocio.N_CrudAluno(clsEntidade));
            dataGridViewA.DataSource = clsNegocio.N_ListarAlunos();
            Limpar();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxEmail.Text == "" || 
                textBoxTel.Text == "" || textBoxM.Text == "" || 
                comboBoxC.Text == "" || comboBoxTur.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Mensagem Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Deseja cadastrar este Aluno?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

            {
                CRUD("1");
                dataGridViewA.DataSource = clsNegocio.N_ListarAlunos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar este Aluno?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

            {
                CRUD("2");
                dataGridViewA.DataSource = clsNegocio.N_ListarAlunos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este Aluno?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

            {
                CRUD("3");
                dataGridViewA.DataSource = clsNegocio.N_ListarAlunos();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void tbxSearchA_TextChanged(object sender, EventArgs e)
        {
            ClasseEntidade clsEntidade = new ClasseEntidade();
            clsEntidade.Aluno = tbxSearchA.Text + "%";

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarAluno(clsEntidade);

            dataGridViewA.DataSource = dt;
        }
    }
}

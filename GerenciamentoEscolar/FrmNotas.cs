using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace GerenciamentoEscolar
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal f = new FrmPrincipal();
            f.Show();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            cboCurso.DataSource = clsNegocio.N_ListarCursos();
            cboCurso.DisplayMember = "Curso";
            cboCurso.ValueMember = "nome_curso";

            cboTurma.DataSource = clsNegocio.N_ListarTurmas();
            cboTurma.DisplayMember = "Turma";
            cboTurma.ValueMember = "nome_turma";

            cboAtv.DataSource = clsNegocio.N_ListarAtividades();
            cboAtv.DisplayMember = "Atividade";
            cboAtv.ValueMember = "nome_atividade";

            cboDisciplina.DataSource = clsNegocio.N_ListarDisciplinas();
            cboDisciplina.DisplayMember = "Disciplina";
            cboDisciplina.ValueMember = "nome_disciplina";

            dgvAlunos.DataSource = clsNegocio.N_ListarAlunos();
            dgvAlunos.Columns[0].Visible = false;
            dgvAlunos.Columns[2].Visible = false;
            dgvAlunos.Columns[3].Visible = false;
            dgvAlunos.Columns[5].Visible = false;
            dgvAlunos.Columns[6].Visible = false;

            dgvNotas.DataSource = clsNegocio.N_ListarNotas();
        }

        void Limpar()
        {
            txtNome.Text = "";
            txtNota.Text = "";
            cboCurso.SelectedItem = null;
            cboTurma.SelectedItem = null;
            cboDisciplina.SelectedItem = null;
            cboTurma.SelectedItem = null;
            cboAtv.SelectedItem = null;
        }

        void CRUD(String action)
        {   clsEntidade.Aluno = txtNome.Text;
            clsEntidade.Curso = cboCurso.Text;
            clsEntidade.Turma = cboTurma.Text;
            clsEntidade.Disciplina = cboDisciplina.Text;
            clsEntidade.Atividade = cboAtv.Text;
            clsEntidade.Nota = txtNota.Text;
            clsEntidade.Action = action;

            if (action == "1")
            {
                clsEntidade.Id = "";
            }

            MessageBox.Show(clsNegocio.N_CrudNota(clsEntidade));
            dgvNotas.DataSource = clsNegocio.N_ListarAtividades();
            Limpar();
        }

        private void btnRemov_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar esta Nota?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                dgvNotas.DataSource = clsNegocio.N_ListarNotas();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar esta Nota?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");
                dgvNotas.DataSource = clsNegocio.N_ListarNotas();
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

            dgvAlunos.DataSource = dt;
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvAlunos.CurrentCell.RowIndex;
            txtNome.Text = dgvAlunos[1, fila].Value.ToString();

            clsEntidade.Curso = dgvAlunos[6, fila].Value.ToString();
            cboCurso.DataSource = clsNegocio.N_BuscarCurso(clsEntidade);
            cboCurso.DisplayMember = "Curso";
            cboCurso.ValueMember = "nome_curso";

            clsEntidade.Turma = dgvAlunos[5, fila].Value.ToString();
            cboTurma.DataSource = clsNegocio.N_BuscarTurma(clsEntidade);
            cboTurma.DisplayMember = "Turma";
            cboTurma.ValueMember = "nome_turma";

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cboCurso.Text == "" || cboDisciplina.Text == ""  || cboAtv.Text == "" || txtNota.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (MessageBox.Show("Deseja cadastrar esta Nota?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                dgvNotas.DataSource = clsNegocio.N_ListarNotas();
            }
        }

        
    }
}

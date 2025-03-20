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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCadastrar f = new FrmCadastrar();
            f.Show();
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsEntidade.Curso = cboCurso.Text;
            dgvDisciplina.DataSource = clsNegocio.N_ListarDisciplinas(clsEntidade);
        }

        void Limpar()
        {
            txtDisciplina.Text = "";
            cboCurso.SelectedItem = null;
        }

        private void dgvDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvDisciplina.CurrentCell.RowIndex;
            txtDisciplina.Text = dgvDisciplina[1, fila].Value.ToString();
            clsEntidade.Id = dgvDisciplina[0, fila].Value.ToString();
            cboCurso.Text = dgvDisciplina[2, fila].Value.ToString();
        }

        void CRUD(String action)
        {
            clsEntidade.Disciplina = txtDisciplina.Text;
            clsEntidade.Curso = cboCurso.Text;
            clsEntidade.Action = action;

            if (action == "1")
            {
                clsEntidade.Id = "";
            }

            MessageBox.Show(clsNegocio.N_CrudDisciplina(clsEntidade));
            dgvDisciplina.DataSource = clsNegocio.N_ListarDisciplinas(clsEntidade);
            Limpar();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsEntidade.Disciplina = txtSearch.Text + "%";

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarDisciplina(clsEntidade);

            dgvDisciplina.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDisciplina.Text == "")
            {
                MessageBox.Show("Preencha o campo nome do curso", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else if (MessageBox.Show("Deseja cadastrar esta Disciplina?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                clsEntidade.Curso = cboCurso.Text;
                dgvDisciplina.DataSource = clsNegocio.N_ListarDisciplinas(clsEntidade);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar esta Disciplina?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");
                clsEntidade.Curso = cboCurso.Text;
                dgvDisciplina.DataSource = clsNegocio.N_ListarDisciplinas(clsEntidade);

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover esta Disciplina?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("3");
                clsEntidade.Curso = cboCurso.Text;
                dgvDisciplina.DataSource = clsNegocio.N_ListarDisciplinas(clsEntidade);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            cboCurso.DataSource = clsNegocio.N_ListarCursos();
            cboCurso.DisplayMember = "curso";
            cboCurso.ValueMember = "nome_curso";
        }
    }
}

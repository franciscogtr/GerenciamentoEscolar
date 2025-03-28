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
    public partial class FrmAtividades: Form
    {
        public FrmAtividades()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void FrmAtividades_Load(object sender, EventArgs e)
        {
            cboCurso.DataSource = clsNegocio.N_ListarCursos();
            cboCurso.DisplayMember = "Curso";
            cboCurso.ValueMember = "nome_curso";

        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cboDisciplina.Text = "";
            clsEntidade.Curso = cboCurso.Text;
            cboDisciplina.DataSource = clsNegocio.N_ListarDisciplinas();
            cboDisciplina.DisplayMember = "Disciplina";
            cboDisciplina.ValueMember = "nome_disciplina";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal f = new FrmPrincipal();
            f.Show();
        }

        private void cboDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsEntidade.Disciplina = cboDisciplina.Text;
            clsEntidade.Curso = cboCurso.Text;
            clsEntidade.Atividade = txtAtv.Text;
            dgvAtividade.DataSource = clsNegocio.N_ListarAtividades();
        }

        void Limpar()
        {
            txtAtv.Text = "";
            cboCurso.SelectedItem = null;
            cboDisciplina.SelectedItem = null;
        }

        private void dgvAtividade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvAtividade.CurrentCell.RowIndex;
            txtAtv.Text = dgvAtividade[1, fila].Value.ToString();
            clsEntidade.Id = dgvAtividade[0, fila].Value.ToString();
            cboCurso.Text = dgvAtividade[2, fila].Value.ToString();
            cboDisciplina.Text = dgvAtividade[3, fila].Value.ToString();
        }

        void CRUD(String action)
        {
            clsEntidade.Atividade = txtAtv.Text;
            clsEntidade.Curso = cboCurso.Text;
            clsEntidade.Disciplina = cboDisciplina.Text;
            clsEntidade.Action = action;

            if (action == "1")
            {
                clsEntidade.Id = "";
            }

            MessageBox.Show(clsNegocio.N_CrudAtividade(clsEntidade));
            dgvAtividade.DataSource = clsNegocio.N_ListarAtividades();
            Limpar();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (txtAtv.Text == "" || cboCurso.Text == "" || cboDisciplina.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (MessageBox.Show("Deseja cadastrar esta Atividade?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {   
                CRUD("1");
                dgvAtividade.DataSource = clsNegocio.N_ListarDisciplinas();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar esta Atividade?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");

                dgvAtividade.DataSource = clsNegocio.N_ListarDisciplinas();
                Limpar();
            }
        }

        private void btnRemov_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover esta Atividade?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("3");

                dgvAtividade.DataSource = clsNegocio.N_ListarDisciplinas();
                Limpar();
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}

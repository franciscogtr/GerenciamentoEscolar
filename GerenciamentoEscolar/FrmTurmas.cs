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
    public partial class FrmTurmas: Form
    {
        public FrmTurmas()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal f = new FrmPrincipal();
            f.ShowDialog();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            dataGridViewTurma.DataSource = clsNegocio.N_ListarTurmas();
        }

        void Limpar()
        {
            textBoxTurma.Text = "";
        }

        private void dataGridViewTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewTurma.CurrentCell.RowIndex;
            textBoxTurma.Text = dataGridViewTurma[1, fila].Value.ToString();
            clsEntidade.Id = dataGridViewTurma[0, fila].Value.ToString();
        }

        void CRUD(String action)
        {
            clsEntidade.Turma = textBoxTurma.Text;
            clsEntidade.Action = action;
            if (action == "1")
            {
                clsEntidade.Id = "";
            }
            MessageBox.Show(clsNegocio.N_CrudTurma(clsEntidade));
            dataGridViewTurma.DataSource = clsNegocio.N_ListarTurmas();
            Limpar();
        }

        private void txtBoxBuscarT_TextChanged(object sender, EventArgs e)
        {
            clsEntidade.Turma = txtBoxBuscarT.Text + "%";

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarTurma(clsEntidade);

            dataGridViewTurma.DataSource = dt;
        }

        private void btnCadTurma_Click(object sender, EventArgs e)
        {
            if (textBoxTurma.Text == "")
            {
                MessageBox.Show("Preencha o campo nome da Turma", "Mensagem",
                   MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else if (MessageBox.Show("Deseja cadastrar esta Turma?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                dataGridViewTurma.DataSource = clsNegocio.N_ListarTurmas();
            }
        }

        private void btnEdTurma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar esta Turma?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");
                dataGridViewTurma.DataSource = clsNegocio.N_ListarTurmas();
            }
        }

        private void btnRemTurma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover esta Turma?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("3");
                dataGridViewTurma.DataSource = clsNegocio.N_ListarTurmas();
            }
        }

        private void btnLimpTurma_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}

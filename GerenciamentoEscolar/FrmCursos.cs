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
    public partial class FrmCursos: Form
    {
        public FrmCursos()
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

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsNegocio.N_ListarCursos();
        }

        void Limpar()
        {
            textBoxNome.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            textBoxNome.Text = dataGridView1[1, fila].Value.ToString();
            clsEntidade.Id = dataGridView1[0, fila].Value.ToString();
        }

        void CRUD(String action)
        {
            clsEntidade.Curso = textBoxNome.Text;
            clsEntidade.Action = action;

            if (action == "1")
            {
                clsEntidade.Id = "";
            }

            MessageBox.Show(clsNegocio.N_CrudCurso(clsEntidade));
            dataGridView1.DataSource = clsNegocio.N_ListarCursos();
            Limpar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            clsEntidade.Curso = textBox3.Text + "%";

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarCurso(clsEntidade);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome do curso", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else if (MessageBox.Show("Deseja cadastrar este Curso?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                dataGridView1.DataSource = clsNegocio.N_ListarCursos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar este Curso?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");
                dataGridView1.DataSource = clsNegocio.N_ListarCursos();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este Curso?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("3");
                dataGridView1.DataSource = clsNegocio.N_ListarCursos();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}

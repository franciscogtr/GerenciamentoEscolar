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
            FrmCadastrar f = new FrmCadastrar();
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

            txtNome
        }
    }
}

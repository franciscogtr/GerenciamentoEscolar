using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar
{
    public partial class FrmCadastrar: Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            if (Login.id_tipo == "Administrador")
            {
                pictureBox1.Visible = true;
                panel3.Visible = true;
                labelCadAlunos.Visible = true;


            }
            else if (Login.id_tipo == "Secretaria")
            {



                pictureBox4.Enabled = false;

            }
            else
            {

                pictureBox1.Enabled = false;

                pictureBox2.Enabled = false;

                pictureBox3.Enabled = false;

                pictureBox4.Enabled = false;

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal f = new FrmPrincipal();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAluno f = new FrmAluno();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTurmas f = new FrmTurmas();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCursos f = new FrmCursos();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario f = new FrmUsuario();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDisciplina f = new FrmDisciplina();
            f.ShowDialog();
        }
    }
}

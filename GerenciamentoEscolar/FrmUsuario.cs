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
    public partial class FrmUsuario: Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        ClasseEntidade clsEntidade = new ClasseEntidade();
        ClasseNegocio clsNegocio = new ClasseNegocio();

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = new FrmPrincipal();
            this.Hide();
            f.ShowDialog();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
            
        }

        void Limpar()
        {
            textBoxNome.Text = "";
            textBoxSenha.Text = "";
            comboBoxTipo.Text = "";
            textBoxEmail.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            textBoxNome.Text = dataGridView1[1, fila].Value.ToString();
            textBoxSenha.Text = dataGridView1[2, fila].Value.ToString();
            textBoxEmail.Text = dataGridView1[3, fila].Value.ToString();
            comboBoxTipo.Text = dataGridView1[4, fila].Value.ToString();
            clsEntidade.Id = dataGridView1[0, fila].Value.ToString();
            //textBoxId.Text = clsEntidade.Id;

        }

        void CRUD(String action)
        {
            clsEntidade.User = textBoxNome.Text;
            clsEntidade.Pass = textBoxSenha.Text;
            clsEntidade.Tipo = comboBoxTipo.Text;
            clsEntidade.Email = textBoxEmail.Text;

            if (action == "1")
            {
               clsEntidade.Id = "";
            }

            clsEntidade.Action = action;

            string men = clsNegocio.N_CrudUsuario(clsEntidade);

            MessageBox.Show(men, "Mensagem Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
            Limpar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            clsEntidade.User = textBox3.Text + "%";

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarUsuario(clsEntidade);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxSenha.Text == "" || comboBoxTipo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Deseja cadastrar este usuário?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("1");
                dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar este usuário?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("2");
                dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este usuário?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CRUD("3");
                dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}

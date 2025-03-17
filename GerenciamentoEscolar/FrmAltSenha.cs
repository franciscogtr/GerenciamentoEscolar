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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciamentoEscolar
{
    public partial class FrmAltSenha: Form
    {
        public FrmAltSenha()
        {
            InitializeComponent();
        }

        ClasseNegocio clsNegocio = new ClasseNegocio();
        ClasseEntidade clsEntidade = new ClasseEntidade();

        public static string usuario_nome;
        public static string usuario_senha;
        public static string usuario_email;
        public static string usuario_tipo;
        public static string usuario_id;


        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal f = new FrmPrincipal();
            f.ShowDialog();
        }

        private void FrmAltSenha_Load(object sender, EventArgs e)
        {
            clsEntidade.User = Login.usuario_nome + "%";
            //MessageBox.Show(clsEntidade.User);

            DataTable dt = new DataTable();
            dt = clsNegocio.N_BuscarUsuario(clsEntidade);

            usuario_id = dt.Rows[0][0].ToString();
            usuario_nome = dt.Rows[0][1].ToString();
            usuario_senha = dt.Rows[0][2].ToString();
            usuario_email = dt.Rows[0][3].ToString();
            usuario_tipo = dt.Rows[0][4].ToString();
        }

        void Limpar()
        {
            txtBoxSenhaA.Text = "";
            txtBoxSenhaN.Text = "";
            
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {

            if (txtBoxSenhaA.Text == usuario_senha)
            {
                clsEntidade.Id = usuario_id;
                clsEntidade.Pass = txtBoxSenhaN.Text;
                clsEntidade.Email = usuario_email;
                clsEntidade.Tipo = usuario_tipo;
                clsEntidade.User = usuario_nome;
                clsEntidade.Action = "2";

                string men = clsNegocio.N_CrudUsuario(clsEntidade);

                MessageBox.Show(men, "Mensagem Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dataGridView1.DataSource = clsNegocio.N_ListarUsuarios();
                Limpar();
            }
            else
            {
                MessageBox.Show("Senha atual Incorreta");
                Limpar();
            }


        }
    }
}

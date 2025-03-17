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
    public partial class Login: Form
    {
        ClasseEntidade classeUser = new ClasseEntidade();
        ClasseNegocio classeNegocio = new ClasseNegocio();

        public static string usuario_nome;
        public static string id_tipo;
        

        FrmPrincipal f = new FrmPrincipal();

        public Login()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            classeUser.Email = textBoxUsuario.Text;
            classeUser.Pass = textBoxSenha.Text;


            dt = classeNegocio.N_Login(classeUser);

            //classeUser.Tipo = dt.Rows[0][3].ToString();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bem Vindo " + dt.Rows[0][1].ToString(),
                    "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                usuario_nome = dt.Rows[0][1].ToString();
                id_tipo = dt.Rows[0][4].ToString();

                this.Hide();
                f.ShowDialog();
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuário ou senha Incorretos",
                   "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

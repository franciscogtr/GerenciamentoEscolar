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
    
    public partial class FrmPrincipal: Form
    {
        ClasseEntidade objEntidade = new ClasseEntidade();
        ClasseNegocio objNegocio = new ClasseNegocio();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = Login.usuario_nome;
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            



        //    if (Login.id_tipo == "Administrador")
        //    {
        //        pictureBox1.Visible = true;
        //        panel3.Visible = true;
        //        labelCadAlunos.Visible = true;


        //    }
        //    else if (Login.id_tipo == "Secretaria")
        //    {

                
               
        //        pictureBox4.Enabled = false;

        //    } else
        //    {
                
        //        pictureBox1.Enabled = false;
                
        //        pictureBox2.Enabled = false;
                
        //        pictureBox3.Enabled = false;
                
        //        pictureBox4.Enabled = false;

        //    }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltSenha f = new FrmAltSenha();
            f.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNotas f = new FrmNotas();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmCadastrar f = new FrmCadastrar();
            this.Hide();
            f.Show();
        }
    }
}

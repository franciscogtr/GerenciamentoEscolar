using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidade;
using System.Data;
using System.Configuration;

namespace CapaDeDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable DLogin(ClasseEntidade obje)
        {

            SqlCommand cmd = new SqlCommand("sp_logar", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", obje.Email);
            cmd.Parameters.AddWithValue("@senha", obje.Pass);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DBuscarUsuario(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuario", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obje.User);



            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DBuscarCurso(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_curso", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obje.Curso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable DBuscarTurmas(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_turma", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obje.Turma);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable DBuscarAluno(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_aluno", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obje.Aluno);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DListarUsuarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuario", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DListarCursos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_curso", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DListarTurmas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_turma", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DListarAlunos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_aluno", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String DCrudUsuario(ClasseEntidade obje)
        {
            string action = "";

            SqlCommand cmd = new SqlCommand("sp_crud_usuario", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", obje.Id);
            cmd.Parameters.AddWithValue("@nome", obje.User);
            cmd.Parameters.AddWithValue("@senha", obje.Pass);
            cmd.Parameters.AddWithValue("@email", obje.Email);
            cmd.Parameters.AddWithValue("@tipo", obje.Tipo);
            cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = obje.Action;
            cmd.Parameters["@action"].Direction = ParameterDirection.InputOutput;


            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            action = cmd.Parameters["@action"].Value.ToString();
            con.Close();
            return action;
        }

        public String DCrudCurso(ClasseEntidade obje)
        {
            string action = "";
            SqlCommand cmd = new SqlCommand("sp_crud_curso", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obje.Id);
            cmd.Parameters.AddWithValue("@nome", obje.Curso);

            cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = obje.Action;
            cmd.Parameters["@action"].Direction = ParameterDirection.InputOutput;

            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            action = cmd.Parameters["@action"].Value.ToString();
            con.Close();
            return action;

        }

        public String DCrudTurma(ClasseEntidade obje)
        {
            string action = "";
            SqlCommand cmd = new SqlCommand("sp_crud_turma", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obje.Id);
            cmd.Parameters.AddWithValue("@nome", obje.Turma);

            cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = obje.Action;
            cmd.Parameters["@action"].Direction = ParameterDirection.InputOutput;

            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            action = cmd.Parameters["@action"].Value.ToString();
            con.Close();
            return action;
        }

        public String DCrudAluno(ClasseEntidade obje)
        {
            string action = "";
            SqlCommand cmd = new SqlCommand("sp_crud_aluno", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obje.Id);
            cmd.Parameters.AddWithValue("@nome", obje.Aluno);
            cmd.Parameters.AddWithValue("@email", obje.Email);
            cmd.Parameters.AddWithValue("@telefone", obje.Tel);
            cmd.Parameters.AddWithValue("@matricula", obje.Matricula);
            cmd.Parameters.AddWithValue("@curso", obje.Curso);
            cmd.Parameters.AddWithValue("@turma", obje.Turma);
            cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = obje.Action;
            cmd.Parameters["@action"].Direction = ParameterDirection.InputOutput;
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            action = cmd.Parameters["@action"].Value.ToString();
            con.Close();
            return action;
        }
    }
}

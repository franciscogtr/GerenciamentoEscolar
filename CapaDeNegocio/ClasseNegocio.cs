using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDados;
using CapaDeEntidade;

namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados classeDados = new ClasseDados();

        public DataTable N_Login (ClasseEntidade obje)
        {
            return classeDados.DLogin(obje);
        }

        public DataTable N_BuscarUsuario(ClasseEntidade obje)
        {
            return classeDados.DBuscarUsuario(obje);
        }

        public DataTable N_BuscarCurso(ClasseEntidade obje)
        {
            return classeDados.DBuscarCurso(obje);
        }

        public DataTable N_BuscarTurma(ClasseEntidade obje)
        {
            return classeDados.DBuscarTurmas(obje);
        }

        public DataTable N_BuscarAluno(ClasseEntidade obje)
        {
            return classeDados.DBuscarAluno(obje);
        }

        public DataTable N_ListarUsuarios()
        {
            return classeDados.DListarUsuarios();
        }

        public DataTable N_ListarCursos()
        {
            return classeDados.DListarCursos();
        }

        public DataTable N_ListarTurmas()
        {
            return classeDados.DListarTurmas();
        }

        public DataTable N_ListarAlunos()
        {
            return classeDados.DListarAlunos();
        }

        public String N_CrudUsuario(ClasseEntidade obje)
        {
            return classeDados.DCrudUsuario(obje);
        }

        public String N_CrudCurso(ClasseEntidade obje)
        {
            return classeDados.DCrudCurso(obje);
        }

        public String N_CrudTurma(ClasseEntidade obje)
        {
            return classeDados.DCrudTurma(obje);
        }

        public String N_CrudAluno(ClasseEntidade obje)
        {
            return classeDados.DCrudAluno(obje);
        }


    }
}

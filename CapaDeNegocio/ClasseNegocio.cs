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
    }
}

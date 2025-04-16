using Sistema.DAO;
using Sistema.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class UsuarioModel
    {
        public static int Inserir(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Inserir(objTabela);

        }
    }
}

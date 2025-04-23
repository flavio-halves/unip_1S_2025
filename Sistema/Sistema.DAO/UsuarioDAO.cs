using Sistema.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.DAO
{
    public class UsuarioDAO
    {
       // public class Inserir
        //{
            //private UsuarioEnt objTabela;

            public int Inserir(UsuarioEnt objTabela)
            {
                using (SqlConnection con = new SqlConnection())
                {

                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();

                    cn.CommandText = "INSERT INTO usuarios ([nome], [usuario], [senha]) VALUES (@nome, @usuario, @senha)";

                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                    cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                    cn.Connection = con;

                    int qtd = cn.ExecuteNonQuery();
                    Console.Write(qtd);
                    return qtd;

                }
            }
        }
    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controller
{
    public class Conexao
    {
        private String stringConexao;
        private MySqlConnection conexao;

        public Conexao (String dadosConexao)
        {
            conexao = new MySqlConnection();
            stringConexao = dadosConexao;
            conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao { get; set; }
        public MySqlConnection ObjetoConexao
        {
            get { return conexao; }
            set { conexao = value; }
        }
        public void Conectar()
        {
            conexao.Open();
        }
        public Desconectar()
        {
            conexao.Close();
        }
    }
}

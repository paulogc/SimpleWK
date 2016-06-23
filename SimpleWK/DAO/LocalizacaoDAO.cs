using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO {
    public class LocalizacaoDAO {
        public void Create(Localizacao end) {
            Database dbSWK = Database.GetInstance();
            
            string qryLocalizacao = string.Format("INSERT INTO localizacao (logradouro, numero, bairro, cep, cidade, uf, pais, complemento)" +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                end.Logradouro, end.Numero, end.Bairro, end.Cep, end.Cidade, end.Uf, end.Pais, end.Complemento);

            dbSWK.ExecuteSQL(qryLocalizacao);
        }

        public void Update(Localizacao end) {
            Database dbSWK = Database.GetInstance();

            String qry = "UPDATE localizacao SET logradouro ='" + 
                end.Logradouro + "', numero = " + 
                end.Numero + ", bairro = '" +
                end.Bairro + "', cep = '" +
                end.Cep + "', cidade = '" +
                end.Cidade + "', uf = '" +
                end.Uf + "', pais = '" +
                end.Pais + "', complemento = '" +
                end.Complemento + "' WHERE id_localizacao = " +
                end.Id + ";";

            dbSWK.ExecuteSQL(qry);
        }

        public void Delete(Localizacao end) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM localizacao WHERE id_localizacao = " + end.Id;
            dbSWK.ExecuteSQL(qry);
            
        }

        public Localizacao Read(int id) {
            Localizacao local = new Localizacao(); 

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT logradouro, numero, bairro, cep, cidade," +
                " uf, pais, complemento FROM localizacao WHERE  id_localizacao = " + id + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {                
                local.Id = dr.GetInt32("id_localizacao");
                local.Logradouro = dr.GetString("logradouro");
                local.Numero = dr.GetInt32("numero");
                local.Bairro = dr.GetString("bairro");
                local.Cidade = dr.GetString("cidade");
                local.Cep = dr.GetString("cep");
                local.Uf = dr.GetString("uf");
                local.Complemento = dr.GetString("complemento");
            }

            conexao.Close();

            return local;
        }

    }
}

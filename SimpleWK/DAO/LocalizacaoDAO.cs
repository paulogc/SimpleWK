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

            string qryLocalizacao = string.Format("INSERT INTO localizacao (logradouro, numero, bairro, cep, cidade, uf, pais, complemento" +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
                end.Logradouro, end.Numero, end.Bairro, end.Cep, end.Cidade, end.Uf, end.Pais, end.Complemento);

            dbSWK.ExecuteSQL(qryLocalizacao);
        }

        public Localizacao Read(Pessoa p) {
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "Select ";
        }

    }
}

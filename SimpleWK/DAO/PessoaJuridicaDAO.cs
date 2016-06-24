using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class PessoaJuridicaDAO
    {
        public void Create(Juridica pessoa)
        {
            Database dbSWK = Database.GetInstance();

            String qryPessoa = String.Format("INSERT INTO pessoa (nome, email, telefone_fixo, telefone_movel, id_endereco) " +
                 "VALUES('" +
                 pessoa.Nome + "', '" +
                 pessoa.Email + "', '" +
                 pessoa.TelefoneFixo + "', '" +
                 pessoa.TelefoneMovel + "', " +
                 pessoa.Endereco.Id + ");");

            dbSWK.ExecuteSQL(qryPessoa);
            int idPessoa = dbSWK.GetId();

            String qryJuridica = "INSERT INTO juridica (fk_id_pessoa, cnpj, razao_social) VALUES(" +
               idPessoa + ", '" +
               pessoa.Cnpj + "', '" +
               pessoa.RazaoSocial + "');";

            dbSWK.ExecuteSQL(qryJuridica);
        }

        public void Update(Juridica pessoa)
        {
            Database dbSWK = Database.GetInstance();

            String qryPes = "UPDATE pessoa SET nome = '" +
                pessoa.Nome + "', email = '" +
                pessoa.Email + "', telefone_fixo = '" +
                pessoa.TelefoneFixo + "', telefone_movel = '" +
                pessoa.TelefoneMovel + "' WHERE id_pessoa = " +
                pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryPes);

            String qryJur = "UPDATE juridica SET cnpj = '" +
                pessoa.Cnpj + "', razao_social = '" +
                pessoa.RazaoSocial + "' WHERE fk_id_pessoa = " +
                pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryJur);
        }

        public void Delete(Juridica pessoa)
        {
            Database dbSWK = Database.GetInstance();

            String qryJur = "DELETE FROM juridica WHERE fk_id_pessoa = " + pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryJur);

            String qryPes = "DELETE FROM pessoa WHERE id_pessoa = " + pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryPes);
        }
    }
}

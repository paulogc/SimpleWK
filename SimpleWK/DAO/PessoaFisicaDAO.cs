using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO {
    public class PessoaFisicaDAO {
        public void Create(Fisica pessoa) { 
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

            String qryFisica = "INSERT INTO fisica (fk_id_pessoa, cpf, sobrenome) VALUES(" +
               idPessoa + ", '" +
               pessoa.Cpf + "', '" +
               pessoa.Sobrenome + "');";

            dbSWK.ExecuteSQL(qryFisica);        
        }

        public void Update(Fisica pessoa) {
            Database dbSWK = Database.GetInstance();

            String qryPes = "UPDATE pessoa SET nome = '" + 
                pessoa.Nome + "', email = '" +
                pessoa.Email + "', telefone_fixo = '" +
                pessoa.TelefoneFixo + "', telefone_movel = '" +
                pessoa.TelefoneMovel + "' WHERE id_pessoa = " +
                pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryPes);

            String qryFis = "UPDATE fisica SET sobrenome = '" +
                pessoa.Sobrenome + "', cpf = '" +
                pessoa.Cpf + "' WHERE fk_id_pessoa = " +
                pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryFis);
        }

        public void Delete(Fisica pessoa) {
            Database dbSWK = Database.GetInstance();

            String qryFis = "DELETE FROM fisica WHERE fk_id_pesso = " + pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryFis);

            String qryPes = "DELETE FROM pessoa WHERE id_pessoa = " + pessoa.Id + ";";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

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

        public Juridica Read(int id, int idEndereco)
        {
            Juridica pessoa = new Juridica();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT p.id_pessoa, p.nome, p.email, p.telefone_fixo, " +
                "p.telefone_movel, p.id_endereco, pj.cnpj, pj.sobrenome" +
                " FROM pessoa p, juridica pj WHERE p.id_pessoa = pj.fk_id_pessoa" +
                " AND id_pessoa  = " + id + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pessoa.Id = dr.GetInt32("p.id_pessoa");
                pessoa.Nome = dr.GetString("p.nome");
                pessoa.Email = dr.GetString("p.email");
                pessoa.TelefoneFixo = dr.GetString("p.telefone_fixo");
                pessoa.TelefoneMovel = dr.GetString("p.telefone_movel");
                pessoa.Cnpj = dr.GetString("pj.cpf");
                pessoa.RazaoSocial = dr.GetString("pj.razao_social");
                idEndereco = dr.GetInt32("p.id_endereco");
            }

            return pessoa;
        }

        public DataTable ListAllJuridica()
        {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtJuridica = new DataTable();

            string qry = "SELECT p.nome, j.razao_social, j.cnpj, p.email, p.telefone_fixo from pessoa p, juridica j where p.id_pessoa = j.fk_id_pessoa";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtJuridica);

            conexao.Close();
            return dtJuridica;
        }
    }
}

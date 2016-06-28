using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

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

            String qryFis = "DELETE FROM fisica WHERE fk_id_pessoa = " + pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryFis);

            String qryPes = "DELETE FROM pessoa WHERE id_pessoa = " + pessoa.Id + ";";
            dbSWK.ExecuteSQL(qryPes);
        }

        public Fisica Read(int id) {
            Fisica pessoa = new Fisica();
            int idEndereco = 0;
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT p.id_pessoa, p.nome, p.email, p.telefone_fixo, " +
                "p.telefone_movel, p.id_endereco, pf.cpf, pf.sobrenome" + 
                " FROM pessoa p, fisica pf WHERE p.id_pessoa = pf.fk_id_pessoa" + 
                " AND id_pessoa  = " + id + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pessoa.Id = dr.GetInt32("id_pessoa");
                pessoa.Nome = dr.GetString("nome");
                pessoa.Email = dr.GetString("email");
                pessoa.TelefoneFixo = dr.GetString("telefone_fixo");
                pessoa.TelefoneMovel = dr.GetString("telefone_movel");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Sobrenome = dr.GetString("sobrenome");
                idEndereco = dr.GetInt32("id_endereco");
            }

            conexao.Close();


            if (idEndereco > 0)
            {
                LocalizacaoDAO local = new LocalizacaoDAO();
                pessoa.Endereco = local.ReadById(idEndereco);
            }

            return pessoa;
        }

        public DataTable ListAllFisica() {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtFisica = new DataTable();

            string qry = "SELECT p.id_pessoa, p.nome, f.sobrenome, f.cpf, p.email, p.telefone_fixo from pessoa p, fisica f where p.id_pessoa = f.fk_id_pessoa";

            if(conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFisica);

            conexao.Close();
            return dtFisica;
        }

        public DataTable ListAllFisica(String buscarPor) {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtFisica = new DataTable();

            string qry = "SELECT p.id_pessoa, p.nome, f.sobrenome, f.cpf, p.email, p.telefone_fixo FROM" +
                " pessoa p, fisica f WHERE p.id_pessoa = f.fk_id_pessoa AND p.nome LIKE '%" + buscarPor + "%';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFisica);

            conexao.Close();
            return dtFisica;
        }


        public DataTable BuscaFisica(string busca, string campo) {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtFisica = new DataTable();

            string qry = "SELECT p.id_pessoa, p.nome, f.sobrenome, f.cpf, p.email, p.telefone_fixo FROM pessoa p, fisica f WHERE p.id_pessoa = f.fk_id_pessoa AND "
                + campo + " like '%" + busca + "%';";

            if(conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFisica);

            conexao.Close();
            return dtFisica;
        }

        public Fisica BuscarCpf(String cpf) {
            Fisica pessoa = new Fisica();
            pessoa.Cpf = cpf;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT fk_id_pessoa FROM fisica WHERE cpf = '" + cpf + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pessoa.Id = dr.GetInt32("fk_id_pessoa");
            }
            conexao.Close();

            pessoa = Read(pessoa.Id);

            return pessoa;
        }


    }
}

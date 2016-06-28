using System;
using System.Collections.Generic;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO {
    public class CompraDAO {

        public void Create(Compra compra) {        
                        
            string sqlDateTime = compra.DataHora.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost; Database=simplewk; Uid=root; Pwd=;";
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO acao (nota_fiscal, valor, data_hora, fk_id_pessoa) VALUES (@nota_fiscal, @valor, @data_hora, @fk_id_pessoa)", con);

            /*String qryAcao = "INSERT INTO acao (nota_fiscal, valor, data_hora, fk_id_pessoa) VALUES ('" +
                compra.NotaFiscal +"', " + compra.Valor + ", '" + sqlDateTime + "', " + compra.PessoaFJ.Id + ");";
            dbSWK.ExecuteSQL(qryAcao);*/

            cmd.Parameters.AddWithValue("@nota_fiscal", compra.NotaFiscal);
            cmd.Parameters.AddWithValue("@valor", compra.Valor);
            cmd.Parameters.AddWithValue("@data_hora", sqlDateTime);
            cmd.Parameters.AddWithValue("@fk_id_pessoa", compra.PessoaFJ.Id);

            cmd.ExecuteNonQuery();

            con.Close();

            Database dbSWK = Database.GetInstance();
            int idAcao = dbSWK.GetId();

            String qryCompra = "INSERT INTO compra (id_acao) VALUES(" + idAcao + ")";
            dbSWK.ExecuteSQL(qryCompra);

            foreach(InsumoAcao insumo in compra.Insumos)
            {
                String qryLista = "INSERT INTO lista_compra_insumos (id_compra, id_insumo, quantidade) VALUES(" +
                    idAcao + ", " + insumo.Id + ", " + insumo.QuantidadeInsumo + ");";
                dbSWK.ExecuteSQL(qryLista);

                String qryIncrementa = "UPDATE item SET quantidade = quantidade + " + insumo.QuantidadeInsumo + " WHERE id_item = " + insumo.Id + ";";
                dbSWK.ExecuteSQL(qryIncrementa);
            }
        }

        public Compra Read(int idCompra) {
            Compra compra = new Compra();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT id_acao, nota_fiscal, valor, data_hora, fk_id_pessoa FROM acao WHERE id_acao = " + idCompra;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                compra.Id = dr.GetInt32("id_acao");
                compra.NotaFiscal = dr.GetString("nota_fiscal");
                compra.Valor = dr.GetDecimal("valor");
                compra.DataHora = (dr.GetDateTime("data_hora"));
                compra.PessoaFJ.Id = dr.GetInt32("fk_id_pessoa");
            }

            conexao.Close();

            PessoaJuridicaDAO pjDAO = new PessoaJuridicaDAO();
            compra.PessoaFJ = pjDAO.Read(compra.PessoaFJ.Id);

            compra.Insumos = ListarInsumos(compra.Id);

            return compra;
        }

        private List<InsumoAcao> ListarInsumos(int idProdutoFinal) {
            List<InsumoAcao> lista = new List<InsumoAcao>();
            InsumoAcao insumo;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qryLita = "SELECT id_insumo, quantidade FROM lista_compra_insumos WHERE " +
                "id_compra = " + idProdutoFinal + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qryLita, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                insumo = new InsumoAcao();
                insumo.Id = dr.GetInt32("id_insumo");
                insumo.QuantidadeInsumo = dr.GetInt32("quantidade");
                lista.Add(insumo);
            }
            conexao.Close();

            foreach (InsumoAcao insu in lista)
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();

                String qryItem = "SELECT nome, descricao, valor_custo FROM item WHERE id_item = " + insu.Id + ";";
                comm = new MySqlCommand(qryItem, conexao);
                dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    insu.Nome = dr.GetString("nome");
                    insu.Descricao = dr.GetString("descricao");
                    insu.ValorCusto = dr.GetDecimal("valor_custo");
                }
                conexao.Close();
            }

            return lista;
        }

        private void Delete(Compra compra) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM lista_itens_compra WHERE id_compra = " + compra.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM compra WHERE id_acao = " + compra.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM acao WHERE id_acao = " + compra.Id;
            dbSWK.ExecuteSQL(qry);
        }

        public DataTable ListAllCompras() {
            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtPF = new DataTable();

            string qry = "SELECT a.id_acao, a.nota_fiscal, a.data_hora, a.valor, p.nome FROM acao a " +
                "INNER JOIN compra c ON a.id_acao = c.id_acao " +
                "INNER JOIN pessoa p ON a.fk_id_pessoa = p.id_pessoa";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtPF);

            conexao.Close();
            return dtPF;
        }
    }
 }

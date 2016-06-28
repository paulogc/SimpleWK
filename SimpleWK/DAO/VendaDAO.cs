using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO {
    public class VendaDAO {
        public void Create(Venda venda) {           

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost; Database=simplewk; Uid=root; Pwd=;";
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO acao (nota_fiscal, valor, fk_id_pessoa) VALUES (@nota_fiscal, @valor, @fk_id_pessoa);", con);
            cmd.Parameters.AddWithValue("@nota_fiscal", venda.NotaFiscal);
            cmd.Parameters.AddWithValue("@valor", venda.Valor);
            cmd.Parameters.AddWithValue("@fk_id_pessoa", venda.PessoaJF.Id);

            cmd.ExecuteNonQuery();

            con.Close();

            /*string qryAcao = string.Format("INSERT INTO acao (nota_fiscal, valor, fk_id_pessoa)" +
                "VALUES('{0}','{1}','{2}');",
                venda.NotaFiscal, venda.Valor, venda.PessoaFJ.Id);

            dbSWK.ExecuteSQL(qryAcao);*/
            Database dbSWK = Database.GetInstance();
            int idAcao = dbSWK.GetId();            

            string qryVenda = string.Format("INSERT INTO venda (id_acao) VALUES('{0}');", idAcao);

            dbSWK.ExecuteSQL(qryVenda);

            foreach (ProdutoAcao produto in venda.Produtos)
            {
                String qryLista = "INSERT INTO lista_venda_produtos (id_venda, id_produto_final, quantidade) VALUES(" +
                    idAcao + ", " + produto.Id + ", " + produto.QuantidadeProduto + ");";
                dbSWK.ExecuteSQL(qryLista);

                String qryIncrementa = "UPDATE item SET quantidade = quantidade - " + produto.QuantidadeProduto + " WHERE id_item = " + produto.Id + ";";
                dbSWK.ExecuteSQL(qryIncrementa);
            }


        }

        public Venda Read(String buscarPor, String BuscaValor) {
            Venda venda = new Venda();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT v.id_venda, a.id_acao, a.nota_fiscal, a.valor, a.fk_id_pessoa FROM "
                + "venda v, acao a WHERE " + buscarPor + " = " + BuscaValor + ";";

            return venda;
        }

        public void Delete(Venda venda) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM lista_venda_produtos FROM id_venda = " + venda.Id + ";";
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM venda WHERE id_acao = " + venda.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM acao WHERE id_acao = " + venda.acao.Id;
            dbSWK.ExecuteSQL(qry);            

        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO {
    public class ProdutoFinalDAO 
    {
        public void Create(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();

            string qryItem = string.Format("INSERT INTO item (nome, descricao, valor_custo, quantidade)" +
                "VALUES('{0}','{1}','{2}','{3}');",
                pFinal.Nome, pFinal.Descricao, pFinal.ValorCusto, pFinal.Quantidade);

            dbSWK.ExecuteSQL(qryItem);

            int idItem = dbSWK.GetId();

            string qryProduto = string.Format("INSERT INTO produto_final (id_item, preco_venda) VALUES('{0}','{1}');", idItem, pFinal.PrecoVenda);

            dbSWK.ExecuteSQL(qryProduto);
        }

        public ProdutoFinal Read(String buscarPor, String BuscaValor) {
            ProdutoFinal pFinal = new ProdutoFinal();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo, i.quantidade FROM "
                + "item i WHERE " + buscarPor + " = " + BuscaValor + ";";

            return pFinal;
        }

        public void Update(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();


            String qry = "UPDATE item SET " +
                "nome = '" + pFinal.Nome + "', descricao = '" + pFinal.Descricao +
                "', valor_custo = " + pFinal.ValorCusto + ", quantidade = " + pFinal.Quantidade +
                " WHERE id_item = " + pFinal.Id + ";";

            dbSWK.ExecuteSQL(qry);
        }

        public void Delete(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM produto_final WHERE id_item = " + pFinal.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM item WHERE id_item = " + pFinal.Id;
            dbSWK.ExecuteSQL(qry);
        }
    }
}

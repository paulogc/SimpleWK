using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO {
    public class ListaInsumoPFDAO {
        public DataTable LisAllInsumo() {
            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();

            string qry = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo FROM item i, insumo n WHERE i.id_item = n.id_item;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);

            conexao.Close();
            return dtInsumo;
        }

        public DataTable ListInsumoForaProdutoFinal(int idProdutoFinal) {
            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();

            String qry = "SELECT item.id_item, item.nome, item.descricao, item.valor_custo, item.quantidade FROM item " +
                "INNER JOIN insumo ON item.id_item = insumo.id_item " +
                "INNER JOIN lista_itens_produto_final ON insumo.id_item != lista_itens_produto_final.id_insumo " +
                "WHERE lista_itens_produto_final.id_produto_final = " + idProdutoFinal + ";";

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);

            conexao.Close();
            return dtInsumo;            
        }

        public void Create(int idInsumo, int idProdutoFinal, int quantidade) {
            Database dbSWK = Database.GetInstance();

            String qry = "INSERT INTO lista_itens_produto_final (id_produto_final, id_insumo, quantidade)" +
                " VALUES(" + idProdutoFinal + ", " + idInsumo + ", " + quantidade + ");";

            dbSWK.ExecuteSQL(qry);
        }

        public void Delete(int idInsumo) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM lista_itens_produto_final WHERE id_insumo = " + idInsumo + ";";

            dbSWK.ExecuteSQL(qry);
        }

        public DataTable ListInsumosProdutoFinal(int idProdutoFinal) {
            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();

            String qry = "SELECT i.id_insumo, i.nome, i.descricao, i.valor_custo, li.quantidade FROM item i " +
                "INNER JOIN insumo ins ON i.id_item = ins.id_item " +
                "INNER JOIN lista_itens_produto_final li ON  ins_id_item = li.id_insumo " +
                "WHERE li.id_produto_final = " + idProdutoFinal + ";";

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);
            conexao.Close();

            return dtInsumo;
        }
    }
}

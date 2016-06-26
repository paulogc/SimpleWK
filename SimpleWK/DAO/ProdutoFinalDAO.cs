using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO {
    public class ProdutoFinalDAO 
    {
        public void Create(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();

            String qryItem = "INSERT INTO item (nome, descricao, valor_custo, quantidade) " +
                "VALUES('" + pFinal.Nome + "', '" 
                + pFinal.Descricao + "', '"
                + pFinal.ValorCusto + "', '" 
                + pFinal.Quantidade + "');";

            dbSWK.ExecuteSQL(qryItem);

            int idItem = dbSWK.GetId();

            String qryProduto = "INSERT INTO produto_final (id_item, preco_venda) " +
                "VALUES(" + idItem + ", " + pFinal.PrecoVenda + ");";
            dbSWK.ExecuteSQL(qryProduto);

            foreach(InsumoProdutoFinal insumoPF in pFinal.Insumos)
            {
                String qryLista = "INSERT INTO lista_itens_produto_final (id_insumo, id_produto_final, quantidade) " +
                    "VALUES(" + insumoPF.Id + ", " + idItem + ", " + insumoPF.QuantidadeInsumo + ");";
                dbSWK.ExecuteSQL(qryLista);
            }
        }

        public ProdutoFinal Read(int buscarPor) {
            ProdutoFinal pFinal = new ProdutoFinal();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qryItem = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo, i.quantidade FROM "
                + "item i WHERE i.id_item = " + buscarPor + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qryItem, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pFinal.Id = dr.GetInt32("id_item");
                pFinal.Nome = dr.GetString("nome");
                pFinal.Descricao = dr.GetString("descricao");
                pFinal.ValorCusto = dr.GetDecimal("valor_custo");
                pFinal.Quantidade = dr.GetInt32("quantidade");
            }

            conexao.Close();

            pFinal.Insumos = ListarInsumos(pFinal.Id);

            return pFinal;
        }

        private List<InsumoProdutoFinal> ListarInsumos(int idProdutoFinal) {
            List<InsumoProdutoFinal> lista = new List<InsumoProdutoFinal>();
            InsumoProdutoFinal insumo;

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            
            String qryLita = "SELECT id_insumo, quantidade FROM lista_itens_produto_final WHERE " +
                "id_produto_final = " + idProdutoFinal + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qryLita, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                insumo = new InsumoProdutoFinal();
                insumo.Id = dr.GetInt32("id_insumo");
                insumo.QuantidadeInsumo = dr.GetInt32("quantidade");
                lista.Add(insumo);
            }
            foreach(InsumoProdutoFinal insu in lista)
            {
                String qryItem = "SELECT nome, descricao, valor_custo FROM item WHERE id_item = " + insu.Id + ";";
                comm = new MySqlCommand(qryItem, conexao);
                dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    insu.Nome = dr.GetString("nome");
                    insu.Descricao = dr.GetString("descricao");
                    insu.ValorCusto = dr.GetDecimal("valor_custo");
                }
            }

            return lista;
        }

        public void Update(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();
            String qry = "UPDATE item SET " +
                "nome = '" + pFinal.Nome + "', descricao = '" + pFinal.Descricao +
                "', valor_custo = " + pFinal.ValorCusto + ", quantidade = " + pFinal.Quantidade +
                " WHERE id_item = " + pFinal.Id + ";";
            dbSWK.ExecuteSQL(qry);

            List<InsumoProdutoFinal> listaBanco = new List<InsumoProdutoFinal>();
            listaBanco = ListarInsumos(pFinal.Id);
            List<InsumoProdutoFinal> listaController = pFinal.Insumos;

            listaBanco = listaBanco.OrderBy(prod => prod.Id).ToList<InsumoProdutoFinal>();
            listaController = listaController.OrderBy(prod => prod.Id).ToList<InsumoProdutoFinal>();

            List<InsumoProdutoFinal> mergeList = new List<InsumoProdutoFinal>();

            foreach (InsumoProdutoFinal insumo in listaController)
            {
                if (!listaBanco.Contains(insumo))
                {
                    Incerir(insumo, pFinal.Id);
                }
            }
            foreach(InsumoProdutoFinal insumo in listaBanco)
            {
                if (!listaController.Contains(insumo))
                {
                    Remover(insumo);
                }
            }

        }

        private void Remover(InsumoProdutoFinal insumo) {
            String qry = "DELETE FROM lista_itens_produto_final WHERE id_insumo = " + insumo.Id + ";";
            Database.GetInstance().ExecuteSQL(qry);
        }

        private void Incerir(InsumoProdutoFinal insumo, int idProdutoFinal) {
            String qry = "INSERT INTO lista_itens_produto_final (id_produto_final, id_insumo, quantidade) " +
                "VALUES(" + idProdutoFinal + ", " + insumo.Id + ", " + insumo.QuantidadeInsumo + ");";
        }

        

        public void Delete(ProdutoFinal pFinal) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM lista_itens_produto_final WHERE id_produto_final = " + pFinal.Id + ";";

            qry = "DELETE FROM produto_final WHERE id_item = " + pFinal.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM item WHERE id_item = " + pFinal.Id;
            dbSWK.ExecuteSQL(qry);
        }

        public DataTable ListAllProdutoFinal() {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtPF = new DataTable();

            string qry = "SELECT p.id_item, i.nome, i.descricao, p.preco_venda, i.quantidade FROM " +
                "item i, produto_final p where i.id_item = p.id_item";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtPF);

            conexao.Close();
            return dtPF;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class InsumoDAO
    {
        public void Create(Insumo insumo)
        {
            Database dbSWK = Database.GetInstance();

            string qryItem = string.Format("INSERT INTO item (nome, descricao, valor_custo, quantidade)" +
                "VALUES('{0}','{1}','{2}','{3}');",
                insumo.Nome, insumo.Descricao, insumo.ValorCusto, insumo.Quantidade);

            dbSWK.ExecuteSQL(qryItem);

            int idItem = dbSWK.GetId();

            string qryInsumo = string.Format("INSERT INTO insumo (id_item) VALUES('{0}');", idItem);

            dbSWK.ExecuteSQL(qryInsumo);
        }

        public Insumo Read(String buscarPor, String BuscaValor)
        {
            Insumo insumo = new Insumo();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo, i.quantidade FROM "
                + "item i WHERE " + buscarPor + " = " + BuscaValor + ";";

            return insumo;
        }

        public void Update(Insumo insumo)
        {
            Database dbSWK = Database.GetInstance();

            String qry = "UPDATE item SET " +
                "nome = '" + insumo.Nome + "', descricao = '" + insumo.Descricao +
                "', valor_custo = " + insumo.ValorCusto + ", quantidade = " + insumo.Quantidade + 
                " WHERE id_item = " + insumo.Id + ";";

            dbSWK.ExecuteSQL(qry);
        }

        public void Delete(Insumo insumo)
        {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM item WHERE id_item = " + insumo.Id;
            dbSWK.ExecuteSQL(qry);
            qry = "DELETE FROM insumo WHERE id_item = " + insumo.Id;
            dbSWK.ExecuteSQL(qry);
        }
    }
}

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

            string qryInsumo = string.Format("INSERT INTO insumo (nome, descricao, valor_custo, quantidade)" +
                "VALUES('{0}','{1}','{2}','{3}');",
                insumo.Nome, insumo.Descricao, insumo.ValorCusto, insumo.Quantidade);

            dbSWK.ExecuteSQL(qryInsumo);
        }
    }
}

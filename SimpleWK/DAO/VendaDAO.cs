using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO {
    public class VendaDAO {
        public void Create(Acao venda) {
            Database dbSWK = Database.GetInstance();

            string qryAcao = string.Format("INSERT INTO acao (nota_fiscal, valor, fk_id_pessoa)" +
                "VALUES('{0}','{1}','{2}');",
                venda.NotaFiscal, venda.Valor, venda.pessoaFJ.Id);

            dbSWK.ExecuteSQL(qryAcao);

            int idAcao = dbSWK.GetId();            

            string qryVenda = string.Format("INSERT INTO venda (id_acao) VALUES('{0}');", idAcao);

            dbSWK.ExecuteSQL(qryVenda);
        }

        public Venda Read(String buscarPor, String BuscaValor) {
            Venda venda = new Venda();
            MySqlConnection conexao = Database.GetInstance().GetConnection();

            String qry = "SELECT v.id_venda, a.id_acao, a.nota_fiscal, a.valor, a.fk_id_pessoa FROM "
                + "venda v, acao a WHERE " + buscarPor + " = " + BuscaValor + ";";

            return venda;
        }

        public void Update(Venda venda) {
            Database dbSWK = Database.GetInstance();

            String qry = "UPDATE acao SET" +
                "nota_fiscal = " + venda.NotaFiscal + ", valor = " + venda.Valor + 
                ", fk_id_pessoa = " + venda.pessoaFJ.Id + "WHERE id_acao = " + venda.acao.Id + ";";

            dbSWK.ExecuteSQL(qry);               
        }

        public void Delete(Venda venda) {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM acao WHERE id_acao = " + venda.acao.Id;
            dbSWK.ExecuteSQL(qry);

            String qryDel = "DELETE FROM venda WHERE id_venda = " + venda.Id;
            dbSWK.ExecuteSQL(qryDel);

        }
    }    
}

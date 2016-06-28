using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace DAO
{
    public class InsumoDAO
    {
        public void Create(Insumo insumo)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost; Database=simplewk; Uid=root; Pwd=;";
            if (con.State != System.Data.ConnectionState.Open)
            con.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO item (nome, descricao, quantidade, valor_custo) Values (@nome, @descricao, @quantidade,@valor_custo);", con);
            cmd.Parameters.AddWithValue("@nome", insumo.Nome);
            cmd.Parameters.AddWithValue("@descricao", insumo.Descricao);
            cmd.Parameters.AddWithValue("@quantidade", insumo.Quantidade);
            cmd.Parameters.AddWithValue("@valor_custo", insumo.ValorCusto);

            cmd.ExecuteNonQuery();


            con.Close();

            Database dbSWK = Database.GetInstance();
            int idItem = dbSWK.GetId();

            string qryInsumo = string.Format("INSERT INTO insumo (id_item) VALUES('{0}');", idItem);

            dbSWK.ExecuteSQL(qryInsumo);

            /*string qryItem = "INSERT INTO item (nome, descricao, quantidade, valor_custo)" +
                "VALUES('" + insumo.Nome + "', '" + insumo.Descricao + "', " + insumo.Quantidade + ", '" + insumo.ValorCusto + "');";
            dbSWK.ExecuteSQL(qryItem);

            */
        }

        public Insumo Read(int idIsumo)
        {
            Insumo insumo = new Insumo();
            MySqlConnection conexao = Database.GetInstance().GetConnection();


            String qry = "SELECT id_item, nome, descricao, quantidade, valor_custo FROM "
                + "item WHERE id_item = " + idIsumo + ";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                insumo.Id = dr.GetInt32("id_item");
                insumo.Nome = dr.GetString("nome");
                insumo.Descricao = dr.GetString("descricao");
                insumo.ValorCusto = dr.GetDecimal("valor_custo");
                insumo.Quantidade = dr.GetInt32("quantidade");

            }
            conexao.Close();
            return insumo;
        }

        public void Update(Insumo insumo)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost; Database=simplewk; Uid=root; Pwd=;";
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE item  SET nome = @nome, descricao = @descricao, quantidade = @quantidade, valor_custo = @valor_custo WHERE id_item = @id_item;", con);

            cmd.Parameters.AddWithValue("@id_item", insumo.Id);
            cmd.Parameters.AddWithValue("@nome", insumo.Nome);
            cmd.Parameters.AddWithValue("@descricao", insumo.Descricao);
            cmd.Parameters.AddWithValue("@quantidade", insumo.Quantidade);
            cmd.Parameters.AddWithValue("@valor_custo", insumo.ValorCusto);

            cmd.ExecuteNonQuery();

            con.Close();

            /*Database dbSWK = Database.GetInstance();


            String qry = "UPDATE item SET " +
                "nome = '" + insumo.Nome + "', descricao = '" + insumo.Descricao +
                "', valor_custo = " + insumo.ValorCusto + ", quantidade = " + insumo.Quantidade + 
                " WHERE id_item = " + insumo.Id + ";";

            dbSWK.ExecuteSQL(qry);*/
        }

        public void Delete(Insumo insumo)
        {
            Database dbSWK = Database.GetInstance();

            String qry = "DELETE FROM insumo WHERE id_item = " + insumo.Id;
            dbSWK.ExecuteSQL(qry);

            qry = "DELETE FROM item WHERE id_item = " + insumo.Id;
            dbSWK.ExecuteSQL(qry);
        }

        public DataTable ListAllInsumo() {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();


            string qry = "SELECT i.id_item, i.nome, i.descricao, i.quantidade, i.valor_custo FROM item i, insumo ins WHERE i.id_item = ins.id_item;";

            if(conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);

            conexao.Close();
            return dtInsumo;
        }

        public DataTable ListAllInsumo(String buscarPor) {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();

            string qry = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo, i.quantidade FROM " +
                "item i, insumo n WHERE i.id_item = n.id_item AND i.nome LIKE '%"+ buscarPor + "%';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);

            conexao.Close();
            return dtInsumo;
        }

        public DataTable BuscaInsumo(string busca, string campo) {

            MySqlConnection conexao = Database.GetInstance().GetConnection();
            DataTable dtInsumo = new DataTable();

            string qry = "SELECT i.id_item, i.nome, i.descricao, i.valor_custo, i.quantidade FROM item i, insumo n WHERE i.id_item = n.id_item AND "
                + campo + " like '%" + busca + "%';";

            if(conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtInsumo);

            conexao.Close();
            return dtInsumo;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Item {
        private int id;
        private String nome;
        private String descricao;
        private double valorCusto;
        private int quantidade;

        public long Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public double ValorCusto { get; set; }
        public int Quantidade { get; set; }

    }
}

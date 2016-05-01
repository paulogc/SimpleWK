using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Item {
        private long id;
        private String nome;
        private String descricao;
        private double valor;
        private long quantidade;

        public long Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public double Valor { get; set; }
        public long Quantidade { get; set; }

    }
}

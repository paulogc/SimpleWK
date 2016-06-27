using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Model {
    public class Item {
        private int id;
        private String nome;
        private String descricao;
        private decimal valorCusto;
        private int quantidade;

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public decimal ValorCusto
        {
            get
            {
                return valorCusto;
            }
            set
            {
                valorCusto = value;
            }
        }
        public int Quantidade { get; set; }
    }
}

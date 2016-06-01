using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class ProdutoFinal : Item {
        private int idProdutoFinal;
        private double precoVenda;
        private List<Item> itens = new List<Item>();

        public void AddItem(Item item) {
            itens.Add(item);
        }

        public void RemoveItem(Item item) {
            itens.Remove(item);
        }

        public int IdProdutoFinal { get; set; }
        public double PrecoVenda { get; set; }
    }
}

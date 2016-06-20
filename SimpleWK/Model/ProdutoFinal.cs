using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class ProdutoFinal : Item {

        private Decimal precoVenda;
        private List<Insumo> insumos = new List<Insumo>();

        public int InsumosLenght() {
            int qtd = insumos.Count();
            return qtd;
        }

        public void AddItem(Insumo Insumo) {
            insumos.Add(Insumo);
        }
        public void RemoveItem(Insumo Insumo) {
            insumos.Remove(Insumo);
        }

        public Decimal PrecoVenda { get; set; }
        public List<Item> Insumos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class ProdutoFinal : Item {

        private Decimal precoVenda;
        private List<Insumo> insumos = new List<Insumo>();
        private List<int> qtdeItem = new List<int>();

        public void AddItem(Insumo insumo) {
            insumos.Add(insumo);
        }

        public void RemoveItem(Insumo insumo) {
            insumos.Remove(insumo);
        }

        public void AddQtd(int qtd) {
            qtdeItem.Add(qtd);
        }

        public void RemoveQtd(int qtd) {
            qtdeItem.Remove(qtd);
        }

        public int CountItem() {
            return insumos.Count;
        }

        public int CountQtd() {
            return qtdeItem.Count;
        }

        public Decimal PrecoVenda { get; set; }

        public List<Insumo> Insumos {
            get {
                return insumos;
            }

            set {
                insumos = value;
            }
        }

        public List<int> QtdeItem {
            get {
                return qtdeItem;
            }

            set {
                qtdeItem = value;
            }
        }
    }
}

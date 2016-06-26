using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class ProdutoFinal : Item {

        private Decimal precoVenda;
        private List<InsumoProdutoFinal> insumos = new List<InsumoProdutoFinal>();

        public void AddInsumo(InsumoProdutoFinal insumoProdutoFinal) {
            insumos.Add(insumoProdutoFinal);
        }

        public void RemoveInsumo(InsumoProdutoFinal insumoProdutoFinal) {
            insumos.Remove(insumoProdutoFinal);
        }

        public List<InsumoProdutoFinal> Insumos { get; set; }
        public Decimal PrecoVenda { get; set; }
    }
}

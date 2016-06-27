using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class ProdutoFinal : Item {

        private Decimal precoVenda;
        private List<InsumoAcao> insumos = new List<InsumoAcao>();

        public void AddInsumo(InsumoAcao insumoProdutoFinal) {
            insumos.Add(insumoProdutoFinal);
        }

        public void RemoveInsumo(InsumoAcao insumoProdutoFinal) {
            insumos.Remove(insumoProdutoFinal);
        }

        public List<InsumoAcao> Insumos { get; set; }
        public Decimal PrecoVenda { get; set; }
    }
}

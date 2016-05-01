using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Compra : Acao{
        private List<Insumo> insumos = new List<Insumo>();

        public void AddInsumo(Insumo insumo) {
            insumos.Add(insumo);
        }

        public void RemoveIsumo(Insumo insumo) {
            insumos.Remove(insumo);
        }
    }
}

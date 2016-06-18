using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Compra : Acao{
        private List<Insumo> insumos = new List<Insumo>();

        private void AddInsumo(Insumo insumo) {
            insumos.Add(insumo);
        }

        private void RemoveIsumo(Insumo insumo) {
            insumos.Remove(insumo);
        }
    }
}

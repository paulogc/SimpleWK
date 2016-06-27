using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Compra : Acao{
        private List<InsumoAcao> insumos = new List<InsumoAcao>();

        public List<InsumoAcao> Insumos { get; set; }
        
        private void AddInsumo(InsumoAcao insumo) {
            insumos.Add(insumo);
        }

        private void RemoveIsumo(InsumoAcao insumo) {
            insumos.Remove(insumo);
        }
    }
}

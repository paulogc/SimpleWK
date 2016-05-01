using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Venda : Acao{
        private List<ProdutoFinal> produtosF = new List<ProdutoFinal>();
        
        public void AddPF(ProdutoFinal pf) {
            produtosF.Add(pf);
        } 

        public void RemovePF(ProdutoFinal pf) {
            produtosF.Remove(pf);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Venda : Acao{
        public Acao acao;
        private List<ProdutoAcao> produtos = new List<ProdutoAcao>();

        public List<ProdutoAcao> Produtos { get; set; }
    }
}

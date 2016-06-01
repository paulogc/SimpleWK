using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Acao {
        private int id;
        private String notaFiscal;
        private double valor;
        private Pessoa pessoaFJ;

        public long Id { get; set; }
        public String NotaFiscal { get; set; }
        public double Valor { get; set; }
        public Pessoa PessoaFJ;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Acao {
        private int id;
        private String notaFiscal;
        private double valor;
        private Pessoa pessoaFJ;
        private DateTime dataHora;

        public int Id { get; set; }
        public String NotaFiscal { get; set; }
        public double Valor { get; set; }
        public Pessoa PessoaFJ { get; set; }
        public DateTime DataHora { get; set;}
        }
    }
}

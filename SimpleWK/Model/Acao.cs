using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Acao {
        private int id;
        private String notaFiscal;
        private decimal valor;
        private Juridica pessoaFJ;
        private DateTime dataHora;

        public int Id { get; set; }
        public String NotaFiscal { get; set; }
        public decimal Valor { get; set; }
        public Juridica PessoaFJ { get; set; }
        public DateTime DataHora { get; set;}
        }
    
}

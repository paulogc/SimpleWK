using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Acao {
        private long id;
        private String notaFiscal;
        private String cpf;
        private String cnpj;
        private double valor;
        private String usuario;

        public long Id { get; set; }
        public String NotaFiscal { get; set; }
        public String Cpf { get; set; }
        public String Cnpj { get; set; }
        public double Valor { get; set; }
        public String Usuario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Endereco {
        private long id;
        private String rua;
        private int numero;
        private String bairro;
        private String cep;
        private String cidade;
        private String estado;
        private String pais;

        public long Id { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Pais { get; set; }
    }
}

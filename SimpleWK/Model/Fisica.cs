using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Fisica : Pessoa {
        private String sobrenome;
        private String cpf;
        private String dataNascimento;

        public String Sobrenome { get; set; }
        public String Cpf { get; set; }
        public String DataNascimento { get; set; }
    }
}
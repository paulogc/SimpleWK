using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Pessoa {
        private long id;
        private String nome;
        private String email;
        private String telefone;
        private Localizacao endereco;

        public long Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public Localizacao Endereco { get; set; }


    }
}

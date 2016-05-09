using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Juridica : Pessoa {
        private String cnpj;
        private String razaoSocial;
        
        public String Cnpj { get; set; }
        public String RazaoSocial { get; set; }
    }
}

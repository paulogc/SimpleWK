using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Usuario : Fisica {
        private String login;
        private String senha;

        public String Login { get; set; }
        public String Senha { get; set; }
    }
}

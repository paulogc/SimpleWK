using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class PessoaFisicaCtrl {
        public String getValorBusca(String valor) {
            return valor;
        }

        public String getNomeColuna(String coluna) {
            String nomeColuna = "";

            switch (coluna)
            {
                case "Nome":
                    nomeColuna = "nome";
                    break;
                case "CPF":
                    nomeColuna = "cpf";
                    break;
                case "Email":
                    nomeColuna = "email";
                    break;
            }

            return nomeColuna;
        }
    }
}

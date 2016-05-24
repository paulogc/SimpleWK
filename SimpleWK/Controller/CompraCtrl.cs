using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class CompraCtrl {
        public String getValorBusca(String valor) {
            return valor;
        }

        public String getNomeColuna(String coluna) {
            String nomeColuna = "";

            switch (coluna)
            {
                case "Nota fiscal":
                    nomeColuna = "nota_fiscal";
                    break;
                case "CPF/CNPJ":
                    nomeColuna = "cpf";
                    break;
                case "Data":
                    nomeColuna = "data";
                    break;
            }

            return nomeColuna;
        }
    }
}

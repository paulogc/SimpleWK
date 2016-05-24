﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ProdutoFinalCtrl {

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
                case "Descrição":
                    nomeColuna = "descricao";
                    break;
                case "Quantidade":
                    nomeColuna = "quantidade";
                    break;
                case "Valor final":
                    nomeColuna = "valor_final";
                    break;
                case "Valor Custo":
                    nomeColuna = "valor_custo";
                    break;
            }

            return nomeColuna;
        }

    }
}

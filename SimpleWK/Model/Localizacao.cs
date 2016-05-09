using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Localizacao {
        private long id;
        private long idPessoa;
        private String rua;
        private int numero;
        private String bairro;
        private String cep;
        private String cidade;
        private String uf;
        private String pais;
        private String complemento;


        public long Id { get; set; }
        public long IdPessoa { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Uf { get; set; }
        public String Pais { get; set; }
        public String Complemento { get; set; }
    }
}

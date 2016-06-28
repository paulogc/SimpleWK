using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model {
    public static class Validacao {

        public static bool validaNome(string nome) {
            if(Regex.Match(nome, @"^[a-zA-Z]*$").Success)
                return true;
            else
                return false;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiCadastroCliente
{
    public class PessoaJuridica : pessoa    
    {
        public int cnpj { get; set; }
        public string razaosocial { get; set; }
    }
}
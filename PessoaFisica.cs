using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiCadastroCliente
{
    public class PessoaFisica : pessoa
    {
        public string cpf { get; set; }
        public DateTime datanascimaneto { get; set; }
    }
}
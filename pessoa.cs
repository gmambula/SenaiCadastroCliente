using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiCadastroCliente
{
    public abstract class pessoa
    {
        public string nome { get; set; }
        public Endereco endereco { get; set; }
        public void Pagarimposto() {
            
        }
    }
}
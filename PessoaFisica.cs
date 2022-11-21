using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiCadastroCliente
{
    public class PessoaFisica : pessoa
    {
        public string? cpf { get; set; }
        public DateTime datanascimaneto { get; set; }
        public override float Pagarimposto(float salario)
       {
         if (salario <= 1500)
         {
            return 0;
         }
         else if (salario   > 1500 && salario <= 3500)  
         {
            return (salario / 100) * 2;
         }
         else if (salario>3500 && salario < 6000)  
         {
            return (salario / 100) * 3.5f;
         }
         else
         {
            return ( salario / 100) * 5;
         }
       }
       
    }
}
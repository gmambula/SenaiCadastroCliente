using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiCadastroCliente
{
    public class PessoaJuridica : pessoa    
    {
        public string? cnpj { get; set; }   
        public string? razaosocial { get; set; }
        public override float Pagarimposto(float salario)
        {
            if (salario <=5000)
            {
                return (salario/100)*6;
            }
            else if (salario > 5000 && salario<=10000)
            {
                return (salario/100)*8;

            }else{
                return (salario/100)*10;
            }
        }
        public bool validarCnpj(string cnpj){
            if(cnpj.Length >= 14 && cnpj.Substring(cnpj.Length -6, 4) == "0001"){
                return true;
            }else{
                return false;
            }


        }

    }
}
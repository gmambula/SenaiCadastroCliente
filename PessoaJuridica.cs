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
        public override void Pagarimposto(float salario){

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
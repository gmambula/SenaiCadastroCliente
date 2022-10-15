// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
namespace SenaiCadastroCliente
{
    class Program
    {
         static void Main(string[] args)
        {
            Endereco end = new Endereco();

            end.Logadouro = "rua x";
            end.Numero = 1234;
            end.Complemento = "casa";
            end.enderecoComercial = false;
            
            PessoaFisica pf = new PessoaFisica();

            pf.nome = "Gabriel";
            pf.endereco = end;
            pf.cpf = "12332112345";
            pf.datanascimaneto = new DateTime (1999, 01, 15);

            PessoaJuridica pj = new PessoaJuridica();

            pj.nome = "Empresax";
            pj.endereco = end;
            pj.cnpj = "12334321000399";
            pj.razaosocial = "Empresa multix LTDA";


            bool idadeValida = pf.ValidarDataNascimento(pf.datanascimaneto);
            Console.WriteLine(idadeValida);
            if (idadeValida == true)
            {
                System.Console.WriteLine($"Cadastro aprovado");
            }else
            {
                System.Console.WriteLine($"Cadastro reprovado");
            }

            pj.validarCnpj(pj.cnpj);
                if(pj.validarCnpj(pj.cnpj)){
                    Console.WriteLine("cnpj ok");
                }else{
                    Console.WriteLine("cnpj invalido");

                }

        }
        
    }
      
       
    
}


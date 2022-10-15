// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
namespace SenaiCadastroCliente
{
    class Program
    {
         static void Main(string[] args)
        {
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.BackgroundColor = ConsoleColor.White;
           Console.WriteLine(@$"
+++++++++++++++++++++++++++++++
|  Bem Vindo ao Cadastro      |
|  Pessoa Fisica e Juridica   |
+++++++++++++++++++++++++++++++ 
");
           Console.ResetColor();
           Console.WriteLine($"Iniciando");
           Thread.Sleep(500);

           for (var contador = 0; contador < 10; contador++ )
           {
                Console.ForegroundColor  = ConsoleColor.DarkRed;
                Console.Write($".");
                Thread.Sleep(500);
                Console.ResetColor();
           } 

            string? opcao;

            do
            {
                
           Console.WriteLine(@$"
+++++++++++++++++++++++++++++++
|  Escolha uma opção abaixo   |
|  1 - Pessoa Fisica          |
|  2 - Pessoa Juridica        |
|  0 - Sair                   |
+++++++++++++++++++++++++++++++ 
");

         opcao = Console.ReadLine();
           
            switch (opcao)
            {
                case "1":
                 Endereco endpf = new Endereco();

                 endpf.Logadouro = "rua x";
                 endpf.Numero = 1234;
                 endpf.Complemento = "casa";
                 endpf.enderecoComercial = false;
            
                 PessoaFisica pf = new PessoaFisica();

                 pf.nome = "Gabriel";
                 pf.endereco = endpf;
                 pf.cpf = "12332112345";
                 pf.datanascimaneto = new DateTime (1999, 01, 15);   
                 pf.salario = 7000;               
                 bool idadeValida = pf.ValidarDataNascimento(pf.datanascimaneto);
                      Console.WriteLine(idadeValida);
                        if (idadeValida == true)
                        {
                            System.Console.WriteLine($"Cadastro aprovado");
                        }else
                        {
                            System.Console.WriteLine($"Cadastro reprovado");
                        }
                    break;
                
                case "2":
                
                    PessoaJuridica pj = new PessoaJuridica();

                    Endereco endpj = new Endereco();

                     endpj.Logadouro = "rua x";
                     endpj.Numero = 1234;
                     endpj.Complemento = "casa";
                     endpj.enderecoComercial = false;

                     pj.nome = "Empresax";
                     pj.endereco = endpj;
                     pj.cnpj = "12334321000399";
                     pj.razaosocial = "Empresa multix LTDA";  
                     pj.salario = 20000;        

                     pj.validarCnpj(pj.cnpj);
                        if(pj.validarCnpj(pj.cnpj)){
                            Console.WriteLine("cnpj ok");
                        }else{
                            Console.WriteLine("cnpj invalido");

                        }
                    break;
                
                case "0":
                Console.ResetColor();
                Console.WriteLine($"Finalizando");
                Thread.Sleep(500);
                    for (var contador = 0; contador < 10; contador++ )
                      {
                        Console.ForegroundColor  = ConsoleColor.DarkRed;
                        Console.Write($".");
                        Thread.Sleep(500);
                        Console.ResetColor();
                     } 

                    break;
                default:
                    Console.WriteLine($"opção invalida, digite outra opção");
                    break;
            }
            
            } while (opcao !="0");

           


        }
        
    }
      
       
    
}


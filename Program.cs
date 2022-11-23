// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Collections.Generic;
using SenaiCadastroCliente;

namespace SenaiCadastroCliente
{
    class Program
    {
         static void Main(string[] args)
        {
           List<PessoaFisica> listPF = new List<PessoaFisica>();
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
+++++++++++++++++++++++++++++++++
|  Escolha uma opção abaixo     |
|     Pessoa Fisica             |
| 1 - Cadastrar Pessoa Fisica   |
| 2 - Listar Pessoa Fisica      |
| 3 - Remover Pessoa Fisica     |
|                               |
|     Pessoa Juridica           |    
| 4 - Cadastrar Pessoa Juridica | 
| 5 - Listar Pessoa Juridica    |
| 6 - Remover Pessoa Juridica   |
|                               |
|                               |
|  0 - Sair                     |
+++++++++++++++++++++++++++++++++ 
");

         opcao = Console.ReadLine();
           
            switch (opcao)
            {
                case "1":
                 Endereco endpf = new Endereco();
                 
                 Console.WriteLine($"Digite seu Logadouro");
                 endpf.Logadouro = Console.ReadLine();
                    
                 Console.WriteLine($"Digite seu Logadouro");
                 endpf.Numero = int.Parse(Console.ReadLine());
                    
                 Console.WriteLine($"Digite seu Complemento (aperte ENTER para vazio");
                 endpf.Complemento = Console.ReadLine();
                    
                 Console.WriteLine($"Este endereço é comercial? S/N");
                 string enderecoComercial =  Console.ReadLine().ToUpper();
                    if (enderecoComercial == "S"){
                        endpf.endComercial = true;
                    }else{
                     endpf.endComercial = false;
                    }

                 

                    
            
                 PessoaFisica pf = new PessoaFisica();

                                 
                    Console.WriteLine($"Digite seu CPF");
                    pf.cpf = Console.ReadLine();

                    Console.WriteLine($"Digite seu nome");
                    pf.nome = Console.ReadLine();
                    
                    Console.WriteLine($"Digite sua data de nascimento");
                    pf.datanascimaneto =  DateTime.Parse(Console.ReadLine());
                    

                 bool idadeValida = pf.ValidarDataNascimento(pf.datanascimaneto);
                      Console.WriteLine(idadeValida);
                        if (idadeValida == true)
                        {
                            System.Console.WriteLine($"Cadastro aprovado");
                            listPF.Add(pf);
                            Console.WriteLine(pf.Pagarimposto(pf.salario));
                            pf.GravarRegistro();
                        }else
                        {
                            System.Console.WriteLine($"Cadastro reprovado");
                        }
                    break;
                
                case "2":
                    foreach (var cadaItem in listPF)
                    {
                        Console.WriteLine($"{cadaItem.nome},{cadaItem.cpf},{cadaItem.datanascimaneto}");
                    }

                    break;

                case "3":
                    System.Console.WriteLine($"Digite o CPF que deseja remover");
                    string? cpfProcurado = Console.ReadLine();
                    PessoaFisica pessoaEncontrada = listPF.Find(cadaItem => cadaItem.cpf == cpfProcurado);
                    if (pessoaEncontrada != null)
                    {
                       listPF.Remove(pessoaEncontrada);
                       Console.WriteLine($"pessoa removida"); 
                    }
                    else
                    {
                        Console.WriteLine($"CPF não encontrado");
                    }
                    break;    

                case "4":
                
                    PessoaJuridica pj = new PessoaJuridica();

                    Endereco endpj = new Endereco();

                     endpj.Logadouro = "rua x";
                     endpj.Numero = 1234;
                     endpj.Complemento = "casa";
                     endpj.endComercial = false;

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
       
       public bool ValidarDataNascimento(DateTime datanascimento)
       {
         DateTime dataAtual = DateTime.Today;
         
         double anos = ( dataAtual - datanascimaneto).TotalDays / 365;
         if (anos >= 18)
         {
            return true;
         }
         else
         {
            return false;
         }
       }
       public override bool GravarRegistro();{
         string cArqPF = AppDomain.CurrentDomain.BaseDirectory+"\\arquivos\\PF.txt";
         var sStream = new StreamWriter(cArqPF,true);

         sStrem.WriteLine($" Cadastrado: {this.CPF}  -  Nome: {this.Nome}");
         sStream.Close();

         Console.WriteLine($"Conteudo de log do arquivo PF.txt");

         using ( var = sReder = new StreamReader(cArqPF)){


        string cLine;
            while ((cLine = sReder.ReadLine()) != null)
            {
               Console.WriteLine(cLine);
            }
         }
          return true;

       }

       
    }
}
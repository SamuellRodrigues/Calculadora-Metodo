using Layout;
namespace Calculadora
{
   class Operacoes
   {
      public static decimal ObterValores1()
      {
      repetir:
         Formatacao.Cor("Informer o primeiro valor :", ConsoleColor.Blue);


         if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
         {
            Formatacao.Cor("Valor invalido!", ConsoleColor.Red);
            goto repetir;
         }
         else
         {
            return valor;
         }

      }

      public static string ObterSinal()
      {

         Formatacao.Cor("Insira a operação que deseja fazer ( +, -, *, /): ", ConsoleColor.Magenta);

         string sinal = Console.ReadLine();
         return sinal;




      }



      public static decimal ObterValores2()
      {
      repetir:
         Formatacao.Cor("Informer o segundo valor :", ConsoleColor.Blue);


         if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
         {
            Formatacao.Cor("Valor invalido!", ConsoleColor.Red);
            goto repetir;
         }
         else
         {
            return valor;
         }

      }








      public static void RealizarAdicao(decimal var1, string sinal, decimal var3)
      {
         decimal resposta = 0;

         switch (sinal)
         {
            case "+":
               resposta = var1 + var3;
               break;
            case "-":
               resposta = var1 - var3;
               break;
            case "*":
               resposta = var1 * var3;
               break;
            case "/":
               if (var3!= 0)
               {
                  resposta = var1 / var3;
               }
              else
    {
        Formatacao.Cor("Erro: Não é possível dividir por zero!", ConsoleColor.Red);
        return;
    }
    break;

         }
         
         string respostaTexto = $"A operação {var1} {sinal} {var3} = {resposta}";
         AdicionarLinhaBorda(respostaTexto); 
      }

      
      public static void AdicionarLinhaBorda(string texto)
      {
         
         int largura = texto.Length + 4; 

         
         int consoleLargura = Console.WindowWidth;

         
         int espacos = (consoleLargura - largura) / 2;

         
         Console.WriteLine(new string(' ', espacos) + new string('-', largura)); 
         Console.WriteLine(new string(' ', espacos) + $" {texto} "); 
         Console.WriteLine(new string(' ', espacos) + new string('-', largura)); 
      }
   }
}
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

         Formatacao.Cor("Insira a operação que deseja fazer ( +, -, *, /): ", ConsoleColor.Yellow);

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
               break;

         }
         {
               
            Formatacao.Cor($"A soma dos valores {var1} {sinal} {var3} = {resposta}",ConsoleColor.Green);
         }

      }

   }
}

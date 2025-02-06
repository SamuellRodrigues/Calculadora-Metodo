namespace Calculadora
{
   class Operacoes
   {
      public static decimal ObterValores1()
      {
      repetir:
         Console.Write("Informer o primeiro valor :");


         if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
         {
            Console.WriteLine("Valor invalido!");
            goto repetir;
         }
         else
         {
            return valor;
         }

      }

      public static string ObterSinal()
      {

         Console.Write("Insira a operação que deseja fazer ( +, -, *, /): ");

         string sinal = Console.ReadLine();
         return sinal;




      }



      public static decimal ObterValores2()
      {
      repetir:
         Console.Write("Informer o segundo valor :");


         if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
         {
            Console.WriteLine("Valor invalido!");
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
            Console.WriteLine($"A soma dos valores {var1} {sinal} {var3} = {resposta}");
         }

      }

   }
}
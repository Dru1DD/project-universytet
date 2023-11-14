using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Start programu");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Równianie № {i}");
          
            double oaa = GetUserInput("Wprowadz a:");
            double oab = GetUserInput("Wprowadz b:");
            double oac = GetUserInput("Wprowadz c: ");

            double oax1 = 0, oax2 = 0;

            if (oaa == 0)
            {
                oax1 = -oac / oab;
                Console.WriteLine("Równanie jest liniowe");
                Console.WriteLine($"Równanie ma jedno rozwiązanie x = {oax1} ");
            }
            else
            {
                double oa_delta = (oab * oab) - (4 * oaa * oac);
                if (oa_delta < 0)
                {
                    Console.WriteLine("Równianie nie ma rozwiązań");
                    Console.WriteLine("Delta jest ujemna");
                }
                else
                {
                    double pierwiastek = Math.Sqrt(oa_delta);
                  
                    oax1 = (-oab - pierwiastek) / (2 * oaa);
                    oax2 = (-oab + pierwiastek) / (2 * oaa);
                  
                    Console.WriteLine("Równanie jest kwadratowe");
                    Console.WriteLine($"Równanie ma 2 rozwiązania: x1 - {oax1}, x2 - {oax2}");
                }
            }
        }


      static double GetUserInput(string prompt)
      {
          double result;
          bool isValidInput;

          do
          {
              Console.Write(prompt);
              isValidInput = double.TryParse(Console.ReadLine(), out result);

              if (!isValidInput)
                  Console.WriteLine("Liczba nie jest rzeczywista");

          } while (!isValidInput);

          return result;
      }

    }
}

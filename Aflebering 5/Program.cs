using System.Diagnostics;

namespace Aflebering_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduktion med tastatureffekt
            SkrivSomTastatur("Velkommen til FizzBuzz spillet!");
            SkrivSomTastatur("Spillet vil foreslå et tal, og du skal gætte, om det er 'Fizz', 'Buzz' eller 'FizzBuzz'.");
            SkrivSomTastatur("Skriv 'Fizz' hvis tallet er deleligt med 3, 'Buzz' hvis det er deleligt med 5, og 'FizzBuzz' hvis det er deleligt med både 3 og 5.");
            SkrivSomTastatur("Skriv selve tallet hvis ingen af disse regler gælder.");

            int maxTal = 100;

            for (int i = 1; i <= maxTal; i++)
            {
                Console.WriteLine($"Tal: {i}");
                Console.Write("Dit svar (Fizz, Buzz, FizzBuzz eller tallet): ");
                string brugerSvar = Console.ReadLine();

                // Find det korrekte svar baseret på FizzBuzz-reglerne ved hjælp af if-else statements
                string korrektSvar;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    korrektSvar = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    korrektSvar = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    korrektSvar = "Buzz";
                }
                else
                {
                    korrektSvar = i.ToString();
                }

                // Tjek om brugerens svar er korrekt
                if (brugerSvar.Equals(korrektSvar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Korrekt!");
                }
                else
                {
                    Console.WriteLine($"Forkert! Det korrekte svar var: {korrektSvar}");
                    Console.WriteLine("Spillet starter forfra.\n");
                    i = 0; // Reset spillet tilbage til første tal
                }
            }

            Console.WriteLine("Tillykke! Du har gennemført alle 100 tal korrekt.");
        }


        //Tyvestjålet fra ChatGPT, syntes det kunne være lidt sejt at få den til at "udskrive"
        static void SkrivSomTastatur(string tekst)
        {
            foreach (char bogstav in tekst)
            {
                Console.Write(bogstav);
                Thread.Sleep(50); // Forsinkelse pr. bogstav i millisekunder
            }
            Console.WriteLine();
        }
    }
}
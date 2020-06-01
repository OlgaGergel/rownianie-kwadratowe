using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwiastek_kwadratowy
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

                Console.WriteLine("Ten program oblicza pierwiastek kwatratowy");
                Console.Write("Prosze podac wspolczynik a: ");

                a = Funkcje.PobierzLiczby();

                Console.Write("Prosze podac wspolczynik b: ");
               
                b = Funkcje.PobierzLiczby();

                Console.Write("Prosze podac wspolczynik c: ");
                
                c = Funkcje.PobierzLiczby();

                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Pierwiastek x1={x1:F2} ");
                    Console.WriteLine($"Pierwiastek x2={x2:F2} ");             

                }
                else if(delta == 0)
                {
                    x1 = (-b / 2 * a);
                    Console.WriteLine($"Pierwiastek x1={x1:F2} ");
                }
                else 
                {
                    Console.WriteLine("Brak rozwązania");
                }
            Console.ReadKey();
        }
    }
}

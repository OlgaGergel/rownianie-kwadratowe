using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwiastek_kwadratowy
{
    public class Funkcje
    {
        public static double PobierzLiczby()
        {
            double liczba = 0;
            bool sukces;
            do
            {
                try
                {
                    liczba = double.Parse(Console.ReadLine());
                    sukces = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("To nie liczba");
                    sukces = false;
                }
            } while (!sukces);
            return liczba;
        
        }



    }
}

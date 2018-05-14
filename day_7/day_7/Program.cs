using System;

namespace day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ReizTabula();

            /*  FOR FUNKCIJAS PIEMERS
             **/ 
           

            /*
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
                
            }
            */
            Console.ReadLine();
        }

        static void ReizTabula()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }

        }
    }

}

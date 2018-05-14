using System;

namespace day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ReizTabula();

            /*  FOR FUNKCIJAS PIEMERS
             **/


            /*
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
                
            }
            */
            Console.WriteLine("Ievadiet skaitli: ");

            string konv = Console.ReadLine();
            int ievade = Convert.ToInt16(konv);
            int rez = 0;

            for (int i = 0; i <= ievade; i++)
            {
                rez = rez + i;
                Console.WriteLine(rez);

            }


            Console.ReadLine();
        }

        /*
        static void ReizTabula()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }
            */

        static void Zvaigzne( )
        {
            string zvaigzne = "";
            for (int i = 1; i < 4; i++)
            {
                zvaigzne = zvaigzne + "*";
                Console.WriteLine(zvaigzne);
            }
                

            
        }
    }
}

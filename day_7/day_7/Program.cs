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
            Zvaigzne();


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

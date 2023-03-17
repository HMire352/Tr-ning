using System;
namespace Träning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du?");
            int ålder = int .Parse(Console.ReadLine());

            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig");
            }
            else
            {
                Console.WriteLine("Du är inte myndig än");          
            }
        }       
            

        
    }
}
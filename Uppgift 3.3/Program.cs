using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? : ");
            string svar = Console.ReadLine();
            string namn = svar.ToLower(); 
            
            if (namn == "stig")
            {
                Console.WriteLine("Du har namnsdag idag :D ");
            } 

            else if (namn == "abraham")
            {
                Console.WriteLine("Du har namnsdag imorgon :D");
            }

            else
            {
                Console.WriteLine("Du har inte namnsdag idag eller imorgon :(");
            }


        }
    }
}

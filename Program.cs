//dotnet build
//dotnet run

using System;

namespace Anw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein: ");
            
            try{
                int i = Convert.ToInt32(Console.ReadLine());
                if(i >= 0){
                Console.WriteLine(algorythm.crossSum(i));      
                }
                elses
            }
            catch(FormatException){
                Console.WriteLine("Keine gültige Zahl eingegeben. Starte das Programm neu!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Deine Zahl ist zu lang. Starte das Programm neu!");
            }           

        }
    }
}

using System;

namespace MyApp
{
    internal class First
    {

        static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            string res = IntegerOrNot(temperature);
            int temperatureAsInt;

            if (res != "1")
            {
                Console.WriteLine(res);
                
            }
            else
            {
                temperatureAsInt = int.Parse(temperature);
                Matter(temperatureAsInt);
            }

            

            Console.Read();
        }
        private static string IntegerOrNot(string temperature)
        {
            int result;
            string res = int.TryParse(temperature,out result) ? "1" : "Not a Valid Number!";
            
            return res;      
        }

        private static void Matter(int temperature)
        {
            string resMatter = temperature <= 15 ? "it is too cold here" : temperature <= 28 ? "it is ok" : "it is hot here"; 
            Console.WriteLine(resMatter);
        }
       
        
    }
}

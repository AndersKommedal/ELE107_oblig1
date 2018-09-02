using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Temperaturmaaler temp = new Temperaturmaaler();
            for (int i = 0; i < 10; i++)
            {
                temp.Maal();
                Console.WriteLine("Temp: " + temp.Temperatur);
                
            }
                
            
            Console.WriteLine("Trykk en tast for å avslutte...");
            Console.ReadKey();
        }
    }
}

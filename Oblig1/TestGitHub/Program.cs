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
            int antallSensorer = 10;
            I_Sensor[] sensorTabell = new I_Sensor[antallSensorer];
            
            for (int i = 0; i < antallSensorer; i++) // Legger til temperaturmålere i første halvdel av tabellen, og trykkmålere i andre halvdel
            {
                if(i < antallSensorer/2) sensorTabell[i] = new Temperaturmaaler(i + 1);
                else sensorTabell[i] = new Trykkmaaler(i + 1);

            }

            for (int i = 0; i < antallSensorer / 2; i++) //Setter posisjonene for tempsensorene.
            {
                sensorTabell[i].PosisjonX = 1;
                sensorTabell[i].PosisjonY = i + 1;
            }

            int trykkPosX = 1;
            for (int i = antallSensorer / 2; i < antallSensorer; i++) //Setter posisjonene for trykksensorene.
            {

                sensorTabell[i].PosisjonX = (trykkPosX);
                sensorTabell[i].PosisjonY = 1;
                trykkPosX += 2;
            }

            foreach (I_Sensor sens in sensorTabell) //Setter måleverdi for temp- og trykkmålerne.
            {
                if (sens is Temperaturmaaler)
                {
                    Temperaturmaaler temp = sens as Temperaturmaaler;
                    temp.Maal();
                }

                if (sens is Trykkmaaler)
                {
                    Trykkmaaler trykk = sens as Trykkmaaler;
                    trykk.Maal();
                }

            }

            for (int i = 0; i < antallSensorer; i++)
            {
                Console.WriteLine(sensorTabell[i]);
            }


            Console.WriteLine("Trykk en tast for å avslutte...");
            Console.ReadKey();
        }
    }
}

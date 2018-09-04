using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Temperaturmaaler : I_Sensor
    {
        double posisjonX, posisjonY, temperatur;
        int id;
        static Random rand = new Random();

        public Temperaturmaaler()
        {
            posisjonX = 0;
            posisjonY = 0;
            id = 0;
            temperatur = 0;
        }

        public Temperaturmaaler(int InitId)
        {
            id = InitId;
            posisjonX = 0;
            posisjonY = 0;
            temperatur = 0;
        }

        public double PosisjonX // Dersom verdien settes utenfor kravene, vil den settes til den nærmeste lovlige verdien.
        {
            get { return posisjonX; }
            set
            {
                if (posisjonX < -180) posisjonX = -180;
                else if (posisjonX > 179) posisjonX = 179;
                else posisjonX = value;
            }
        }

        public double PosisjonY // Dersom verdien settes utenfor kravene, vil den settes til den nærmeste lovlige verdien.
        {
            get { return posisjonY; }
            set
            {
                if (posisjonY < -90) posisjonY = -90;
                else if (posisjonY > 90) posisjonY = 90;
                else posisjonY = value;
            }
        }

        public double Temperatur //Temperatur i Kelvin
        {
            get { return temperatur; }
            set { temperatur = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public void Maal() //Returnerer et flyttall mellom 0 og 1273,1
        {
            
            temperatur = rand.Next(0, 12732) / 10.0;
        }

        public override string ToString()
        {
            return Id + " - (" + PosisjonX + ", " + PosisjonY + ") - Måleverdi: " + Temperatur;
        }

    }
}

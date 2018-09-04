using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    
    class Trykkmaaler : I_Sensor
    {
        static Random rand = new Random();
        double posisjonX, posisjonY, trykk;
        int id;
        public Trykkmaaler()
        {
            posisjonX = 0;
            posisjonY = 0;
            id = 0;
            trykk = 0;
        }

        public Trykkmaaler(int InitId)
        {
            id = InitId;
            posisjonX = 0;
            posisjonY = 0;
            trykk = 0;
        }
        public double PosisjonX
        {
            get { return posisjonX; }
            set
            {
                if (posisjonX < -180) posisjonX = -180;
                else if (posisjonX > 179) posisjonX = 179;
                else posisjonX = value;
            }
        }
        public double PosisjonY
        {
            get { return posisjonY; }
            set
            {
                if (posisjonY < -90) posisjonY = -90;
                else if (posisjonY > 90) posisjonY = 90;
                else posisjonY = value;
            }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Trykk 
        {
            get { return trykk; }
            set { trykk = value; }
        }

        public void Maal() //Returnerer et flyttall mellom 0 og 2,5
        {
            trykk = rand.Next(0, 26) / 10.0;
        }
        public override string ToString()
        {
            return Id + " - (" + PosisjonX + ", " + PosisjonY + ") - Måleverdi: " + Trykk;
        }
    }
}

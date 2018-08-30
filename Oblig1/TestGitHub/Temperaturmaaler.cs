using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Temperaturmaaler : I_Sensor
    {
        double posisjonX, posisjonY;
        public double PosisjonX
        {
            get;
            set;
        }

        public double PosisjonY
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public void Maal()
        {

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    interface I_Sensor
    {

        double PosisjonX
        {
            get;
            set;
        }
        double PosisjonY
        {
            get;
            set;
        }
        int Id
        {
            get;
        }

   
        void Maal();
        string ToString();


    }
}

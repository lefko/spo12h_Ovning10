﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning10
{
    public class PlasticBicycle : Bicycle // , IDriveable
    {
        override public void Drive()
        {
            Console.WriteLine("Plasten smälter");
        }
    }
}

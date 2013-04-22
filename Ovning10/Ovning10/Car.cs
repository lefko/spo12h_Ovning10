using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning10
{
    public class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Car drives.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning10
{
    public class Bicycle : IDriveable
    {
        virtual public void Drive()
        {
            Console.WriteLine("Bike is riding.");
        }
    }
}

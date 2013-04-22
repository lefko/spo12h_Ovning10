using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning10
{
    class Program
    {
        static void Main(string[] args)
        {
            IDriveable[] vehicles = new IDriveable[3];
            vehicles[0] = new Car();
            vehicles[1] = new Bicycle();
            vehicles[2] = new PlasticBicycle();
            Car c;
            Bicycle b;
            PlasticBicycle pB;
            bool check;

            foreach (IDriveable i in vehicles)
            {
                //if (i is Car)
                //{
                //    i.Drive();
                //    //c = (Car)i;
                //    //c.Drive();
                //}
                //else if (i is Bicycle)
                //{
                //    i.Drive();
                //    //b = (Bicycle)i;
                //    //b.Drive();
                //}

                //if (i is PlasticBicycle)
                //{
                //    //check = i as PlasticBicycle;
                //    //if(check)
                //    //    pB.Drive();
                //    pB = (PlasticBicycle)i;
                //}

                i.Drive();


            }


            Console.ReadLine();
        }
    }
}

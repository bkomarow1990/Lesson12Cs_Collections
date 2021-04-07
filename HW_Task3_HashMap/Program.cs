using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW_Task3_HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto(Auto.Type.Car,"BMW",1990);
            Auto bogdan = new Auto(Auto.Type.Bus,"BogdanBus",2012);
            Auto lorry = new Auto(Auto.Type.Lorry,"KAMAZ",2007);
            HashSet<Auto> parkingKiev = new HashSet<Auto> { bmw, bogdan };
            parkingKiev.Add(lorry);
            HashSet<Auto> parkingLondon = new HashSet<Auto> { bmw, new Auto(Auto.Type.Car,"Bentley",2016), new Auto(Auto.Type.Bus, "DoubleDeckerBus",2012) };
            Console.WriteLine("======================================================");
            Console.WriteLine("Parking Kiev:");
            foreach (Auto item in parkingKiev)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("Parking London:");
            foreach (Auto item in parkingLondon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("Now, need to get same Autos is Parking Kiev: ");
            parkingKiev.IntersectWith(parkingLondon);
            foreach (Auto item in parkingKiev)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("All Autos in CarPark: ");
            HashSet<Auto> parkings = new HashSet<Auto>(parkingLondon.Union(parkingKiev));
            foreach (Auto item in parkings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("Deleting BMW from London Parking: ");
            parkingLondon.ExceptWith(parkingKiev);
            foreach (Auto item in parkingLondon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("Deleting auto with name Bentley from London Parking: ");
            parkingLondon.RemoveWhere(e => e.Name.Equals("Bentley"));
            foreach (Auto item in parkingLondon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================");
        }
    }
}

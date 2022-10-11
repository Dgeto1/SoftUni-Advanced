using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string tir;
            while((tir = Console.ReadLine())!="No more tires")
            {
                string[] segments = tir.Split();
                double sum = 0;
                Tire tire = new Tire(int.Parse(segments[0]), double.Parse(segments[1]), sum += double.Parse(segments[1]));
                tires.Add(tire);
            }
            string eng;
            while((eng = Console.ReadLine())!="Engines done")
            {
                string[] segments = eng.Split();
                Engine engine = new Engine(int.Parse(segments[0]), double.Parse(segments[1]));
                engines.Add(engine);
            }
            string cr;
            while((cr = Console.ReadLine())!="Show special")
            {
                string[] segments = cr.Split();
                Car car = new Car(segments[0], segments[1], int.Parse(segments[2]), double.Parse(segments[3]), double.Parse(segments[4]), engines[int.Parse(segments[5])], tires[int.Parse(segments[6])]);
                cars.Add(car);
            }

            double sumTiresPressure = 0;
            foreach(Tire x in tires)
            {
                sumTiresPressure += x.Pressure;
            }

            foreach(Car x in cars)
            {
                if(x.Year>=2017 && x.Engine.HorsePower>330 && x.Tires.Sum>=9 && x.Tires.Sum<=10)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            Console.Read();
        }
    }
}


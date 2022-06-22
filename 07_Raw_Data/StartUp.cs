using System;
using System.Collections.Generic;

namespace _07_Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for(int i = 0; i < n; i ++)
            {
                string text = Console.ReadLine();
                string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = words[0];
                int engSpd = int.Parse(words[1]);
                int engPow = int.Parse(words[2]);
                int crgWght = int.Parse(words[3]);
                string crgType = words[4];
                double t1 = double.Parse(words[5]);
                int ty1 = int.Parse(words[6]);
                double t2 = double.Parse(words[7]);
                int ty2 = int.Parse(words[8]);
                double t3 = double.Parse(words[9]);
                int ty3 = int.Parse(words[10]);
                double t4 = double.Parse(words[11]);
                int ty4 = int.Parse(words[12]);

                Engine eng = new Engine(engSpd, engPow);
                Cargo bagaj = new Cargo(crgType, crgWght);
                Tyres tyre1 = new Tyres(ty1, t1);
                Tyres tyre2 = new Tyres(ty2, t2);
                Tyres tyre3 = new Tyres(ty3, t3);
                Tyres tyre4 = new Tyres(ty4, t4);
                Car car = new Car(model, eng, bagaj, tyre1, tyre2, tyre3, tyre4);
                carsList.Add(car);
            }

            string cmnd = Console.ReadLine();
            List<Car> expectedCars = new List<Car>();
            foreach(Car car in carsList)
            {
                if(car.Bagaj.Vid== "fragile")
                {
                    if(car.Guma1.Preassure < 1 || car.Guma2.Preassure < 1 || car.Guma3.Preassure < 1 || car.Guma4.Preassure < 1)
                    {
                        expectedCars.Add(car);
                    }
                }
                else if (car.Bagaj.Vid == "flammable")
                {
                    if (car.Dvigatel.Power > 250)
                    {
                        expectedCars.Add(car);
                    }
                }
            }

            foreach(Car car in expectedCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}

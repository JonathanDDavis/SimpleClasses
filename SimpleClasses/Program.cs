using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            /*myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine(" {0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}" , value);

            Console.WriteLine(" {0:C}" , myCar.DetermineMarketValue());

            Console.ReadLine();

        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            Someday I might look up the car
            online webservice to get more
            accurate value.
            return carValue;
        }*/
            Car myOtherCar;
            myOtherCar = myCar;

            myOtherCar = null;

            Console.Write("(0) (1) (2) (3)",
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myCar = null;

            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
             Make = "Nison";
        }

        /*public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;

            else
                carValue = 2000;

            return carValue;

        }*/

    }
}

using System;

namespace TheCoffeeMachine
{
    class Program
    {
        private const int Volume = 250;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CoffeePowder coffe = new CoffeePowder(1000);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(300);
            
            CoffeeMachine yummyCoffe = new CoffeeMachine(coffe, water, milk);

            //1st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //2nd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //3rd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //4th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //5th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //6th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result"+result);

            //1st cup capucino
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCapucino();
            Console.WriteLine("result" + result);


            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}

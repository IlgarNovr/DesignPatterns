using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder_Singleton.Builder
{
    class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder(Car car)
        {
            _car = car;
        }

        public Car GetResult()
        {
            return _car;
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(int engine)
        {
            _car.Engine = engine;
        }

        public void SetGps()
        {
            Console.WriteLine("GPS");
        }

        public void SetSeats(int number)
        {
            _car.Seats = number;
        }

        public void SetTripComputer()
        {
            Console.WriteLine("Computer");
        }
    }
}
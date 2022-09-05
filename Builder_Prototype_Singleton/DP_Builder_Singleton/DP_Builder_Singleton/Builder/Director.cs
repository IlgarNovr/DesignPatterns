using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder_Singleton.Builder
{
    class Director
    {
        public void MakeSuv(IBuilder builder)
        {
            builder.Reset();
            builder.SetEngine(1);
            builder.SetSeats(1);
            builder.SetGps();
            builder.SetTripComputer();
        }
        public void MakeSportCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetEngine(2);
            builder.SetSeats(2);
            builder.SetGps();
        }
    }
}
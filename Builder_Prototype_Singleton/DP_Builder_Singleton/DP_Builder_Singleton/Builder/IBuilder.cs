using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder_Singleton.Builder
{
    interface IBuilder
    {
    void Reset();

    void SetSeats(int number);

    void SetEngine(int engine);

    void SetTripComputer();

    void SetGps();
    }
}

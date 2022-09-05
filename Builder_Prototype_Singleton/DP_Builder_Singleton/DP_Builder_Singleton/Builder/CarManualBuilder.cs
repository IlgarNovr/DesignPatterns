using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder_Singleton.Builder
{
    class CarManualBuilder : IBuilder
    {

        private Manual _manual;

        public CarManualBuilder(Manual manual)
        {
            _manual = manual;
        }
        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetEngine(int engine)
        {
            throw new NotImplementedException();
        }

        public void SetGps()
        {
            throw new NotImplementedException();
        }

        public void SetSeats(int number)
        {
            throw new NotImplementedException();
        }

        public void SetTripComputer()
        {
            throw new NotImplementedException();
        }
    }
}
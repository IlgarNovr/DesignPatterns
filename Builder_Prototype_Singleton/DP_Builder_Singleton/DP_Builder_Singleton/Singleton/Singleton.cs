using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder_Singleton.Singleton
{
    class Singleton
    {
        private Singleton _singleton;

        private Singleton()
        {
        }

        public Singleton GetSingleton()
        {
            if (_singleton == null)
                _singleton = new Singleton();

            return _singleton;
        }
    }
}

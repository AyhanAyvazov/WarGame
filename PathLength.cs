using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class PathLength
    {
        private readonly int Pathlength = 10;
        // I counted each paths and i founded 10. We can't set path length so i wrote readonly.
        public int pathlength
        {
            get { return Pathlength; }
        }

    }
}

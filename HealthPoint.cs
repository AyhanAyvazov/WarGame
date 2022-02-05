using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public static class HealthPoint
    {
        //I created static class. Because static class is easy for working.(For my opinion :D). 
        public static int AddHealthPoint(ref int health)
        {
            health += 70;  
            return health;
            
        }
    }
}

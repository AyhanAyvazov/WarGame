using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public interface  ISoldierDetails
    {
        //Soldier details.
         int Health { get; set; }
         int AttDMG { get; set; }
         int AttRange { get; set; }
         bool CanDamage { get; set; }
         bool CanTakeDamage { get; set; }

    }
}

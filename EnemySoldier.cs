using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class EnemySoldiers : ISoldierDetails
    {
        // This is the class which we can see EnenmySoldier properties. Properties implemented from ISoldierDeatails.
        private int health = 100;
        private int attDMG = 15;
        private int attRange = 10;
        private bool canDamage = true;
        private bool canTakeDamage = true;


        //I wrote these poperties. Above, you can see properties which are private. I did this for code(variables) security. My friend told me you dont need to write these. But i am not sure. :d
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int AttDMG
        {
            get { return attDMG; }
            set { attDMG = value; }
        }
        public int AttRange
        {
            get { return attRange; }
            set { attRange = value; }
        }
        public bool CanDamage
        {
            get { return canDamage; }
            set { canDamage = value; }
        }
        public bool CanTakeDamage
        {
            get { return canTakeDamage; }
            set { canTakeDamage = value; }
        }
    }
}

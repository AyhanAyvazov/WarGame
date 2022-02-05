
namespace WarGame
{
   
    public class MainBase
    {
        
        public static void Main(string[] args)
        {
            Random random = new Random(); // we know that soldiers' attack and health points are randomly. For that, i have created rnadom variable.

            OurPlayer ourPlayer = new OurPlayer() { Health = random.Next(50, 100), Name = "Ayhan", AttDMG = random.Next(50, 100), AttRange = 1, CanDamage = true, CanTakeDamage = true };
            int ourPlayerHealth = ourPlayer.Health;  // I have created this, because ourPlayer.Health is property and we can't write properties in the function argument with ref.
            //so i did this trick.

            Bowman bowman = new Bowman() { Health = random.Next(50, 100), AttDMG = random.Next(50, 100), AttRange = 3, CanDamage = true, CanTakeDamage = true };
            EnemySoldiers enemySoldier1 = new EnemySoldiers() { Health = random.Next(50, 100), AttDMG = random.Next(50, 100), AttRange = 1, CanDamage = true, CanTakeDamage = true };
            EnemySoldiers enemySoldier2 = new EnemySoldiers() { Health = random.Next(50, 100), AttDMG = random.Next(50, 100), AttRange = 1, CanDamage = true, CanTakeDamage = true };

            PathLength pathLength = new PathLength();
            int path = pathLength.pathlength;  // pathLength.pathlength is too long. Working with path is much better :d

           
            //I know below codes are so amateur. My friends told me you should write with Generics. But i hadn't got any idea for this. So, i have created this spagetti code block :)
            while (path!=0  /*ourPlayerHealth != 0*/)
            {
                if (path == 10)
                {
                    Console.WriteLine($"Player health : {ourPlayerHealth}\nPlayer damage: {ourPlayer.AttDMG}\n");
                    Console.WriteLine("You are in the first attempt. Lets go!");
                }
                if (path == 9)
                {
                    Console.WriteLine("You are in the second attempt. You picked +50 health point");
                    HealthPoint.AddHealthPoint(ref ourPlayerHealth);
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                    
                }
                if (path == 8)
                {
                    Console.WriteLine("You are in the third attempt. In the way there is a enemy!");
                    while ( enemySoldier1.Health >= 0)
                    {
                        Console.WriteLine($"Enemy health :{enemySoldier1.Health}\t Enemy damage :{enemySoldier1.AttDMG}");
                        Console.WriteLine("You attacked enemy");
                        enemySoldier1.Health -= ourPlayer.AttDMG;
                        if (!(enemySoldier1.Health >= 0))
                        {
                            Console.WriteLine("Enemy still alive,now enemy attacks, you received " +enemySoldier1.AttDMG + "damage");
                            ourPlayerHealth -= enemySoldier1.AttDMG;
                        }                      
                    }
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");

                }
                if (path == 7)
                {
                    Console.WriteLine("You are in the fourth attempt. You picked +70 health point");
                    HealthPoint.AddHealthPoint(ref ourPlayerHealth);
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                    
                }
                if (path == 6)
                {
                    Console.WriteLine("You are in the fifth attempt. You are int Bowman's range. He can attack you but you can't!");
                    ourPlayerHealth -= bowman.AttDMG;
                    Console.WriteLine("You received " + bowman.AttDMG + " damage!");
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                    
                }
                if (path == 5)
                {
                    Console.WriteLine("You are in the sixth attempt. Now, you can attack to Bowman, but he can't!");
                    while (bowman.Health <= 0)
                    {
                        bowman.Health -= ourPlayer.AttDMG;
                    }
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                   
                }
                if (path == 4)
                {
                    Console.WriteLine("You are in the seventh attempt. You are in the Bowman's range. But he dead, sou yu can pass this path clearly");
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                    
                }
                if (path == 3)
                {
                    Console.WriteLine("You are in the eigth attempt. There is no enemy. You can go easily");
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                    
                }
                if (path == 2)
                {
                    Console.WriteLine("You are in the nineth attempt. In the way there is a enemy!");
                    while (enemySoldier2.Health >= 0)
                    {
                        Console.WriteLine($"Enemy health :{enemySoldier2.Health}\t Enemy damage :{enemySoldier2.AttDMG}");
                        Console.WriteLine("You attacked enemy");
                        enemySoldier2.Health -= ourPlayer.AttDMG;
                        if (!(enemySoldier2.Health >= 0))
                        {
                            Console.WriteLine("Enemy still alive,now enemy attacks, you received " + enemySoldier2.AttDMG + "damage");
                            ourPlayerHealth -= enemySoldier2.AttDMG;
                        }
                    }
                    
                    Console.WriteLine($"Player health : {ourPlayerHealth}\n");
                }
                if (path == 1)
                {
                    if (ourPlayerHealth <= 0)
                    {
                        Console.WriteLine("You died :(");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you arriwed to castle");
                    }
                    
                }
               
                path -= 1;

            }
        }
    }
}
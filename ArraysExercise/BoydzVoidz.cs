using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class BoydzVoidz
    {
        public void ReverseOrder(int[] array)
        {
            for (int it = 5; it > 0; it--)
            {
                Console.WriteLine(array[it - 1]);
            }
        }
        public void CountDown()
        {
            int[] theArray = new int[10];
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = 10 - i;
                Console.WriteLine(theArray[i]);
            }
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void Reverse()
        {
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Entry #" + (i + 1) + " >");
                int.TryParse(Console.ReadLine(),out int checkDisOut);
                userArray[i] = checkDisOut;
            }
            Console.WriteLine("The console will now begin to list your array values in reverse order.");
            Console.ReadKey();
            Console.Clear();
            ReverseOrder(userArray);
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void SmallestLargest()
        {
            int[] peepee = new int[10];
            int[] biggiesmalls = new int[2] { 9999999, -9999999 };
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Gimme a number, kid! >");
                int.TryParse(Console.ReadLine(), out peepee[i]);
                if (biggiesmalls[0] > peepee[i])
                {
                    biggiesmalls[0] = peepee[i];
                }
                if (biggiesmalls[1] < peepee[i])
                {
                    biggiesmalls[1] = peepee[i];
                }
            }
            Console.Write("Press any key to see your smallest & largest number >");
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("");
            Console.WriteLine("Smallest: " + biggiesmalls[0]);
            Console.WriteLine("Largest: " + biggiesmalls[1]);
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void ThreeByThree()
        {
            int[,] familyGuyFunnyMoments = new int[3, 3];
            int heyWhatsUp = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    familyGuyFunnyMoments[i, j] = heyWhatsUp;
                    heyWhatsUp++;

                }
                Console.WriteLine($"{familyGuyFunnyMoments[i, 0]}, {familyGuyFunnyMoments[i, 1]}, {familyGuyFunnyMoments[i, 2]}");
            }
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void ArrayCalendar()
        {
            int rowSum = 0;
            int columnSum = 0;
            int numAssign = 1;
            int[,] days = new int[29, 5];
            for(int x = 0; x < 29; ++x)
            {
                for (int y = 0; y < 5; ++y)
                {
                    days[x, y]= numAssign;
                    numAssign++;
                    //Console.WriteLine(days[x, y]);
                }
            }
            for (int x = 0; x < 29; ++x)
            {
                for (int y = 0; y < 5; ++y)
                {
                    rowSum += days[x, y];
                }
                Console.WriteLine("Sum of row " + (x + 1) + ": " + rowSum);
                rowSum = 0;
            }
            for (int y = 0; y < 5; ++y)
            {
                for (int x = 0; x < 5; ++x)
                {
                    columnSum += days[x, y];
                }
                Console.WriteLine("Sum of column " + (y + 1) + ": " + columnSum);
                columnSum = 0;
            }
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void HeroesMonsters()
        {
            int[] heroesHP = new int[5];//keeps track of players' HP
            int startingHP = 100; //exactly what it says it is!
            string[] heroNames = new string[5] { "Jon", "Steve", "Chris", "Rick", "Bill" };
            int moves = 5;
            int monsterAtk = 40;
            int[] monsterRNG = new int[2] {10, 40};
            for (int hp = 0; hp < 5; ++hp) //INITIALIZE HEROES' HP
            {
                heroesHP[hp] = startingHP;
            }
            for (int move = 5; move > 0; --move) //GAMEPLAY LOOP (LITERALLY)
            {
                Console.Clear();
                for (int hp = 0; hp < 5; ++hp) //SHOW HEROES' HP
                {
                    if (heroesHP[hp] < 0) heroesHP[hp] = 0;
                    Console.WriteLine("Hero #" + hp + ": " + heroNames[hp] + " - HP: " + heroesHP[hp]);
                }
                Console.WriteLine("Which hero will take the monster's attack? You have " + move + " moves left.");
                int.TryParse(Console.ReadLine(), out int chosen);
                if (chosen >= 0 && chosen <= 4)
                {
                    if (heroesHP[chosen] == 0)
                    {
                        Console.WriteLine("The monster tries to attack " + heroNames[chosen] + ", but is unsuccessful.");
                        Console.WriteLine("Because, of course, " + heroNames[chosen] + " is dead.");
                    }
                    else
                    {
                        heroesHP[chosen] -= monsterAtk;
                        Console.WriteLine("The monster swipes a claw at " + heroNames[chosen] + ", dealing " + monsterAtk + " damage.");
                        if (heroesHP[chosen] > 0)
                        {
                            Console.WriteLine("Yeowch!");
                        }
                        else
                        {
                            Console.WriteLine("It is a fatal blow. " + heroNames[chosen] + " has been slain.");
                        }
                    }
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("FINAL RESULTS:");
            Console.WriteLine("");
            for (int hp = 0; hp < 5; ++hp) //SHOW HEROES' HP AT THE END
            {
                if (heroesHP[hp] < 0) heroesHP[hp] = 0;
                Console.WriteLine("Hero #" + hp + ": " + heroNames[hp] + " - HP: " + heroesHP[hp]);
            }
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void HeroesMonstersDeluxe()
        {
            int[] heroesHP = new int[5];//keeps track of players' HP
            int startingHP = 100; //exactly what it says it is!
            string[] heroNames = new string[5] { "Robert", "John", "David", "Jamie", "Bill" };
            int moves = 5;
            int monsterAtk = 40;
            int[] monsterRNG = new int[2] { 10, 40 };
            for (int hp = 0; hp < 5; ++hp) //INITIALIZE HEROES' HP
            {
                heroesHP[hp] = startingHP;
            }
            for (int move = 5; move > 0; --move) //GAMEPLAY LOOP (LITERALLY)
            {
                Console.Clear();
                for (int hp = 0; hp < 5; ++hp) //SHOW HEROES' HP
                {
                    if (heroesHP[hp] < 0) heroesHP[hp] = 0;
                    Console.WriteLine("Hero #" + hp + ": " + heroNames[hp] + " - HP: " + heroesHP[hp]);
                }
                Console.WriteLine("Which hero will take the monster's attack? You have " + move + " moves left.");
                int.TryParse(Console.ReadLine(), out int chosen);
                if (chosen >= 0 && chosen <= 4)
                {
                    if (heroesHP[chosen] == 0)
                    {
                        Console.WriteLine("The monster tries to attack " + heroNames[chosen] + ", but is unsuccessful.");
                        Console.WriteLine("Because, of course, " + heroNames[chosen] + " is dead.");
                    }
                    else
                    {
                        heroesHP[chosen] -= monsterAtk;
                        Console.WriteLine("The monster swipes a claw at " + heroNames[chosen] + ", dealing " + monsterAtk + " damage.");
                        if (heroesHP[chosen] > 0)
                        {
                            Console.WriteLine("Yeowch!");
                        }
                        else
                        {
                            Console.WriteLine("It is a fatal blow. " + heroNames[chosen] + " has been slain.");
                        }
                    }
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("FINAL RESULTS:");
            Console.WriteLine("");
            for (int hp = 0; hp < 5; ++hp) //SHOW HEROES' HP AT THE END
            {
                if (heroesHP[hp] < 0) heroesHP[hp] = 0;
                Console.WriteLine("Hero #" + hp + ": " + heroNames[hp] + " - HP: " + heroesHP[hp]);
            }
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
        public void LameOfGroans()
        {
            int[,] food = new int[3,7];
            string[] drNames = new string[3];
            string[] veryStupid = new string[3] { "first", "second", "third" };
            for (int drag = 0; drag < 3; drag++)
            {
                Console.Write("What is the name of your " + veryStupid[drag] + " dragon? >");
                drNames[drag] = Console.ReadLine();
                Console.WriteLine("");
            }
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine("DAY " + (day + 1));
                for (int drfood = 0; drfood < 3; drfood++)
                {
                    int kg = 0;
                    Console.WriteLine("How many kg of food will you feed " + drNames[drfood] + "?");
                    int.TryParse(Console.ReadLine(), out kg);
                    food[drfood, day] = kg;
                }
            }
            Console.WriteLine("The week is now over. Press any key to see the results.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("AVERAGE AMT. OF FOOD EATEN (TOGETHER):");
            int overallAvg = 0;
            for (int day = 0; day < 7; day++)
            {
                int avg_A = 0;
                for (int avgfood = 0; avgfood < 3; avgfood++)
                {
                    avg_A += food[avgfood, day];
                }
                overallAvg += (avg_A);
            }
            overallAvg /= 7;
            Console.WriteLine(overallAvg + "kg");
            Console.WriteLine("AVERAGE AMT. OF FOOD EATEN (PER DRAGON):");
            int anyAvg = 0;
            for (int day = 0; day < 7; day++)
            {
                int avg_B = 0;
                for (int avgfood = 0; avgfood < 3; avgfood++)
                {
                    avg_B += food[avgfood, day];
                }
                anyAvg += (avg_B / 3);
            }
            anyAvg /= 7;
            Console.WriteLine(anyAvg + "kg");
            for (int day = 0; day < 7; day++)
            {
                int avg_B = 0;
                for (int avgfood = 0; avgfood < 3; avgfood++)
                {
                    avg_B += food[avgfood, day];
                }
                anyAvg += (avg_B / 3);
            }
            int[] biggiesmalls = new int[2] { 9999999, -9999999 };
            int[] which = new int[2];
            //int[] calcDrg = new int[3];
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (biggiesmalls[0] > food[x,y])
                    {
                        biggiesmalls[0] = food[x, y];
                        which[0] = x;
                    }
                    if (biggiesmalls[1] < food[x, y])
                    {
                        biggiesmalls[1] = food[x, y];
                        which[1] = x;
                    }
                }
            }
            Console.WriteLine("GREATEST AMT. EATEN IN ONE DAY:");
            Console.WriteLine("The dragon who ate the most on one day was " + drNames[which[1]] + ", who ate " + biggiesmalls[1] + "kg of food.");
            Console.WriteLine("LEAST AMT. EATEN IN ONE DAY:");
            Console.WriteLine("The dragon who ate the least on one day was " + drNames[which[0]] + ", who ate " + biggiesmalls[0] + "kg of food.");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
    }
}

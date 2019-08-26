using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] theArray = new int[10];
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = 10 - i;
                Console.WriteLine(theArray[i]);
            }
            Console.ReadKey(); */
            BoydzVoidz boyd = new BoydzVoidz();
            bool theLewp = true;
            /*int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Entry #" + (i + 1) + " >");
                int checkDisOut = int.Parse(Console.ReadLine());
                userArray[i] = checkDisOut;
            } 
            Console.WriteLine("The console will now begin to list your array values in reverse order.");
            Console.ReadKey();
            boyd.ReverseOrder(userArray);
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey(); */
            //
            /* int[] peepee = new int[10];
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
            Console.WriteLine("");
            Console.WriteLine(biggiesmalls[0]);
            Console.WriteLine(biggiesmalls[1]);
            Console.ReadKey(); */
            //
            /*int[,] familyGuyFunnyMoments = new int[3, 3];
            int heyWhatsUp = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    familyGuyFunnyMoments[i,j] = heyWhatsUp;
                    heyWhatsUp++;
                    
                }
                Console.WriteLine($"{familyGuyFunnyMoments[i,0]}, {familyGuyFunnyMoments[i, 1]}, {familyGuyFunnyMoments[i, 2]}");
            }
            Console.ReadKey(); */
            //
            //
            string[] exercises = new string[]
            {
                "Empty", "CountDown", "Reverse", "SmallestLargest", "ThreeByThree"
            };
            while (theLewp)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Bumbo's Palace.");
                Console.WriteLine("Type the following # for one of the exercises:");
                Console.WriteLine("1 - Countdown from 10");

                Console.WriteLine("2 - Reverse Order");
                Console.WriteLine("3 - Smallest & Largest");
                Console.WriteLine("4 - 3x3 Array");
                Console.WriteLine("5 - Sum of Rows & Columns");
                Console.WriteLine("6 - Heroes vs. Monsters");
                Console.WriteLine("7 - EPIC Game of Thrones Reference Funny!");
                int.TryParse(Console.ReadLine(),out int chosenExercise);
                Console.Clear();
                if (chosenExercise <= 0 || chosenExercise > 6)
                {
                    Console.WriteLine("No exercise with that number.");
                    Console.ReadKey();
                }
                if (chosenExercise == 1)
                {
                    boyd.CountDown();
                }
                if (chosenExercise == 2)
                {
                    boyd.Reverse();
                }
                if (chosenExercise == 3)
                {
                    boyd.SmallestLargest();
                }
                if (chosenExercise == 4)
                {
                    boyd.ThreeByThree();
                }
                if (chosenExercise == 5)
                {
                    boyd.ArrayCalendar();
                }
                if (chosenExercise == 6)
                {
                    boyd.HeroesMonsters();
                }
                if (chosenExercise == 7)
                {
                    boyd.LameOfGroans();
                }
            }
        }
    }
}

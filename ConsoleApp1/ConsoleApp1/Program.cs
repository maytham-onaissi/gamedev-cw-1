using System;

namespace ConsoleApp1
{
    class Program
    {
        double playerSpeed = 0; 
        static void Main(string[] args)
        {
             string characterName = "Ahmed";
                string superPower1 = "Iron shield";
                string superPower2 = "Night vision";
                int age = 15;
                float speed = 1.65F;
                System.Console.WriteLine("My name is {0} and my super powers are {1} and {2}. My age is {3} and my speed is {4}", characterName, superPower1, superPower2, age, speed);
                String heroName = "Sora";
                int heroHeight = 170;
                int heroAge = 18;
                String heroSuperPower1 = "Night vision";
                int ageDifference = Math.Abs(age - heroAge);
                Console.WriteLine(ageDifference);
                Console.WriteLine(heroSuperPower1 == superPower1 || heroSuperPower1 == superPower2);
                Console.WriteLine("The current player speed is" + getSpeed());
                
        }
         static void setSpeed()
        {
             playerSpeed = 2.5;
        }
         static double getSpeed()
        {
            return playerSpeed
        }
    }
}

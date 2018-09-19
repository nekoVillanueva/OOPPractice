using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class Program

    {
        static void Main(string[] args)
        {
            SuperPete pete = new SuperPete();
            pete.Strength = 100;
            pete.Name = "Pete";
            pete.BootSize = 10;
            pete.BikeSpeed = 60;
            SuperPete pete2 = new SuperPete("pete");
            Console.WriteLine("Your strength is " + pete.Strength);
            Console.WriteLine("Do you want to increase your strength Pete?");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                pete.IncreaseStrength();

            }
            Console.WriteLine("Your strength is now " + pete.Strength);
            Console.WriteLine("Your bikespeed is now " + pete2.BikeSpeed);






            //    //Dog woffy = new Dog();
            //    //Dog spot = new Dog();
            //    Dog woffy = new Dog(7, 8.5, 33.2, 190.1,"woofy");
            //    Dog spot = new Dog(15, 10.5, 100.9, 250.3,"spot");
            //    Console.WriteLine("woofy hair length is: {0}", woffy.HairLength);
            //    Console.WriteLine("spot hair length is: {0}", spot.HairLength);

            //     woffy.HairLength = 4;
            //    spot.HairLength = 6;
            //    woffy.GetSpeed(7);
            //    spot.GetSpeed(11);

            //    //    Console.WriteLine("woofy hair length is: {0}", woffy.HairLength);
            //    //    Console.WriteLine("spot hair length is: {0}", spot.HairLength);
            //    //    Console.WriteLine("woffy is running:{0}", woffy.GetSpeed(7));
        }

    }
}

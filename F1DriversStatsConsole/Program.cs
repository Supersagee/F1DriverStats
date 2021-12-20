using System;

namespace F1DriversStatsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F1 drivers
            string driverMax = "Max Verstappen";
            string driverLewis = "Lewis Hamilton";
            string driverCarlos = "Carlos Sainz";

            //Drivers ages
            int maxAge = 24;
            int lewisAge = 36;
            int carlosAge = 27;

            char raceWin = '1';

            bool worldChamp = true;

            //2021 drivers points
            double max2021Points = 395.5;
            decimal lewis2021Points = 387.5m;
            double carlos2021Points = 164.5;

            Console.WriteLine($"{driverMax} and {driverCarlos} had a total of {max2021Points + carlos2021Points} points in the 2021 season");
            Console.WriteLine($"{driverMax} and {driverLewis} both have a championship title: {worldChamp}");
            Console.WriteLine($"The combined age of the three drivers is {maxAge + lewisAge + carlosAge}");
            Console.WriteLine($"{driverLewis} has a total of 103 {raceWin}st places, and had a total of {lewis2021Points} points in 2021");

        }
    }
}

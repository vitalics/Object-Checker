using System;
using App.Builder;

namespace App.Cli
{
    class Cli
    {
        public CliHelper helper = new CliHelper();
        public bool Start()
        {
            Console.WriteLine("Welcome to submarine app. For start program type 'start' in your console");

            var maybeStart = Console.ReadLine();

            if (maybeStart.ToLower().Contains("start"))
            {
                return true;
            }
            return false;
        }

        internal int GetEmployeeCount()
        {
            helper.WriteLine("Proide information about employee count");

            int count = helper.ReadLineInt(true);
            return count;
        }

        public int GetDaysUnderWater()
        {
            helper.WriteLine("Proide information about days under water (in days)");

            int days = helper.ReadLineInt(true);
            return days;
        }
    }
}
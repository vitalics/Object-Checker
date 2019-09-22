using System;
using App.Builder;

namespace App
{
    class Program
    {
        static SubmarineBuilder builder = new SubmarineBuilder();
        static void Main(string[] args)
        {

            Cli.Cli cli = new Cli.Cli();

            bool isStart = cli.Start();

            while (!isStart)
            {
                cli.helper.Error("Your answer not contains 'start'. Try again");
                isStart = cli.Start();
            }

            int days = cli.GetDaysUnderWater();
            int employeeCount = cli.GetEmployeeCount();
            var submarine = builder.DaysUnderWater(days).EmployeeCount(employeeCount).build();
            cli.helper.WriteLine(submarine.ToString());
        }
    }
}

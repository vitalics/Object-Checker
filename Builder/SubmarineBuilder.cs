using System;
using App.Submarine;

namespace App.Builder
{
    class SubmarineBuilder : IBuilder<ISubmarine>
    {
        private int daysUnderWater = 0;
        private int employeeCount = 0;

        private Submarine.Submarine submarine;

        public ISubmarine build()
        {
            submarine = new Submarine.Submarine(employeeCount, daysUnderWater);
            return submarine;
        }

        public SubmarineBuilder DaysUnderWater(int daysUnderWater)
        {
            this.daysUnderWater = daysUnderWater;
            return this;
        }

        public SubmarineBuilder EmployeeCount(int employeeCount)
        {
            this.employeeCount = employeeCount;
            return this;
        }
    }
}
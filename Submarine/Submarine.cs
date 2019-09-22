namespace App.Submarine
{
    class Submarine : ISubmarine
    {
        private CliHelper helper = new CliHelper();

        // кол-во сотрудников
        public int EmployeeCount { get; private set; }

        // дней под водой
        public int DaysUnderWater { get; private set; }
        // погружение в метрах
        public int Depth { get; private set; }

        public Submarine(int EmployeeCount, int DaysUnderWater)
        {
            this.DaysUnderWater = DaysUnderWater;
            this.EmployeeCount = EmployeeCount;
        }

        public void Print()
        {
            helper.WriteLine($@"Submarine info:
                Employee count: {EmployeeCount}
                Days under water: {DaysUnderWater}
            ");
        }
    }
}
using App.Common;

namespace App.Submarine
{
    interface ISubmarine : IPrintable
    {
        int EmployeeCount { get; }
        int DaysUnderWater { get; }

    }
}
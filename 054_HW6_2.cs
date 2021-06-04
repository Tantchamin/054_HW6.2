using System;

namespace _054_HW6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double BoughtPrice = double.Parse(Console.ReadLine());
            double RealPrice = double.Parse(Console.ReadLine());
            double Different = Math.Abs(BoughtPrice - RealPrice);
            double Percent = (Different / RealPrice) * 100;

            if (BoughtPrice > RealPrice)
            {
                Console.WriteLine("Price increase by {0}%", Percent);
            }
            else
            {
                Console.WriteLine("Price reduce by {0}%", Percent);
            }
        }
    }
}

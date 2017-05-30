using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayOfEpoch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin = DateTime.MinValue;
            Console.WriteLine(string.Format("Begin: {0}", begin));

            DateTime end = DateTime.MaxValue.AddDays(-1);
            Console.WriteLine(string.Format("End: {0}", end));

            DateTime current = begin;

            DateTime minDiffDate = begin;
            int minDiff = int.MaxValue;

            int cnt = 0;
            while (current < end)
            {
                current = current.AddDays(1);
                cnt++;

                int daysOfEpoch = (current - begin).Days;

                int yymmdd = current.Day + current.Month * 100 + (current.Year % 100) * 10000;

                int diff = Math.Abs(daysOfEpoch - yymmdd);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    minDiffDate = current;
                    Console.WriteLine(string.Format("New min diff, current: {0}, yymmdd: {1}, daysOfEpoch: {2}, diff: {3}", current, yymmdd, daysOfEpoch, diff));
                }

                //if (cnt % 1000 == 0)
                //    Console.WriteLine(string.Format("Current: {0}", current));
            }

            Console.WriteLine("Thats all.");
            
            Console.ReadLine();
        }
    }
}

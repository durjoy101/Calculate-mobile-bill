using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal peakPulseRate = 0.30m;
            decimal offPeakPulseRate = 0.20m;

            DateTime startTime = DateTime.Parse("2019-08-31 08:59:13 am");
            DateTime endTime = DateTime.Parse("2019-08-31 09:00:39 am");

            TimeSpan peakStartTime = new TimeSpan(9, 0, 0);
            TimeSpan peakEndTime = new TimeSpan(22, 59, 59);
            
            TimeSpan offPeakStartTime = new TimeSpan(00, 0, 0);
            TimeSpan offPeakEndTime = new TimeSpan(8, 59, 59);

            decimal totalCost = 0;

            while (startTime < endTime)
            {
                TimeSpan callDuration;

                if (startTime.TimeOfDay >= peakStartTime && startTime.TimeOfDay <= peakEndTime)
                {
                    callDuration = endTime - startTime;
                    totalCost += (decimal)callDuration.TotalSeconds / 20 * peakPulseRate;
                }
                else
                {
                    callDuration = endTime - startTime;
                    totalCost += (decimal)callDuration.TotalSeconds / 20 * offPeakPulseRate;
                }

                startTime = endTime;
            }

            Console.WriteLine("Total Bill " + totalCost.ToString() + " taka");
            Console.ReadKey();
        }



    }

}

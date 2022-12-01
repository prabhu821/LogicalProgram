using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine("Press s to start");
            string data = Console.ReadLine().ToLower();
            if(data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("Press x for Exit");
                string stop = Console.ReadLine().ToLower();
                if(stop.Equals("x"))
                {
                    DateTime timespan1=DateTime.Now;
                    int endHr=timespan1.Hour;
                    int endMin=timespan1.Minute;
                    int endSec=timespan1.Second;
                    int endMilliSec=timespan1.Millisecond;
                    Console.WriteLine("Hours is : " + (endHr - startHr) + "\t Minutes is : " + (endMin - startMin) +
                        "\t Seconds is : " + (endSec - startSec) + "\t MilliSeconds is : " + (startMilliSec - startMilliSec));
                }
            }
        }
    }
}

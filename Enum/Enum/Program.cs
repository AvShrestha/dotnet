using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumApplication
{
    class Program
    {
        
            enum Days {sun, Mon, Tue, Wed, Thu, Fri, sat};
            static void Main(string[] args)
            {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday :{0}", WeekdayStart);
            Console.WriteLine("Friday :{0}",WeekdayEnd);
            Console.ReadKey();
            }
        }
    
}

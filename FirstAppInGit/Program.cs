using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppInGit
{
    class Program
    {


        static void DatetimeTest()
        {
            var datetimeNow = DateTime.UtcNow;

            var datetimeStr = new DateTime(datetimeNow.Ticks, DateTimeKind.Utc).ToLocalTime().ToString("dd MMM yyyy (ddd) HH:mm");

            Console.WriteLine("Date Time:{0}.", datetimeStr);

            Console.ReadLine();

        }


        static void SemesterInfosTest()
        {
            List<string> semesterInfos = new List<string>();
            semesterInfos.Add("AY2018 Term 4");
            semesterInfos.Add("AY2018 Term 3");
            semesterInfos.Add("AY2019 Semester 2");
            Console.WriteLine("Test:{0}.", string.Join("/", semesterInfos));
            
        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            SemesterInfosTest();
            //DatetimeTest();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

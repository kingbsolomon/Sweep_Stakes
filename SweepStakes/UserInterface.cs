using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        //static userinterface methods
        public static string NewContestantInfo()
        {
            string contestantInfo;
            Console.WriteLine("Enter the following Contestant information:");
            Console.Write("First Name: ");
            contestantInfo = Console.ReadLine();
            Console.Write("Last Name: ");
            contestantInfo += ',' + Console.ReadLine();
            Console.Write("Email Address: ");
            contestantInfo += ',' + Console.ReadLine();
            Console.WriteLine("Contestant Registration Number: ");
            contestantInfo += ',' + Console.ReadLine();
            return contestantInfo;
        }
    }
}

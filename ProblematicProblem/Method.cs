using System;
using System.Collections.Generic;
using System.Text;

namespace ProblematicProblem
{
    internal class Method
    {
        public static bool Participate(string ans)
        {
            while (true)
            {
                
                if (ans != null && (ans == "y" || ans == "yes"))
                {
                    return true;

                }
                else if (ans != null && (ans == "n" || ans == "no"))
                {
                    return false;

                }
                else
                {
                    Console.WriteLine("Only y or n Allowed");
                    ans = Console.ReadLine();
                }
            }
        }
    }
}

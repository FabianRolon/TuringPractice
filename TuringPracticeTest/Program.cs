using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringPracticeTest
{
    class Solution
    {
        public int CalPoints(string[] ops)
        {
            
            return int.Parse(ops[0]);
        }
    }

    class CalPoints
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[] space = new char[] { };

            string[] ops = Console.ReadLine().Split(space);

            //int output = solution.CalPoints(ops);

            //Console.WriteLine(output.ToString());
            foreach(var a in ops)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}

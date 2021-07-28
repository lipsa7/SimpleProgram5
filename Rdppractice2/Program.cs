using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.cowGraze(len));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static string cowGraze(int len)
        {
            double area;
            area = 3.14 * Math.Pow(len, 2);

            return String.Format("{0:0.00}", area.ToString());
        }
    }
}

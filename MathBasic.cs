using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_sofinans_calc
{
    public static class MathBasic
    {
        public static void Init()
        {
            Console.WriteLine("Math basic init success");
        }  

        public static string Calculate(double grantAmount, double teamHelp)
        {
            double res = 0;

            res = (grantAmount + teamHelp) * 30 / 100;

            string value = $"Объём софинансирования не более {res} рубля(ей)";
            return value;
        }
    }
}
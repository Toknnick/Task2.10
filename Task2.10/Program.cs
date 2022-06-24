using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 100;
            int numberFromRandom = random.Next(maxValue);
            int degree = 0;
            int numberInDegree = 0;

            for (; numberInDegree <= numberFromRandom; degree++)
            {
                numberInDegree = (int)Math.Pow(2, degree);
            }
        }
    }
}

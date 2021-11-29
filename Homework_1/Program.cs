using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = new int[15];
            Random random = new Random();
            for (int i = 0; i <= randomArr.Length; i++)
            {
                randomArr[i] = random.Next(10);
                Console.WriteLine(randomArr[i]);
            }
        }
    }
}

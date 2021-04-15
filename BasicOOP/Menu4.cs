using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Menu4
    {
        private int arrLength;

        public int ArrLength { get => arrLength; set => arrLength = value; }

        public int sumArray()
        {
            int[] input = new int[arrLength];
            int sum = 0;
            for (int i = 0; i < arrLength; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
                sum += input[i];
            }
            return sum;
        }
    }
}

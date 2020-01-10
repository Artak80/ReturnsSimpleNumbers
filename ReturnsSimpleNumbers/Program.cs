using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnsSimpleNumbers
{
    class Program
    {
        public static bool FindSimpleNumber(int x)
        {
            bool result = true;

            if (x > 1)
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else result = false;

            return result;
        }

        public static int[] ReceiveCountSimpleNumbers(int y)
        {
            int count = 0;
            int[] array = new int[y * 10];

            for (int i = 2; i < array.Length; i++)
            {
                if (FindSimpleNumber(i))
                {
                    array[count] = i;
                    count++;

                    if (count == y)
                    {
                        return array;
                    }
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            int y = new Random().Next(20, 100);
            int[] result = ReceiveCountSimpleNumbers(y);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    Console.Write($"{i} - {result[i]} \n");
                }
            }
            Console.ReadKey();
        }
    }
}

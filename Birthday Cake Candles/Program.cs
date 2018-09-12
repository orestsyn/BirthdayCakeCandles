using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            string s = Console.ReadLine();
            string[] stringArray = s.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(stringArray[i]);
            }
            int result = 0;
            int maxValue = array.Max();
            for (int i = 0; i < n; i++)
            {
                if (array[i] == maxValue) result++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

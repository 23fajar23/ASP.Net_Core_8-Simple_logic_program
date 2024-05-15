using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Logic_Program.SubProgram
{
    internal class MaxNumber
    {
        public void run()
        {
            int[] data = [1,5,3,7,2];
            int max = searchMaxValue(data);
            Console.Write("Max value from [ " + String.Join(",", data) + " ] ");
            Console.WriteLine("is : " + max);
        }

        private int searchMaxValue(int[] numbers)
        {
            try
            {
                int max = numbers[0];
                foreach (var item in numbers)
                {
                    if (item >= max)
                    {
                        max = item;
                    };
                }

                return max;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}

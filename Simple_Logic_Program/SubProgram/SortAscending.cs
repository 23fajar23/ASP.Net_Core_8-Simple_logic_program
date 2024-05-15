using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Logic_Program.SubProgram
{
    internal class SortAscending
    {
        public void run()
        {
            int[] numbers = [3,1,5,2,4];
            List<int> sorted = sorting(numbers);

            Console.WriteLine("Before sorting data : [ " + String.Join(",", numbers) + " ]");
            Console.WriteLine("After sorting data : [ " + String.Join(",", sorted) + " ]");

        }

        private List<int> sorting(int[] numbers)
        {
            List<int> list = numbers.ToList();
            List<int> sorted = new List<int>();

            while(list.Count > 0)
            {
                int indexMin = 0;
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[indexMin] > list[i])
                    {
                        indexMin = i;
                    }
                }

                sorted.Add(list[indexMin]);
                list.RemoveAt(indexMin);
            }

            return sorted;
        }

        
    }
}

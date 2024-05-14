using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Logic_Program.SubProgram
{
    internal class WordCount
    {
        public void run()
        {
            Console.Write("Input Sentence : ");
            try
            {
                string input = Console.ReadLine();

                int count = counting(input);
                Console.WriteLine("Word Counting : " + count);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private int counting(string word)
        {
            string[] split = word.Split(' ');
            if (word == "")
            {
                return 0;
            }
            return split.Length;
        }
    }
}

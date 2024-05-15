using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Logic_Program.SubProgram
{
    internal class MostShowLetter
    {
        public void run()
        {
            Console.Write("Input Sentence : ");
            try
            {
                string input = Console.ReadLine();

                string word = mostLetter(input);

                Console.WriteLine("Most frequently occurring letters : " + word);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string mostLetter(string word)
        {
            char[] split = word.ToCharArray();

            List<string> listLetter = new List<string>();
            List<int> countLetter = new List<int>();

            foreach (var item in split)
            {
                bool available = false;
                int indexData = 0;

                for (int i = 0; i < listLetter.Count; i++)
                {
                    if (listLetter[i] == item.ToString())
                    {
                        indexData = i;
                        available = true;
                    }
                }

                if (available)
                {
                    countLetter[indexData] = (countLetter[indexData] + 1);
                }
                else
                {
                    listLetter.Add(item.ToString());
                    countLetter.Add(0);
                }
            }

            //search most data
            int indexMax = 0;
            for (int i = 0; i < countLetter.Count; i++)
            {
                if (countLetter[indexMax] <= countLetter[i])
                {
                    indexMax = i;
                }
            }

            //Show all total occurrences of letters
            //Console.WriteLine(String.Join(",", countLetter));
            //Console.WriteLine(String.Join(",", listLetter));

            return listLetter[indexMax];

        }
    }
}

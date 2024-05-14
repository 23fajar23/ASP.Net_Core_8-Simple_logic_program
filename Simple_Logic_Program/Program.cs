using Simple_Logic_Program.SubProgram;

namespace Simple_Logic_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCount wordCount = new WordCount();
            MaxNumber maxNumber = new MaxNumber();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" 1. Word Counting  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            wordCount.run();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" 2. Max Number  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            maxNumber.run();

            //Console.WriteLine("Hello, World!");
        }
    }
}

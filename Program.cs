using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("The sum of two numbers is: " + program.over(11, 27));
            Console.WriteLine("The two things I hate the most are: " + program.over("manchester united", "valorant"));
        }
        public int over(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public string  over(string a, string b)
        {
            string c = a + " and " + b;
            return c;
        }
    }
}

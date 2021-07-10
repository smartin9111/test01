using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            display("mouse");
            Console.ReadKey();
        }
        static void display(string word)
        {
            Console.WriteLine("##-" + word + "-##");
        }
    }
}

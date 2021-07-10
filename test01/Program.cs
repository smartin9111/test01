using System;

namespace test01
{
    class Program
    {
        static int x = 2;
        static void Main(string[] args)
        {
            display("mouse");
            setXtoZero();
            int a = getResult();
            Console.WriteLine(a);
            double b = getSum(4.2, 5.3);
            Console.WriteLine(b);
            int c = getResult2(2000000000, 800000000);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static void display(string word)
        {
            Console.WriteLine("##-" + word + "-##");
        }

        static void setXtoZero() {
            x = 0;
        }

        static int getResult() {
            return x + 1;
        }

        static double getSum(double x, double y) {
            double z = x + y;
            return z;
        }

        //fuggveny tulterheles, overloading

        static int getResult2(int x, int y) {
            return x + y;
        }

    }
}
